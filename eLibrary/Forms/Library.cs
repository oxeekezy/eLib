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
using System.Xml.Linq;

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
            libraryTbx.Text = GetBookFromFile(Path.Combine(_mainPath,_booksFile));
            youLibrary.Text = GetBookFromFile(Path.Combine(_mainPath, _booksFile), _user);
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBook book = new AddBook(_user);
            book.Show();
        }

        private string GetBookFromFile(string path) 
        {
            string[] books = File.ReadAllLines(path);
            string formatedBook = string.Empty;

            foreach (string book in books) 
            {
                string[] sb = book.Split(';');

                formatedBook += $"Book: {sb[2]}\nAuthor: {sb[3]}\nYear: {sb[4]}\nCondition: {sb[5]}\nOwner: {sb[0]}\n\n";
            }

            //$"{_owner.UserName};{_status};{_name};{_author};{_year};{_condition};{_currentReader}"

            return formatedBook;
        }

        private string GetBookFromFile(string path, User user)
        {
            string[] books = File.ReadAllLines(path);
            string formatedBook = string.Empty;

            foreach (string book in books)
            {
                string[] sb = book.Split(';');

                if(user.UserName == sb[0])
                    formatedBook += $"Book: {sb[2]}\nAuthor: {sb[3]}\nYear: {sb[4]}\nCondition: {sb[5]}\nOwner: {sb[0]}\n\n";
            }

            return formatedBook;
        }

        private void userLbl_DoubleClick(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            Close();
        }
    }
}
