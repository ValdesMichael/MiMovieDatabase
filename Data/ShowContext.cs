using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiMovieDatabase.Models;

namespace MiMovieDatabase.Data
{
    public class ShowContext : DbContext
    {
        public ShowContext (DbContextOptions<ShowContext> options)
            : base(options)
        {
        }

        public DbSet<Show> Shows { get; set; }
        //public DbSet<MiMovieDatabase.Models.Show> Show { get; set; }
    }
}
