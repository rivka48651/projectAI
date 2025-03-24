using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{

   

    public class Movie
    {
        public int id {  get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieUrl { get; set; }        
        public string MovieCategory { get; set; }
        public int MoviePrice { get; set; } 
        public DateOnly CreationDate { get; set; }
        public AgeGroup ageGroup { get; set; }
        public bool IsWoman { get; set; }   
        public Movie(int id, string movieName, string movieDescription, string movieUrl, string movieCategory, int moviePrice ,DateOnly CreationDate, enums ageGroup,bool IsWoman)
        {
            this.id = id;
            this.MovieName = movieName;
            this.MovieDescription = movieDescription;
            this.MovieUrl = movieUrl;
            this.MovieCategory = movieCategory;
           this.MoviePrice = moviePrice;
            this.CreationDate = CreationDate;
            this.ageGroup = ageGroup;   
            this.IsWoman = IsWoman;

        }
    }
}
