﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Pages.Joueurs
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication.Models.WebApplicationContext _context;

        public DetailsModel(WebApplication.Models.WebApplicationContext context)
        {
            _context = context;
        }

        public Joueur Joueur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Joueur = await _context.Joueur.FirstOrDefaultAsync(m => m.ID == id);

            if (Joueur == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
