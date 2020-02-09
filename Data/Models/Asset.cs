using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel;
namespace SkyLightWeb.Models
{
    public class Asset
    {
        //Demographics
        [Display(Name = "Serial No")]
        public string AssetID { get; set; }
        [Display(Name = "Asset Name")]
        public string AssetName { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description{get;set;}
        public string GpsProtocol{get;set;}
        //Contact Info
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
   

        public bool Discontinued { get; set; }
        public DateTime DateDiscontinued { get; set; }
        public string MarkedBy { get; set; }
        public bool Deleted { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Reason { get; set; }
        public string DeletedBy { get; set; }
        public string EquipmentID { get; set; }
        public Equipment Equipment { get; set; }
        public string CustodianID { get; set; }
        public Custodian Custodian{get;set;}
    }
}