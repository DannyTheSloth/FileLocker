# XLOCK File Locker
A simple file locker I made with 2Toad's Rijndael256 encryption library, and DarkByte7's VisualPlus controls.
# How to use 

**Adding files:**
To add files, drag the file you want in XLOCK into the gray box labeled with 'Files', this is how you will interact with files in the 'XLOCKFiles' folder.

**Encrypting files:**
To encrypt a file, fill in a password of atleast 6 characters under the 'Encryption Password' field, click on the file, and hit encrypt.

**Decrypting files:**
To decrypt a file, click on the file, fill in the password you encrypted it with under the 'Encryption Password' field, and hit decrypt.

**Deleting files:**
To delete a file from XLOCK, select the file, and press the delete button. Always back your files up, kids.

**Opening files:**
To open files, select the file, and hit the 'Open Selected File' button.

![capture](https://user-images.githubusercontent.com/39781618/50071962-3312b980-0199-11e9-8eed-1968cd4cbbe5.PNG)

# Using the shell
Start by typing in '-' into the command line located under the console, as the dash character is the prefix for the commands. A suggestion menu should pop up, use the arrow keys to navigate, and press enter to append the text to the command line. 
**Commands:**

-DeleteFile(Filename) *Deletes a specified file in the XLOCKFiles folder in case the delete feature doesn't work*

-DeleteAllFiles() *Mass deletes all files in the XLOCKFiles folder*

-GetMD5(Filename) *Calculates MD5 checksum of specified file from the XLOCKFiles folder*

-ViewFile(Filename) *Opens file with default opening program in XLOCKFiles folder in case the open selected file does not work*

-SetKeySize(Keysize) *Sets encryption key size to either 256, 192, or 128.*

-ClearConsole() *Clears console*

-RickRoll() *Plays Never Gonna Give You Up By Rick Astley*
