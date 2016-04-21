using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BearcatExpress.Models
{
    public class Offer
    {
        [ScaffoldColumn(false)]
        public int OfferID { get; set; }

        [Required]
        [Display(Name = "Offer Name")]
        public string OfferName { get; set; }

        [Required]
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [Display(Name = "Discount")]
        [Range(typeof(decimal), "0", "100")]
        public decimal PriceReduced { get; set; }


    }
}
