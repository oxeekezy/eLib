using eLibrary.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.Forms
{
    public partial class Registation : Form
    {
        protected Login _loginForm;
        UserController controller = new UserController();
        public Registation(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            bool valid = controller.Registration(firstNameTbx.Text, lastNameTbx.Text, usernameTbx.Text, 
                                    passwordTbx.Text, confirmPasswordTbx.Text);

            if (valid)
            {
                MessageBox.Show($"Success registration {usernameTbx.Text}!");
                Close();
                _loginForm.Show();
            }
            else 
            {
                MessageBox.Show($"Passwords not confirm or user exist!");
            } 
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Close();
            _loginForm.Show();
        }

        private void showpasswordCh_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCh.Checked)
                passwordTbx.PasswordChar = '*';
            else
                passwordTbx.PasswordChar = ' ';

        }

        private void Registation_Load(object sender, EventArgs e)
        {

        }
    }
}
