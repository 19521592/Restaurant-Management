using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.GUI.Login
{
    public class AccountApp
    {
        public AccountApp(AccountApp account)
        {
            this.Id = account.Id;
            this.Username = account.Username;
            this.Passwords = account.Passwords;
        }
        public AccountApp()
        {

        }
        public string Id { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
    }
}
