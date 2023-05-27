using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTask.Models
{
    public class User
    {
        /// <summary>
        /// User model
        /// </summary>
        public User()
        {
            Login = string.Empty;
            Name = string.Empty;
        }
        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}
