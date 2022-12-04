using System;
using System.Collections.Generic;

namespace web.Models
{

    public class Movie {

        public int ID { get; set; }

        public string Name { get; set; }

        public int Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Mark { get; set; }

    }
    
}