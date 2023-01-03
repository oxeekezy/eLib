using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Entities
{
    internal class Book
    {
        private string _name;
        private int _year;
        private string _author;
        private string _condition;
        private User _owner;
        private User _currentReader;
        private Status _status;

        public Book(string name, int year, string author, string condition, User owner, Status status)
        {
            _name = name;
            _year = year;
            _author = author;
            _condition = condition;
            _owner = owner;
            _status = status;
        }

        public void SetReader(User currentReader) 
        {
            _currentReader = currentReader;
        }


    }
}
