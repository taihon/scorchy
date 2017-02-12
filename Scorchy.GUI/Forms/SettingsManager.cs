using MetroFramework;
using MetroFramework.Forms;
using Scorchy.GUI.Classes;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Scorchy.GUI.Forms
{
    public partial class SettingsManager : MetroForm
    {
        static SettingsManager _instance;
        public SettingsManager()
        {
            InitializeComponent();
            try
            {
                var t = Settings.Instance;
                toggleResolveSIDs.DataBindings.Add("Checked", t, "ResolveSID");
                toggleHideInfoMessages.DataBindings.Add("Checked", t, "HideInfoAlerts");
                textboxOrchUrl.DataBindings.Add("Text", t, "OrchestratorUrl");
                textBoxRowsPerPage.DataBindings.Add("Text", t, "RowsPerPage");
            }
            catch (Exception e)
            {
                MetroMessageBox.Show(this, "Error while loading settings: " + e.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Save()
        {
            var path = "Settings.xml";
            XmlSerializer x = new XmlSerializer(typeof(Settings));
            using (StreamWriter sw = new StreamWriter(path))
            {
                x.Serialize(sw, Settings.Instance);
            }
            this.Close();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            this.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
