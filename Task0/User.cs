using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0
{
    class User
    {
        public readonly DateTime dateTime;
        public byte Age { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public User(byte age, string login, string name, string surname)
        {
            Age = age;
            Login = login;
            Name = name;
            Surname = surname;
        }
        public User()
        {
            dateTime = DateTime.Now;
        }
    }
}
