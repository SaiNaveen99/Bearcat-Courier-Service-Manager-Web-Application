using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace BearcatExpress.Models
{
    public class Shipping : ApplicationDbContext
    {
       public int shipmentID { get; set; }

        public int shipmentAddressID { get; set; }
       
    


    }
}
