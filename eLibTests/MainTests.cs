using eLibrary.Entities;
using System.Collections;
using System.Xml.Linq;

namespace eLibTests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void CreateUserController()
        {
            Assert.IsNotNull(new UserController());
        }

        [TestMethod]
        public void CreateBook()
        {
            Assert.IsNotNull(new Book());
        }

        [TestMethod]
        public void CreateUser()
        {
            Assert.IsNotNull(new User());
        }

        [TestMethod]
        public void NotNullConditions() 
        {
            Assert.IsNotNull(Condition.New);
            Assert.IsNotNull(Condition.Good);
            Assert.IsNotNull(Condition.Damaget);
            Assert.IsNotNull(Condition.Destroyed);
        }

        [TestMethod]
        public void NotNullStatuses()
        {
            Assert.IsNotNull(Status.Free);
            Assert.IsNotNull(Status.Booked);
        }

        [TestMethod]
        public void GetEqualUsername() 
        {
            string expectedUserName = "user";
            User user = new User("first", "last", "user", "password1" );

            Assert.AreEqual(expectedUserName, user.UserName);
        }

        [TestMethod]
        public void GetNames()
        {
            string expectedFirstName = "first";
            string expectedLastName = "last";

            User user = new User("first", "last", "user", "password1");

            Assert.AreEqual(expectedFirstName, user.FirstName);
            Assert.AreEqual(expectedLastName, user.LastName);   
        }

        [TestMethod]
        public void GetConfirmedPassword()
        {
            string input = "password";
            User user = new User("first", "last", "user", "password1");

            Assert.IsFalse(user.ConfirmPassword(input));
        }

        [TestMethod]
        public void TestBookValues() 
        {
            string firstName = "first";
            string lastName = "last";
            string username = "username";
            string password = "password";
            
            string name = "Book";
            string author = "Book Master";
            int year = 2023;
            User owner = new User(firstName, lastName, username, password);
            Status status = Status.Free;
            Condition condition = Condition.Destroyed;

            string expected = $"{owner.UserName};{status};{name};{author};{year};{condition};";

            Book book = new Book(name, year, author, condition, owner, status);

            Assert.AreEqual (expected, book.GetBookForSave());
        }

        
    }
}