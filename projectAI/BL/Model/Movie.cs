using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Model
{
    public class Movie
    {
        public int id {  get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieUrl { get; set; }        
        public string MovieCategory { get; set; }
        public Movie(int id, string movieName, string movieDescription, string movieUrl, string movieCategory)
        {
            this.id = id;
            this.MovieName = movieName;
            this.MovieDescription = movieDescription;
            this.MovieUrl = movieUrl;
            this.MovieCategory = movieCategory;
        }
    }
}
