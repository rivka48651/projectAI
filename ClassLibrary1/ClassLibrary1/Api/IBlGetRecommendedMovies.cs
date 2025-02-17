using bl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using bl.Model;

namespace bl.Api
    
{
    public interface IBlGetRecommendedMovies
    {
        List<Movie> GetRecommendedMovies(User user);
    }
}
