namespace Scorchy.GUI.Forms
{
    partial class SettingsManager
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
            this.buttonSaveSettings = new MetroFramework.Controls.MetroButton();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textboxOrchUrl = new MetroFramework.Controls.MetroTextBox();
            this.toggleResolveSIDs = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.toggleHideInfoMessages = new MetroFramework.Controls.MetroToggle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBoxRowsPerPage = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(249, 358);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 0;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseSelectable = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(345, 358);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseSelectable = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Orchestrator WebService Url";
            // 
            // textboxOrchUrl
            // 
            // 
            // 
            // 
            this.textboxOrchUrl.CustomButton.Image = null;
            this.textboxOrchUrl.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.textboxOrchUrl.CustomButton.Name = "";
            this.textboxOrchUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxOrchUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxOrchUrl.CustomButton.TabIndex = 1;
            this.textboxOrchUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxOrchUrl.CustomButton.UseSelectable = true;
            this.textboxOrchUrl.CustomButton.Visible = false;
            this.textboxOrchUrl.Lines = new string[0];
            this.textboxOrchUrl.Location = new System.Drawing.Point(206, 60);
            this.textboxOrchUrl.MaxLength = 32767;
            this.textboxOrchUrl.Name = "textboxOrchUrl";
            this.textboxOrchUrl.PasswordChar = '\0';
            this.textboxOrchUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxOrchUrl.SelectedText = "";
            this.textboxOrchUrl.SelectionLength = 0;
            this.textboxOrchUrl.SelectionStart = 0;
            this.textboxOrchUrl.ShortcutsEnabled = true;
            this.textboxOrchUrl.Size = new System.Drawing.Size(214, 23);
            this.textboxOrchUrl.TabIndex = 2;
            this.textboxOrchUrl.UseSelectable = true;
            this.textboxOrchUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxOrchUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toggleResolveSIDs
            // 
            this.toggleResolveSIDs.AutoSize = true;
            this.toggleResolveSIDs.Location = new System.Drawing.Point(340, 89);
            this.toggleResolveSIDs.Name = "toggleResolveSIDs";
            this.toggleResolveSIDs.Size = new System.Drawing.Size(80, 17);
            this.toggleResolveSIDs.TabIndex = 3;
            this.toggleResolveSIDs.Text = "Off";
            this.toggleResolveSIDs.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(297, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Resolve SIDs in Job view via requests to ADDS DC";
            // 
            // toggleHideInfoMessages
            // 
            this.toggleHideInfoMessages.AutoSize = true;
            this.toggleHideInfoMessages.Location = new System.Drawing.Point(340, 112);
            this.toggleHideInfoMessages.Name = "toggleHideInfoMessages";
            this.toggleHideInfoMessages.Size = new System.Drawing.Size(80, 17);
            this.toggleHideInfoMessages.TabIndex = 3;
            this.toggleHideInfoMessages.Text = "Off";
            this.toggleHideInfoMessages.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(156, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(178, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Hide informational messages";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(80, 135);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(254, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Rows per page in grid views (Jobs, Events)";
            // 
            // textBoxRowsPerPage
            // 
            // 
            // 
            // 
            this.textBoxRowsPerPage.CustomButton.Image = null;
            this.textBoxRowsPerPage.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textBoxRowsPerPage.CustomButton.Name = "";
            this.textBoxRowsPerPage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxRowsPerPage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxRowsPerPage.CustomButton.TabIndex = 1;
            this.textBoxRowsPerPage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxRowsPerPage.CustomButton.UseSelectable = true;
            this.textBoxRowsPerPage.CustomButton.Visible = false;
            this.textBoxRowsPerPage.Lines = new string[0];
            this.textBoxRowsPerPage.Location = new System.Drawing.Point(345, 135);
            this.textBoxRowsPerPage.MaxLength = 32767;
            this.textBoxRowsPerPage.Name = "textBoxRowsPerPage";
            this.textBoxRowsPerPage.PasswordChar = '\0';
            this.textBoxRowsPerPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRowsPerPage.SelectedText = "";
            this.textBoxRowsPerPage.SelectionLength = 0;
            this.textBoxRowsPerPage.SelectionStart = 0;
            this.textBoxRowsPerPage.ShortcutsEnabled = true;
            this.textBoxRowsPerPage.Size = new System.Drawing.Size(75, 23);
            this.textBoxRowsPerPage.TabIndex = 6;
            this.textBoxRowsPerPage.UseSelectable = true;
            this.textBoxRowsPerPage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxRowsPerPage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SettingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.Controls.Add(this.textBoxRowsPerPage);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.toggleHideInfoMessages);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.toggleResolveSIDs);
            this.Controls.Add(this.textboxOrchUrl);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveSettings);
            this.Name = "SettingsManager";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton buttonSaveSettings;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textboxOrchUrl;
        private MetroFramework.Controls.MetroToggle toggleResolveSIDs;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle toggleHideInfoMessages;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBoxRowsPerPage;

    }
}