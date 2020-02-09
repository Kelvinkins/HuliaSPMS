﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SkyLightWeb.Models;
using SkyLightWeb.Data;
using Microsoft.AspNetCore.Authorization;

namespace SkyLightWeb.Pages.Assets
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Asset Asset { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Assets.FirstOrDefaultAsync(m => m.AssetID == id);

            if (Asset == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Asset = await _context.Assets.FindAsync(id);

            if (Asset != null)
            {
                _context.Assets.Remove(Asset);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
