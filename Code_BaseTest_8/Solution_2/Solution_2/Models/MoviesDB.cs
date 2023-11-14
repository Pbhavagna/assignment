using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Solution_2.Models
{
    public class MoviesDB : DbContext
    {
        public MoviesDB() : base("MoviesDB")

        {

        }
        public DbSet<Movies> Movie { get; set; }

    }
}