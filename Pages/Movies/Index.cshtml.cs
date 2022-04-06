using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiMovieDatabase.Data;
using MiMovieDatabase.Models;

namespace MiMovieDatabase.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MiMovieDatabase.Data.MovieContext _context;

        public IndexModel(MiMovieDatabase.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
