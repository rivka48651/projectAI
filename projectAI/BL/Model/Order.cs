using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
  
    public class Order
    {

        public int Id { get; set; }
        public User User { get; set; }
        public List<Movie> Movie { get; set; }=new List<Movie>();
        public DateOnly Date{ get; set; }  
        public Statuse Statuse { get; set; }
        
    }
}
