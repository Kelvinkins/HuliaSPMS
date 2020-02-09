using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkyLightWeb.Data;
using SkyLightWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace SkyLightWeb.Pages
{
        [Authorize]
    public class IndexModel : PageModel
    {
      private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Asset> Asset { get;set; }
        public int EquipmentCount{get;set;}
        public int AssetCount{get;set;}
        public int CustodianCount{get;set;}
        public int TransactionCount{get;set;}

        public async Task OnGetAsync()
        {
            Asset = await _context.Assets.ToListAsync();
            EquipmentCount= _context.Equipments.Count();
             AssetCount=_context.Assets.Count();
             CustodianCount=_context.Custodians.Count();
             TransactionCount=_context.Transactions.Count();

        }
    }
}
