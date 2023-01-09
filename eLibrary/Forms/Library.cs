using eLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.Forms
{
    public partial class Library : Form
    {
        User _user;

        private string _booksFile = "library.bs";
        private string _mainPath = Directory.GetCurrentDirectory();

        public Library(User user)
        {
            InitializeComponent();
            _user = user;
            userLbl.Text = _user.UserName;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            GetBookFromFile(Path.Combine(_mainPath,_booksFile));
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook(_user);
            book.Show();
        }

        private string[] GetBookFromFile(string path) 
        {
            string[] books = File.ReadAllLines(path);


            return books;
        }
    }
}
