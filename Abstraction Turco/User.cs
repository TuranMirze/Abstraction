using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Abstraction_Turco
{
    internal class User
    {
        private static int _id = 1;
        public int Id { get;  set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public User[] users;



        public User(string fullName, string email)
        {
            Fullname = fullName;
            Email = email;  
           
            users = new User[0];

            Id = _id++;
        }


        public void AddUser(User user)
        {

            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
        }


        public bool PasswordChecker(string password)
        {
            bool check = false;
            if (password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"[0-9]"))
            {
                check = true;
            }
            return check;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Id:"+Id);
            Console.WriteLine("Fullname:"+Fullname);
            Console.WriteLine("Email:"+Email);
        }


    }
}
