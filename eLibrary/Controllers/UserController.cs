using eLibrary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.Controllers
{
    public class UserController
    {
        private string _usersFile = "users.bs";
        //private string _mainPath = Directory.GetCurrentDirectory();
        public User Login(string username, string password)
        {
            string userData = FindInfo(username);

            if (userData == null)
                return null;

            if (userData.Split(';')[3].Equals(password)) 
            {
                var spl = userData.Split(';');
                User user = new User(spl[0], spl[1], spl[2], spl[3]);

                return user;
            }

            return null;
        }

        public bool Registration(string firstName, string lastName, string username, 
                                 string password, string confirmPassword) 
        {
            User user = new User(firstName, lastName, username, password);
            if (!user.ConfirmPassword(confirmPassword))
                return false;

            if(!SaveInfo(_usersFile, user))
                return false;

            return true;
        }

        public bool SaveInfo(string filename, User user) 
        {
            if (FindInfo(user.UserName)!=null)
                return false;

            string formatedLine = $"{user.FirstName};{user.LastName};{user.UserName};{user.Password}";

            using (StreamWriter sw = new StreamWriter(filename, append: true)) 
            {
                sw.WriteLine(formatedLine); 
            }

            return true;
        }

        public string FindInfo(string username) 
        {
            using (StreamReader sr = new StreamReader(_usersFile)) 
            {
                while (!sr.EndOfStream) 
                {
                    string row = sr.ReadLine();
                    if (row.Split(';')[2].Equals(username)) 
                    {
                        return row;
                    }
                }
            }

            return null;
        }
    }
}
