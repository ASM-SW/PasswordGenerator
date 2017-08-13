This password generator creates passwords that are a random series of words followed by a random series of characters.
The words are read in from a dictionary file that contains one word per line.
The characters are entered into a text box.

This is based on:

     https://nakedsecurity.sophos.com/2016/08/18/nists-new-password-rules-what-you-need-to-know/
 

Configuration information is stored in teh application data dir:  
  C:\Users\<USERNAME>\AppData\Roaming\PasswordGen\Configuration.xml
The following items are remembered:
- Dictionary file
- Special character list
- Number of words and characters in the password
- Number of Passwords generated
