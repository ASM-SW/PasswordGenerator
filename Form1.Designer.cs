namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.openWordFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WordListFileName = new System.Windows.Forms.TextBox();
            this.WordListBut = new System.Windows.Forms.Button();
            this.wordCountCtrl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialCharactersCtl = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.passwordOutput = new System.Windows.Forms.RichTextBox();
            this.passwordCount = new System.Windows.Forms.Label();
            this.passwordCntCtrl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.capitalizeWordCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordCountCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordCntCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word List File";
            // 
            // openWordFileDialog1
            // 
            this.openWordFileDialog1.FileName = "openFileDialog1";
            // 
            // WordListFileName
            // 
            this.WordListFileName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordListFileName.Location = new System.Drawing.Point(130, 19);
            this.WordListFileName.Name = "WordListFileName";
            this.WordListFileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.WordListFileName.Size = new System.Drawing.Size(343, 25);
            this.WordListFileName.TabIndex = 1;
            // 
            // WordListBut
            // 
            this.WordListBut.Location = new System.Drawing.Point(488, 19);
            this.WordListBut.Name = "WordListBut";
            this.WordListBut.Size = new System.Drawing.Size(28, 20);
            this.WordListBut.TabIndex = 0;
            this.WordListBut.Text = "...";
            this.WordListBut.UseVisualStyleBackColor = true;
            this.WordListBut.Click += new System.EventHandler(this.WordListBut_Click);
            // 
            // wordCountCtrl
            // 
            this.wordCountCtrl.Location = new System.Drawing.Point(130, 49);
            this.wordCountCtrl.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.wordCountCtrl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordCountCtrl.Name = "wordCountCtrl";
            this.wordCountCtrl.Size = new System.Drawing.Size(53, 20);
            this.wordCountCtrl.TabIndex = 2;
            this.wordCountCtrl.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.wordCountCtrl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Word/Character Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Special Characters";
            // 
            // specialCharactersCtl
            // 
            this.specialCharactersCtl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCharactersCtl.Location = new System.Drawing.Point(130, 140);
            this.specialCharactersCtl.Name = "specialCharactersCtl";
            this.specialCharactersCtl.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.specialCharactersCtl.Size = new System.Drawing.Size(343, 25);
            this.specialCharactersCtl.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(30, 206);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Generate";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(30, 470);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passwordOutput
            // 
            this.passwordOutput.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordOutput.Location = new System.Drawing.Point(130, 182);
            this.passwordOutput.Name = "passwordOutput";
            this.passwordOutput.Size = new System.Drawing.Size(393, 311);
            this.passwordOutput.TabIndex = 8;
            this.passwordOutput.Text = "";
            // 
            // passwordCount
            // 
            this.passwordCount.AutoSize = true;
            this.passwordCount.Location = new System.Drawing.Point(15, 74);
            this.passwordCount.Name = "passwordCount";
            this.passwordCount.Size = new System.Drawing.Size(107, 13);
            this.passwordCount.TabIndex = 9;
            this.passwordCount.Text = "Number To Generate";
            // 
            // passwordCntCtrl
            // 
            this.passwordCntCtrl.Location = new System.Drawing.Point(130, 74);
            this.passwordCntCtrl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.passwordCntCtrl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.passwordCntCtrl.Name = "passwordCntCtrl";
            this.passwordCntCtrl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordCntCtrl.Size = new System.Drawing.Size(53, 20);
            this.passwordCntCtrl.TabIndex = 10;
            this.passwordCntCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordCntCtrl.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Capitalize Words";
            // 
            // capitalizeWordCheckbox
            // 
            this.capitalizeWordCheckbox.AutoSize = true;
            this.capitalizeWordCheckbox.Location = new System.Drawing.Point(130, 102);
            this.capitalizeWordCheckbox.Name = "capitalizeWordCheckbox";
            this.capitalizeWordCheckbox.Size = new System.Drawing.Size(15, 14);
            this.capitalizeWordCheckbox.TabIndex = 12;
            this.capitalizeWordCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 505);
            this.Controls.Add(this.capitalizeWordCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordCntCtrl);
            this.Controls.Add(this.passwordCount);
            this.Controls.Add(this.passwordOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.specialCharactersCtl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordCountCtrl);
            this.Controls.Add(this.WordListBut);
            this.Controls.Add(this.WordListFileName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wordCountCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordCntCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openWordFileDialog1;
        private System.Windows.Forms.TextBox WordListFileName;
        private System.Windows.Forms.Button WordListBut;
        private System.Windows.Forms.NumericUpDown wordCountCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specialCharactersCtl;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox passwordOutput;
        private System.Windows.Forms.Label passwordCount;
        private System.Windows.Forms.NumericUpDown passwordCntCtrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox capitalizeWordCheckbox;
    }
}

