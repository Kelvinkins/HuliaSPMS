using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel;
namespace SkyLightWeb.Models
{
    public class Equipment
    {
        public string EquipmentID{get;set;} 
        public string EquipmentName{get;set;}
        public string Description{get;set;}
        public DateTime DateAdded{get;set;}
        public string EquipmentType{get;set;}
        public List<Asset> Assets { get; set; }
        [Display(Name = "Inventory?")]
        public bool TrackInventory { get; set; }
         public bool Discontinued{get;set;}
        public List<TransactionDetail> TransactionDetails { get; set; }
        public int ReOrderLimit{get;set;}

                 
    }
}