using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel;
namespace SkyLightWeb.Models
{
    public class Custodian
    {
        public string CustodianID{get;set;} 
        public string CustodianName{get;set;}
        public string Description{get;set;}
        public DateTime DateAdded{get;set;}
        public string CustodianType{get;set;}
        public List<Asset> Assets { get; set; }
         public bool Discontinued{get;set;}
        
    }
}