using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Model
{
    public enum eGender
    {
        male,
        female,
    }
    public  class User
    {


        public int Id { get; private set; } 
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int Age { get; private set; }
        public eGender Gender { get; set; }
        public User(int Id, string Name, string Email, string Password, int Age, eGender Gender) 
        {
            Random random = new Random();
            this.Id = random.Next(100000, 1000000); // טווח בין 100000 ל-999999
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Age = Age;
            this.Gender = Gender;
        }
        

    }
}
