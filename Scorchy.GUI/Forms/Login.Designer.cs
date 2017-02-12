namespace Scorchy.GUI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.radioLoginWindows = new System.Windows.Forms.RadioButton();
            this.radioLoginCustom = new System.Windows.Forms.RadioButton();
            this.customCredsGroup = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.loginLabel = new MetroFramework.Controls.MetroLabel();
            this.textPassword = new MetroFramework.Controls.MetroTextBox();
            this.textLogin = new MetroFramework.Controls.MetroTextBox();
            this.buttonLogin = new MetroFramework.Controls.MetroButton();
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.customCredsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scorchy";
            // 
            // radioLoginWindows
            // 
            this.radioLoginWindows.AutoSize = true;
            this.radioLoginWindows.Location = new System.Drawing.Point(32, 69);
            this.radioLoginWindows.Name = "radioLoginWindows";
            this.radioLoginWindows.Size = new System.Drawing.Size(171, 17);
            this.radioLoginWindows.TabIndex = 0;
            this.radioLoginWindows.TabStop = true;
            this.radioLoginWindows.Text = "Login as current Windows user";
            this.radioLoginWindows.UseVisualStyleBackColor = true;
            this.radioLoginWindows.CheckedChanged += new System.EventHandler(this.loginRadio_CheckedChanged);
            // 
            // radioLoginCustom
            // 
            this.radioLoginCustom.AutoSize = true;
            this.radioLoginCustom.Location = new System.Drawing.Point(32, 92);
            this.radioLoginCustom.Name = "radioLoginCustom";
            this.radioLoginCustom.Size = new System.Drawing.Size(91, 17);
            this.radioLoginCustom.TabIndex = 1;
            this.radioLoginCustom.TabStop = true;
            this.radioLoginCustom.Text = "Login custom:";
            this.radioLoginCustom.UseVisualStyleBackColor = true;
            this.radioLoginCustom.CheckedChanged += new System.EventHandler(this.loginRadio_CheckedChanged);
            // 
            // customCredsGroup
            // 
            this.customCredsGroup.Controls.Add(this.passwordLabel);
            this.customCredsGroup.Controls.Add(this.loginLabel);
            this.customCredsGroup.Controls.Add(this.textPassword);
            this.customCredsGroup.Controls.Add(this.textLogin);
            this.customCredsGroup.Location = new System.Drawing.Point(12, 124);
            this.customCredsGroup.Name = "customCredsGroup";
            this.customCredsGroup.Size = new System.Drawing.Size(327, 70);
            this.customCredsGroup.TabIndex = 6;
            this.customCredsGroup.TabStop = false;
            this.customCredsGroup.Text = "Login in as:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 38);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 19);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(20, 13);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 19);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Login";
            // 
            // textPassword
            // 
            // 
            // 
            // 
            this.textPassword.CustomButton.Image = null;
            this.textPassword.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.textPassword.CustomButton.Name = "";
            this.textPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassword.CustomButton.TabIndex = 1;
            this.textPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassword.CustomButton.UseSelectable = true;
            this.textPassword.CustomButton.UseWaitCursor = true;
            this.textPassword.CustomButton.Visible = false;
            this.textPassword.Lines = new string[0];
            this.textPassword.Location = new System.Drawing.Point(117, 38);
            this.textPassword.MaxLength = 32767;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '●';
            this.textPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassword.SelectedText = "";
            this.textPassword.SelectionLength = 0;
            this.textPassword.SelectionStart = 0;
            this.textPassword.ShortcutsEnabled = true;
            this.textPassword.Size = new System.Drawing.Size(204, 23);
            this.textPassword.TabIndex = 1;
            this.textPassword.UseSelectable = true;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.UseWaitCursor = true;
            this.textPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textLogin
            // 
            // 
            // 
            // 
            this.textLogin.CustomButton.Image = null;
            this.textLogin.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.textLogin.CustomButton.Name = "";
            this.textLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textLogin.CustomButton.TabIndex = 1;
            this.textLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textLogin.CustomButton.UseSelectable = true;
            this.textLogin.CustomButton.Visible = false;
            this.textLogin.Lines = new string[0];
            this.textLogin.Location = new System.Drawing.Point(117, 13);
            this.textLogin.MaxLength = 32767;
            this.textLogin.Name = "textLogin";
            this.textLogin.PasswordChar = '\0';
            this.textLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textLogin.SelectedText = "";
            this.textLogin.SelectionLength = 0;
            this.textLogin.SelectionStart = 0;
            this.textLogin.ShortcutsEnabled = true;
            this.textLogin.Size = new System.Drawing.Size(204, 23);
            this.textLogin.TabIndex = 0;
            this.textLogin.UseSelectable = true;
            this.textLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonLogin
            // 
            this.buttonLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonLogin.Location = new System.Drawing.Point(12, 200);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseSelectable = true;
            this.buttonLogin.Click += new System.EventHandler(this.login_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(264, 200);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseSelectable = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelDescription.Location = new System.Drawing.Point(12, 51);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(327, 15);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "(graphical user interface for System Center Orchestrator 2012 R2)";
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(346, 236);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.customCredsGroup);
            this.Controls.Add(this.radioLoginCustom);
            this.Controls.Add(this.radioLoginWindows);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.customCredsGroup.ResumeLayout(false);
            this.customCredsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioLoginWindows;
        private System.Windows.Forms.RadioButton radioLoginCustom;
        private System.Windows.Forms.GroupBox customCredsGroup;
        private MetroFramework.Controls.MetroButton buttonLogin;
        private MetroFramework.Controls.MetroButton buttonExit;
        private MetroFramework.Controls.MetroTextBox textPassword;
        private MetroFramework.Controls.MetroTextBox textLogin;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel loginLabel;
        private MetroFramework.Controls.MetroLabel labelDescription;
    }
}