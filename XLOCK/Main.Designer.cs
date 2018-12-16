namespace XLOCK
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.lbFiles = new VisualPlus.Toolkit.Controls.DataManagement.VisualListBox();
            this.btnDecrypt = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btnEncrypt = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.txtPassword = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.lblEPassword = new System.Windows.Forms.Label();
            this.txtConsole = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.btnOpenFile = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.btnOpenFolder = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.lblConsole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFiles
            // 
            this.lbFiles.AlternateColors = false;
            this.lbFiles.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.lbFiles.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.lbFiles.Border.Color = System.Drawing.Color.DimGray;
            this.lbFiles.Border.HoverColor = System.Drawing.Color.DimGray;
            this.lbFiles.Border.HoverVisible = true;
            this.lbFiles.Border.Rounding = 6;
            this.lbFiles.Border.Thickness = 1;
            this.lbFiles.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.lbFiles.Border.Visible = true;
            this.lbFiles.ForeColor = System.Drawing.Color.White;
            this.lbFiles.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.lbFiles.ItemHeight = 18;
            this.lbFiles.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.lbFiles.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.lbFiles.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.lbFiles.Location = new System.Drawing.Point(199, 96);
            this.lbFiles.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(205, 108);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.Text = "Files";
            this.lbFiles.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.lbFiles.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFiles.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFiles.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFiles.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lbFiles.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.lbFiles.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColorState.Disabled = System.Drawing.Color.Empty;
            this.btnDecrypt.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnDecrypt.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnDecrypt.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnDecrypt.Border.Color = System.Drawing.Color.DimGray;
            this.btnDecrypt.Border.HoverColor = System.Drawing.Color.DimGray;
            this.btnDecrypt.Border.HoverVisible = true;
            this.btnDecrypt.Border.Rounding = 6;
            this.btnDecrypt.Border.Thickness = 1;
            this.btnDecrypt.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnDecrypt.Border.Visible = true;
            this.btnDecrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Image = null;
            this.btnDecrypt.Location = new System.Drawing.Point(101, 54);
            this.btnDecrypt.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(84, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnDecrypt.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btnDecrypt.TextStyle.Enabled = System.Drawing.Color.White;
            this.btnDecrypt.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecrypt.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDecrypt.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDecrypt.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnDecrypt.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColorState.Disabled = System.Drawing.Color.Empty;
            this.btnEncrypt.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnEncrypt.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnEncrypt.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnEncrypt.Border.Color = System.Drawing.Color.DimGray;
            this.btnEncrypt.Border.HoverColor = System.Drawing.Color.DimGray;
            this.btnEncrypt.Border.HoverVisible = true;
            this.btnEncrypt.Border.Rounding = 6;
            this.btnEncrypt.Border.Thickness = 1;
            this.btnEncrypt.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnEncrypt.Border.Visible = true;
            this.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Image = null;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 54);
            this.btnEncrypt.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(86, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnEncrypt.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btnEncrypt.TextStyle.Enabled = System.Drawing.Color.White;
            this.btnEncrypt.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEncrypt.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEncrypt.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEncrypt.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnEncrypt.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPassword.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.txtPassword.Border.Color = System.Drawing.Color.DimGray;
            this.txtPassword.Border.HoverColor = System.Drawing.Color.DimGray;
            this.txtPassword.Border.HoverVisible = true;
            this.txtPassword.Border.Rounding = 6;
            this.txtPassword.Border.Thickness = 1;
            this.txtPassword.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtPassword.Border.Visible = true;
            this.txtPassword.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPassword.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.txtPassword.ButtonBorder.HoverVisible = true;
            this.txtPassword.ButtonBorder.Rounding = 6;
            this.txtPassword.ButtonBorder.Thickness = 1;
            this.txtPassword.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtPassword.ButtonBorder.Visible = true;
            this.txtPassword.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPassword.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ButtonIndent = 3;
            this.txtPassword.ButtonText = "visualButton";
            this.txtPassword.ButtonVisible = false;
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Image = null;
            this.txtPassword.ImageSize = new System.Drawing.Size(16, 16);
            this.txtPassword.ImageVisible = false;
            this.txtPassword.ImageWidth = 35;
            this.txtPassword.Location = new System.Drawing.Point(12, 25);
            this.txtPassword.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.Size = new System.Drawing.Size(173, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextBoxWidth = 163;
            this.txtPassword.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtPassword.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtPassword.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.txtPassword.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtPassword.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtPassword.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.txtPassword.Watermark.Text = "Watermark text";
            this.txtPassword.Watermark.Visible = false;
            this.txtPassword.WordWrap = true;
            // 
            // lblEPassword
            // 
            this.lblEPassword.AutoSize = true;
            this.lblEPassword.ForeColor = System.Drawing.Color.White;
            this.lblEPassword.Location = new System.Drawing.Point(9, 6);
            this.lblEPassword.Name = "lblEPassword";
            this.lblEPassword.Size = new System.Drawing.Size(109, 13);
            this.lblEPassword.TabIndex = 4;
            this.lblEPassword.Text = "Encryption Password:";
            // 
            // txtConsole
            // 
            this.txtConsole.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtConsole.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.txtConsole.Border.Color = System.Drawing.Color.DimGray;
            this.txtConsole.Border.HoverColor = System.Drawing.Color.DimGray;
            this.txtConsole.Border.HoverVisible = true;
            this.txtConsole.Border.Rounding = 6;
            this.txtConsole.Border.Thickness = 1;
            this.txtConsole.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtConsole.Border.Visible = true;
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(12, 96);
            this.txtConsole.MaxLength = 2147483647;
            this.txtConsole.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConsole.ShowSelectionMargin = false;
            this.txtConsole.Size = new System.Drawing.Size(173, 108);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtConsole.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConsole.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConsole.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConsole.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtConsole.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.txtConsole.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.ForeColor = System.Drawing.Color.White;
            this.lblFiles.Location = new System.Drawing.Point(195, 80);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 6;
            this.lblFiles.Text = "Files:";
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColorState.Disabled = System.Drawing.Color.Empty;
            this.btnOpenFile.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnOpenFile.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnOpenFile.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnOpenFile.Border.Color = System.Drawing.Color.DimGray;
            this.btnOpenFile.Border.HoverColor = System.Drawing.Color.DimGray;
            this.btnOpenFile.Border.HoverVisible = true;
            this.btnOpenFile.Border.Rounding = 6;
            this.btnOpenFile.Border.Thickness = 1;
            this.btnOpenFile.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnOpenFile.Border.Visible = true;
            this.btnOpenFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Image = null;
            this.btnOpenFile.Location = new System.Drawing.Point(198, 54);
            this.btnOpenFile.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(205, 23);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Open Selected File";
            this.btnOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnOpenFile.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btnOpenFile.TextStyle.Enabled = System.Drawing.Color.White;
            this.btnOpenFile.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenFile.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenFile.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOpenFile.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnOpenFile.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColorState.Disabled = System.Drawing.Color.Empty;
            this.btnOpenFolder.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnOpenFolder.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnOpenFolder.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnOpenFolder.Border.Color = System.Drawing.Color.DimGray;
            this.btnOpenFolder.Border.HoverColor = System.Drawing.Color.DimGray;
            this.btnOpenFolder.Border.HoverVisible = true;
            this.btnOpenFolder.Border.Rounding = 6;
            this.btnOpenFolder.Border.Thickness = 1;
            this.btnOpenFolder.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnOpenFolder.Border.Visible = true;
            this.btnOpenFolder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Image = null;
            this.btnOpenFolder.Location = new System.Drawing.Point(198, 25);
            this.btnOpenFolder.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(205, 23);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnOpenFolder.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btnOpenFolder.TextStyle.Enabled = System.Drawing.Color.White;
            this.btnOpenFolder.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenFolder.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenFolder.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOpenFolder.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnOpenFolder.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click_1);
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.ForeColor = System.Drawing.Color.White;
            this.lblConsole.Location = new System.Drawing.Point(9, 80);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(48, 13);
            this.lblConsole.TabIndex = 9;
            this.lblConsole.Text = "Console:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(416, 216);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.lblEPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "XLOCK - File Locker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualPlus.Toolkit.Controls.DataManagement.VisualListBox lbFiles;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnDecrypt;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnEncrypt;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox txtPassword;
        private System.Windows.Forms.Label lblEPassword;
        private VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox txtConsole;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Timer Update;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnOpenFile;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnOpenFolder;
        private System.Windows.Forms.Label lblConsole;
    }
}

