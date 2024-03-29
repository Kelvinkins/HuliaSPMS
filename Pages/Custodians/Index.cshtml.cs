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



namespace SkyLightWeb.Pages.Custodians
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Custodian> Custodian { get;set; }

        public async Task OnGetAsync()
        {
            Custodian = await _context.Custodians.Include(a=>a.Assets).ToListAsync();
        }
    }
}
