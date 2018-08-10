using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyfisInnosoftPOSIntegrator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            picIntegrateLoading.Hide();
            lblNotificationLabel.Hide();
            btnStop.Hide();
            btnHide.Hide();

            //String btnActivityLogView = "View";
            //grdActivityLog.Rows.Add("12321", "12321", "12321321", btnActivityLogView);

            grdActivityLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnIntegrate_Click(object sender, EventArgs e)
        {
            btnIntegrate.Hide();

            picIntegrateLoading.Show();
            lblNotificationLabel.Show();
            btnStop.Show();
            btnHide.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnIntegrate.Show();

            picIntegrateLoading.Hide();
            lblNotificationLabel.Hide();
            btnStop.Hide();
            btnHide.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
