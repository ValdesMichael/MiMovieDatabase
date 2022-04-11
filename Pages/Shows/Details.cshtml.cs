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
    public class DetailsModel : PageModel
    {
        private readonly MiMovieDatabase.Data.ShowContext _context;

        public DetailsModel(MiMovieDatabase.Data.ShowContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Show = await _context.Shows.FirstOrDefaultAsync(m => m.ID == id);

            if (Show == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
