using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SkyLightWeb.Data;
using SkyLightWeb.Models;
using Microsoft.AspNetCore.Authorization;

namespace SkyLightWeb.Pages.Transactions {
    [Authorize]
    public class CreateModel : PageModel {
        private readonly ApplicationDbContext _context;

        private IEquipmentService equipmentService=new EquipmentService();
        // public CreateModel (IEquipmentService equipmentService) => this.equipmentService = equipmentService;
        [BindProperty (SupportsGet = true)]
        public string EquipmentID { get; set; }
        public string AssetID { get; set; }
        public SelectList Equipments { get; set; }
        public CreateModel (ApplicationDbContext context) {
            _context = context;
            // this.equipmentService = equipmentService;
        }

        // public IActionResult OnGet () {
        //     return Page ();
        // }
        public void OnGet () {
            Equipments = new SelectList (equipmentService.GetEquipments(_context), nameof (Equipment.EquipmentID), nameof (Equipment.EquipmentName));
        }
        public JsonResult OnGetAssets () {
            return new JsonResult (equipmentService.GetAssets (_context,EquipmentID));
        }

        [BindProperty]
        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnPostAsync () {
            if (!ModelState.IsValid) {
                return Page ();
            }
            Transaction.TransactionDate = DateTime.Now;
            _context.Transactions.Add (Transaction);
            await _context.SaveChangesAsync ();

            return RedirectToPage ("./Index");
        }
    }
}