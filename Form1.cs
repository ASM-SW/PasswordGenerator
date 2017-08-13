using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// This password generator creates passwords that are a random series of words followed by a random series of characters.
/// The words are read in from a dictionary file that contains one word per line.
/// The characters are entered into a control.
/// 
/// This is based on:
///     https://nakedsecurity.sophos.com/2016/08/18/nists-new-password-rules-what-you-need-to-know/
///     
/// 
/// Configuration information is stored in teh application data dir:  
///      C:\Users\<USERNAME>\AppData\Roaming\PasswordGen\Configuration.xml
///  The following items are remembered:
///     Dictionary file
///     Special character list
///     Number of words and characters in the password
///     Number of Passwords generated
/// </summary>


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get values from config file
            ConfigPasswordGenerator.DeSerialize(config.ConfigFileName, ref config);
            WordListFileName.Text = config.WordFileName;
            specialCharactersCtl.Text = config.SpecialCharacters;

            if (config.WordCount < wordCountCtrl.Minimum || config.WordCount > wordCountCtrl.Maximum)
                config.WordCount = (wordCountCtrl.Maximum - wordCountCtrl.Minimum) / 2;
            wordCountCtrl.Value = config.WordCount;

            if (config.PasswordCount < passwordCntCtrl.Minimum || config.PasswordCount > passwordCntCtrl.Maximum)
                config.PasswordCount = (passwordCntCtrl.Maximum - passwordCntCtrl.Minimum) / 2;

            passwordCntCtrl.Value = config.PasswordCount;
            capitalizeWordCheckbox.Checked = config.CapitalizeWord;
        }

        private ConfigPasswordGenerator config = new ConfigPasswordGenerator();

        // generate a random number, Use Crypto service so it is not repeatable
        private static RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        private static uint RandomNumber(uint min, uint max)
        {
            byte[] arrayBytes = new byte[4];
            Rand.GetBytes(arrayBytes);
            uint value = BitConverter.ToUInt32(arrayBytes, 0);

            // scale to min/max inclusive
            return (uint)((0.5 + min + (max - min) * ((double)value / uint.MaxValue)));
        }

        // get wordlist file name
        private void WordListBut_Click(object sender, EventArgs e)
        {
            string fileName = WordListFileName.Text;
            if(fileName.Length >0)
            {
                openWordFileDialog1.FileName = fileName;
                string path = Path.GetDirectoryName(fileName);
                if (Directory.Exists(path))
                    openWordFileDialog1.InitialDirectory = path;
                else
                    openWordFileDialog1.InitialDirectory = string.Empty;
            }

            if (openWordFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            WordListFileName.Text = openWordFileDialog1.FileName;
        }

        // Generate passwords
        private void generateButton_Click(object sender, EventArgs e)
        {
            List<string> wordList = new List<string>();
            Cursor.Current = Cursors.WaitCursor;
            string fileName = WordListFileName.Text;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Word file list does not exist: " + fileName);
                return;
            }

            // read in the file and all words to list
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;
                wordList.Add(line.ToLower());
            }

            char[] specialCharacterList = specialCharactersCtl.Text.ToArray<char>();

            // create the passwords strings
            passwordOutput.Clear();
            for (int iPasswords = 0; iPasswords < passwordCntCtrl.Value; iPasswords++)
            {
                if (iPasswords > 0)
                    passwordOutput.AppendText("\n");  // add carriage return if not the first password

                StringBuilder passwordBuilder = new StringBuilder();

                // add the words to the password
                for (int iWords = 0; iWords < wordCountCtrl.Value; iWords++)
                {
                    int index = (int)RandomNumber(0, (UInt32)wordList.Count - 1);

                    // capitalize first letter of word
                    char firstLetter = wordList[index].First();
                    if (capitalizeWordCheckbox.Checked)
                        passwordBuilder.Append(firstLetter.ToString().ToUpper());
                    else
                        passwordBuilder.Append(firstLetter);

                    passwordBuilder.Append(wordList[index].ToString().Substring(1));
                }

                // add special characters at end
                for (int iSpecialCharacters = 0; iSpecialCharacters < wordCountCtrl.Value; iSpecialCharacters++)
                {
                    int index = (int)RandomNumber(0, (UInt32)specialCharacterList.Count() - 1);
                    passwordBuilder.Append(specialCharacterList[index]);
                }
                passwordOutput.AppendText(passwordBuilder.ToString());
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // save configuration
            config.WordFileName = WordListFileName.Text;
            config.SpecialCharacters = specialCharactersCtl.Text;
            config.PasswordCount = passwordCntCtrl.Value;
            config.WordCount = wordCountCtrl.Value;
            config.CapitalizeWord = capitalizeWordCheckbox.Checked;

            config.Serialize(config.ConfigFileName);
            Close();
        }

    }
}
