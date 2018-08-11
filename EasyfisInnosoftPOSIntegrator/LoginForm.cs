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
    public partial class LoginForm : Form
    {
        public Data.pos13dbDataContext db = new Data.pos13dbDataContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        public void Login()
        {
            if (txtUsername.Text.Equals(String.Empty) || txtPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Please provide username and password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                var login = from d in db.MstUsers where d.UserName.Equals(txtUsername.Text) && d.Password.Equals(txtPassword.Text) select d;
                if (login.Any())
                {
                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
