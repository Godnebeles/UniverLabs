using System.ComponentModel.DataAnnotations;

namespace MyLibrary.Models
{
    public class User
    {
        public User(int id, string userName, string email, string phone, string password, string salt)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
            Salt = salt;
        }

        public int Id { get; private set; }

        public string UserName { get; private set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Incorrect Email")]
        public string Email { get; private set; }

        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Incorrent Phone Number")]
        public string Phone { get; private set; }

        public string Password { get; private set; }

        public string Salt { get; private set; } 
    }
}
