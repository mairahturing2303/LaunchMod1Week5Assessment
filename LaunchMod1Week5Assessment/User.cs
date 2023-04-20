using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

UserNamespace
{
    public class UserData
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        private string Password { get; set; }
        public bool IsLoggedIn { get; set; }

        public UserData (string name, string email)
        {
            Name = name;
            Email = email;
            IsLoggedIn = false;
        }

        public bool Is_Setup_Complete()
        {
            if (Name != null && Email != null && Password != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }

        public void Create_Password(string email, string password)
        {
            if (email == Email)
            {
                Password = password;
            }

            if (Password != null)
            {
                var confirmation = "Password Created";
            }
        }

        public string Log_In(string password)
        {
            if (password == Password)
            {
                IsLoggedIn = true;
                return "Logged In";
            }
            return "Not Logged In";
        }

        public void Log_Out()
        {
            IsLoggedIn = false;
        }
    }
}
