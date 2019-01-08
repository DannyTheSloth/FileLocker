namespace XLOCK
{
    partial class btnSetExtension
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnSetExtension));
            this.txtExtension = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnExtension = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.SuspendLayout();
            // 
            // txtExtension
            // 
            this.txtExtension.AutoCompleteCustomSource.AddRange(new string[] {
            "-ViewFile(Filename)",
            "-GetMD5(Filename)",
            "-DeleteFile(Filename)",
            "-SetKeySize(Size)",
            "-DeleteAllFiles()",
            "-ClearConsole()",
            "-RickRoll()",
            "-HideFolder()"});
            this.txtExtension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtExtension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtExtension.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtExtension.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.txtExtension.Border.Color = System.Drawing.Color.DimGray;
            this.txtExtension.Border.HoverColor = System.Drawing.Color.DimGray;
            this.txtExtension.Border.HoverVisible = true;
            this.txtExtension.Border.Rounding = 6;
            this.txtExtension.Border.Thickness = 1;
            this.txtExtension.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtExtension.Border.Visible = true;
            this.txtExtension.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtExtension.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.txtExtension.ButtonBorder.HoverVisible = true;
            this.txtExtension.ButtonBorder.Rounding = 6;
            this.txtExtension.ButtonBorder.Thickness = 1;
            this.txtExtension.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.txtExtension.ButtonBorder.Visible = true;
            this.txtExtension.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExtension.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtExtension.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtExtension.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtExtension.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.ButtonIndent = 3;
            this.txtExtension.ButtonText = "visualButton";
            this.txtExtension.ButtonVisible = false;
            this.txtExtension.ForeColor = System.Drawing.Color.White;
            this.txtExtension.Image = null;
            this.txtExtension.ImageSize = new System.Drawing.Size(16, 16);
            this.txtExtension.ImageVisible = false;
            this.txtExtension.ImageWidth = 35;
            this.txtExtension.Location = new System.Drawing.Point(12, 25);
            this.txtExtension.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.PasswordChar = '\0';
            this.txtExtension.ReadOnly = false;
            this.txtExtension.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExtension.Size = new System.Drawing.Size(187, 23);
            this.txtExtension.TabIndex = 13;
            this.txtExtension.TextBoxWidth = 177;
            this.txtExtension.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtExtension.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExtension.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExtension.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExtension.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtExtension.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.txtExtension.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.txtExtension.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtExtension.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.txtExtension.Watermark.Text = "Watermark text";
            this.txtExtension.Watermark.Visible = false;
            this.txtExtension.WordWrap = true;
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.ForeColor = System.Drawing.Color.White;
            this.lblExtension.Location = new System.Drawing.Point(9, 9);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(56, 13);
            this.lblExtension.TabIndex = 14;
            this.lblExtension.Text = "Extension:";
            // 
            // btnExtension
            // 
            this.btnExtension.BackColorState.Disabled = System.Drawing.Color.Empty;
            this.btnExtension.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.btnExtension.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnExtension.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(57)))));
            this.btnExtension.Border.Color = System.Drawing.Color.DimGray;
            this.btnExtension.Border.HoverColor = System.Drawing.Color.DimGray;
            this.btnExtension.Border.HoverVisible = true;
            this.btnExtension.Border.Rounding = 6;
            this.btnExtension.Border.Thickness = 1;
            this.btnExtension.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.btnExtension.Border.Visible = true;
            this.btnExtension.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExtension.ForeColor = System.Drawing.Color.White;
            this.btnExtension.Image = null;
            this.btnExtension.Location = new System.Drawing.Point(104, 54);
            this.btnExtension.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(95, 23);
            this.btnExtension.TabIndex = 15;
            this.btnExtension.Text = "Set Extension";
            this.btnExtension.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnExtension.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.btnExtension.TextStyle.Enabled = System.Drawing.Color.White;
            this.btnExtension.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExtension.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExtension.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExtension.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.btnExtension.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // btnSetExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(211, 216);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.txtExtension);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnSetExtension";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox txtExtension;
        private System.Windows.Forms.Label lblExtension;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton btnExtension;
    }
}