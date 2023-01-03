using eLibrary.Entities;
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
    public partial class Library : Form
    {
        User _user;
        public Library(User user)
        {
            InitializeComponent();
            _user = user;
            userLbl.Text = _user.UserName;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_user.UserName);
        }
    }
}
