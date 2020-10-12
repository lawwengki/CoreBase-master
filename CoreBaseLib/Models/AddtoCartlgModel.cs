using Npgsql.TypeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text;
using System.Xml;

namespace CoreBaseLib.Models
{
    public class AddtoCartlgModel
    {
        [Required] 
        public long eventid { get; set; }
        [Required]
        public long productid { get; set; }
         public int quantity { get; set; }

        [Required]
        public string currency { get; set; }
        public decimal totalvalue { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public string postcode { get; set; }
        public string userIPaddress { get; set; }
        public string browseruseragent { get; set; }
        public string clickid { get; set; }
        public string browserid { get; set; }
        public string facebookloginid { get; set; }
        public DateTime createtimestamp { get; set; }

    }
}
