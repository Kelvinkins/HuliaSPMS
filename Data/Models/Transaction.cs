using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace SkyLightWeb.Models {
   
    public class Transaction {
        public string TransactionID { get; set; }
        public string TransactionName { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public List<Asset> Assets { get; set; }
        public bool Discontinued { get; set; }
        public List<TransactionDetail> TransactionDetails { get; set; }

    }

    public class TransactionDetail {
        public string TransactionDetailID { get; set; }
        public string TransactionID { get; set; }
        public Transaction Transaction { get; set; }

        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }

        public string AssetID { get; set; }
        public Asset Asset { get; set; }

    }
}