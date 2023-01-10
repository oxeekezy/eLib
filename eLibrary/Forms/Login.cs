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
    public partial class Login : Form
    {
        UserController controller = new UserController();
        public Login()
        {
            InitializeComponent();

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            Hide();

            Registation reg = new Registation(this);
            reg.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = controller.Login(usernameTbx.Text, passwordTbx.Text);

            if (user != null)
            {
                Library lib = new Library(user);

                Hide();
                lib.Show();
            }
            else 
            {
                MessageBox.Show("Username or password uncorrect!");
            }
        }
    }
}
