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

namespace XLOCK
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
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
            Rijndael.Encrypt(ToEncrypt, Output, txtPassword.Text, KeySize.Aes256);
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
                Rijndael.Decrypt(ToDecrypt, Output, txtPassword.Text, KeySize.Aes256);
                File.Delete(ToDecrypt);
                WriteToConsole("Decrypted file successfully");
            } catch { File.Delete(FilePath + Path.GetFileNameWithoutExtension(ToDecrypt)); }
        }
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(FilePath + lbFiles.SelectedItem.ToString());
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
    }
}
