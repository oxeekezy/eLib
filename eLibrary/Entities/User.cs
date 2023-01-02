using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLibrary.Entities
{
    internal class User
    {
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;

        public User(string firstName, string lastName, string userName, string password) 
        {
            _firstName= firstName;
            _lastName = lastName;
            _userName = userName;
            _password = password;
        }

        public bool ConfirmPassword(string input) 
        {
            if(input.Equals(_password))
                return true;

            return false;
        }
    }
}
