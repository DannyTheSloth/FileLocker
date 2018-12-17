using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Rijndael256;
using System.Diagnostics;
using System.Security.Cryptography;
using Rijndael = Rijndael256.Rijndael;
using System.Net;

namespace XLOCK
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Rijndael256.KeySize KS = new Rijndael256.KeySize();
        public readonly string FilePath = Environment.CurrentDirectory + @"\XLOCKFiles\";
        private void WriteToConsole(string ToWrite)
        {
            if (!string.IsNullOrWhiteSpace(txtConsole.Text))
            {
                txtConsole.AppendText(Environment.NewLine + ToWrite);
            } else
            {
                txtConsole.AppendText(ToWrite);
            }
            txtConsole.ScrollToCaret();
        }
        private void CheckFolder()
        {
            if (!Directory.Exists(FilePath))
            {
                WriteToConsole("File not found (XLOCKFiles)");
                Directory.CreateDirectory(FilePath);
                WriteToConsole("Created XLOCKFiles directory");
            }
            return;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            KS = KeySize.Aes256;
            CheckFolder();
            Update.Start();
        }
        private void Update_Tick(object sender, EventArgs e)
        {
            CheckFolder();
            DirectoryInfo EFolder = new DirectoryInfo(FilePath);
            foreach (var file in EFolder.GetFiles())
            {
                try
                {
                    if (!lbFiles.Items.Contains(Path.GetFileName(file.FullName)))
                    {
                        lbFiles.Items.Add(Path.GetFileName(file.FullName));
                    }                    
                } catch { WriteToConsole("Error adding items to file viewer"); }
            }
            for (int itemnum = lbFiles.Items.Count - 1; itemnum >= 0; --itemnum)
            {
                if (!File.Exists(FilePath + lbFiles.Items[itemnum].ToString()))
                {
                    lbFiles.Items.RemoveAt(itemnum);
                }
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string ToEncrypt;
            try { ToEncrypt = FilePath + lbFiles.SelectedItem.ToString(); }
            catch (Exception) { MessageBox.Show("You must select an item to encrypt or decrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("You must enter a password to decrypt or encrypt files!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtPassword.Text.Length < 6) { DialogResult dr = MessageBox.Show("Are you sure you would like to use this password? Any password less than 6 characters is deemed unsecure.", "Password Unsecure", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); if (dr == DialogResult.No) { return; } }
            string Password = txtPassword.Text;
            string Output = FilePath + lbFiles.SelectedItem.ToString() + ".encrypted";
            if (Path.GetExtension(ToEncrypt).ToLower() == ".encrypted") { MessageBox.Show("File is already encrypted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; } else { }
            Rijndael.Encrypt(ToEncrypt, Output, txtPassword.Text, KS);
            File.Delete(ToEncrypt);
            WriteToConsole("Encrypted file successfully");
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ToDecrypt = "";
            try
            {
                
                try { ToDecrypt = FilePath + lbFiles.SelectedItem.ToString(); }
                catch (Exception) { MessageBox.Show("You must select an item to encrypt or decrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (string.IsNullOrWhiteSpace(txtPassword.Text)) { MessageBox.Show("You must enter a password to decrypt or encrypt files!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string Password = txtPassword.Text;
                if (Path.GetExtension(ToDecrypt).ToLower() == ".encrypted") { } else { MessageBox.Show("File is already decrypted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                string Output = FilePath + Path.GetFileNameWithoutExtension(ToDecrypt);              
                Rijndael.Decrypt(ToDecrypt, Output, txtPassword.Text, KS);
                File.Delete(ToDecrypt);
                WriteToConsole("Decrypted file successfully");
            } catch { File.Delete(FilePath + Path.GetFileNameWithoutExtension(ToDecrypt)); }
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(FilePath + lbFiles.SelectedItem.ToString());
                WriteToConsole("Opened " + lbFiles.SelectedItem.ToString());
            } catch { }
        }
        private void btnOpenFolder_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", FilePath);
        }
        private void lbFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string SelectedFile = "";
                try { SelectedFile = lbFiles.SelectedItem.ToString(); } catch { return; }
                File.Delete(FilePath + SelectedFile);
            }
        }

        private void lblVisit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DannyTheSloth/XLock-File-Locker");
        }
        private void CheckCommand(string Command)
        {
            if (Command.Contains("-ViewFile") && Command.Contains("(") && Command.Contains(")"))
            {
                foreach (var item in lbFiles.Items)
                {
                    string Item = item.ToString();
                    if (txtShell.Text.Contains(Item))
                    {
                        Process.Start(FilePath + Item);
                        WriteToConsole("Opened " + Path.GetFileName(Item));
                        txtShell.Text = "";
                    }
                }
                
            } else
            if (Command.Contains("-GetMD5") && Command.Contains("(") && Command.Contains(")"))
            {
                foreach (var item in lbFiles.Items)
                {
                    string Item = item.ToString();
                    if (txtShell.Text.Contains(Item))
                    {
                        using (var MD5Calc = MD5.Create())
                        {
                            using (var Stream = File.OpenRead(FilePath + Item))
                            {
                                WriteToConsole("MD5 Checksum: " + BitConverter.ToString(MD5Calc.ComputeHash(Stream)).Replace("-", "").ToLowerInvariant());
                                txtShell.Text = "";
                                Stream.Close();
                            }
                            MD5Calc.Clear();
                        }
                        
                    }
                }
                
            } else
            if (Command.Contains("-DeleteFile") && Command.Contains("(") && Command.Contains(")"))
            {
                foreach (var item in lbFiles.Items)
                {
                    string Item = item.ToString();
                    if (txtShell.Text.Contains(Item))
                    {
                        File.Delete(FilePath + Item);
                        WriteToConsole("Deleted " + Item);
                        txtShell.Text = "";
                    }
                    
                }
                
               
            } else
            if (Command.Contains("-SetKeySize"))
            {
                    if (Command.Contains("(256)"))
                    {
                        KS = KeySize.Aes256;
                        WriteToConsole("KeySize set to 256 bits");
                    txtShell.Text = "";
                    return;
                    }
                    if (Command.Contains("(192)"))
                    {
                        KS = KeySize.Aes192;
                        WriteToConsole("KeySize set to 192 bits");
                    txtShell.Text = "";
                    return;
                    }
                    if (Command.Contains("(128)"))
                    {
                        KS = KeySize.Aes128;
                        WriteToConsole("KeySize set to 128 bits");
                    txtShell.Text = "";
                    return;
                    }
                    else { MessageBox.Show("Key size must be 256, 192, or 128!", "Error"); return; }
            } else 
            if (Command.Equals("-ClearConsole()"))
            {
                txtConsole.Clear();
                txtShell.Text = "";
            } else
            if (Command.Equals("-DeleteAllFiles()"))
            {
                DirectoryInfo Files = new DirectoryInfo(FilePath);
                foreach (var file in Files.GetFiles())
                {
                    WriteToConsole("Deleted " + Path.GetFileName(file.FullName).ToString());
                    File.Delete(file.FullName);
                }
                txtShell.Text = "";
            } else 
            if (Command.Equals("-RickRoll()")) 
            {
                WriteToConsole("Never Gonna Give You Up");
                Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                txtShell.Text = "";
            } else { MessageBox.Show("Invalid Command", "Error"); return; }
        }                      
        private void txtShell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtShell.Text) && !txtShell.Text.Contains("-")) { MessageBox.Show("Invalid Command", "Error"); return; } else
                {
                    CheckCommand(txtShell.Text);
                }
            }
        }
        private void txtShell_TextChanged(object sender, EventArgs e)
        {

        }
        private void FileDropped(object sender, DragEventArgs e)
        {
            string[] FilesDropped = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var file in FilesDropped)
            {
                File.Copy(Path.GetFullPath(file), FilePath + Path.GetFileName(file));
                WriteToConsole("Copied " + Path.GetFileName(file) + " into XLOCKFiles");
            }

        }
        private void lbFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
