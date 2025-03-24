using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
   
    public  class User
    {
        public int Id { get; private set; } 
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public AgeGroup ageGroup { get; set; }
        public eGender Gender { get; set; }
    }
}
