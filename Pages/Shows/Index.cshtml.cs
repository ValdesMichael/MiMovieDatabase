using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiMovieDatabase.Data;
using MiMovieDatabase.Models;

namespace MiMovieDatabase.Pages.Shows
{
    public class IndexModel : PageModel
    {
        private readonly MiMovieDatabase.Data.ShowContext _context;

        public IndexModel(MiMovieDatabase.Data.ShowContext context)
        {
            _context = context;
        }

        public IList<Show> Show { get;set; }

        public async Task OnGetAsync()
        {
            Show = await _context.Shows.ToListAsync();
        }
    }
}
