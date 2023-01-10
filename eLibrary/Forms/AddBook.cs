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
    public partial class AddBook : Form
    {
        User _user;
        Book _book;

        private string _booksFile = "library.bs";
        private string _mainPath = Directory.GetCurrentDirectory();

        public AddBook(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            yearUpDown.Minimum = 1600;
            yearUpDown.Maximum = DateTime.Now.Year;
            yearUpDown.Value = yearUpDown.Maximum-5;

            conditionBox.Items.Add(Condition.New);
            conditionBox.Items.Add(Condition.Good);
            conditionBox.Items.Add(Condition.Damaget);
            conditionBox.Items.Add(Condition.Destroyed);
            conditionBox.SelectedIndex = 0;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            _book = new Book(bookNameBox.Text, (int)yearUpDown.Value, 
                             $"{authorFNBox.Text} {authorMNBox.Text} {authorLNBox.Text}",
                             (Condition)conditionBox.SelectedItem, _user, Status.Free);

            SaveBook(Path.Combine(_mainPath,_booksFile), _book);

            MessageBox.Show("Book succesfuly added!");
            Close();
        }

        private void SaveBook(string path, Book book) 
        {
            using (StreamWriter sw = new StreamWriter(path, append:true))
            {
                sw.WriteLine(book.GetBookForSave());
            }
        }
    }
}
