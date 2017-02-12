using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scorchy.Core.Providers;
using Scorchy.Core;
using Scorchy.Core.Interfaces;
using Scorchy.Core.Models;
using MetroFramework.Forms;
using MetroFramework;
using Scorchy.GUI.Classes;

namespace Scorchy.GUI.Forms
{
    public partial class Login : MetroForm
    {
        static Login _instance;
        public static Login Instance { get { if (_instance == null) _instance = new Login(); return _instance; } }
        IUserProvider _userProv;
        public Login()
        {
            InitializeComponent();
            radioLoginWindows.Checked = true;
            radioLoginWindows.Select();
            textLogin.Enabled = false;
            textPassword.Enabled = false;
            if (Settings.Instance.OrchestratorUrl == null)
            {
                var sm = new SettingsManager();
                sm.ShowDialog();
            }
            _userProv = new ActiveDirectoryUserProvider();
        }

        private void loginRadio_CheckedChanged(object sender, EventArgs e)
        {
            var controls = new Control[]{ textLogin, textPassword, customCredsGroup, loginLabel, passwordLabel };
            foreach (Control c in controls)
            {
                c.Enabled = radioLoginCustom.Checked;
                c.Visible = radioLoginCustom.Checked;
            }
            textLogin.Text = "";
            textPassword.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            User usr;
            if (radioLoginCustom.Checked)
            {
                usr = _userProv.ValidateLoginAttempt(textLogin.Text, textPassword.Text, _userProv.GetCurrentDomain());
            }
            else
            {
                usr = _userProv.GetCurrentUser();
            }
            if (usr != null)
            {
                MetroMessageBox.Show(this, string.Format("Logged in as {0}", usr.Name),"Login ok",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Main _f = new Main(usr);
                _f.FormClosing += MainFormClosing;
                _f.Show();
                textPassword.Text = "";
                Hide();
            }
            else
            {
                MessageBox.Show("Authorization failure!\r\nAccess Denied!");
            }
        }
        private void MainFormClosing(object sender, FormClosingEventArgs args)
        {
            Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
