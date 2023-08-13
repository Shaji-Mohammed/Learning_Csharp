using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Movies
    {
        private string name;
        private string director;
        private double IMDBrating;
        private string ratings;

        public Movies(string name, string director, double IMDBrating, string ratings)
        {
            this.name = name;
            this.director = director;
            this.IMDBrating = IMDBrating;
            Ratings = ratings;
        }

        public string Ratings
        {
            get { return ratings; } 
            set
            {
                if (value == "PG" || value == "PG-13" || value == "R" )
                {
                    ratings = value;
                }
                else
                {
                    ratings = "NR";
                }
            }
        }

    }
}
