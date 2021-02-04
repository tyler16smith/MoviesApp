using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class FullMovieList
    {
        // create a new static List from NewMovies
        private static List<NewMovies> applications = new List<NewMovies>();

        // make the list enumerate (add onto itself) using the Lambda symbol
        public static IEnumerable<NewMovies> Applications => applications;

        public static void AddApplication(NewMovies application)
        {
            if (application.Title != "Independence Day")
            {
                applications.Add(application);
            }
        }
    }
}
