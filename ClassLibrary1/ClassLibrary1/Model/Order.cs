using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Model
{
    public enum Statuse{
    Oreder,
    History
    }
    public class Order
    {

        public int Id { get; set; }
        public User User { get; set; }
        public Movie Movie { get; set; }
        public DateOnly Date{ get; set; }  
        public Statuse Statuse { get; set; }
        public Order(int id, User user, Movie movie, DateOnly date, Statuse statuse)
        {
            this.Id = id;
            this.User = user;
            this.Movie = movie;
            this.Date = date;
            this.Statuse = statuse;
        }
    }
}
