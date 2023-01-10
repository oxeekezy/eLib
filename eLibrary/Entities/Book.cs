using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Entities
{
    public class Book
    {
        private string _name;
        private string _author;
        private int _year;
        private User _owner;
        private User _currentReader;
        private Status _status;
        private Condition _condition;

        public Book(string name, int year, string author, Condition condition, User owner, Status status)
        {
            _name = name;
            _year = year;
            _author = author;
            _condition = condition;
            _owner = owner;
            _status = status;
        }

        public Book() 
        {
            //Test method
        }

        public void SetReader(User currentReader) 
        {
            _currentReader = currentReader;
        }

        public string GetBookForSave() 
        {
            return $"{_owner.UserName};{_status};{_name};{_author};{_year};{_condition};{_currentReader}";
        }
    }
}
