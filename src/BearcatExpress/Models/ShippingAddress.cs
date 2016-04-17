using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace BearcatExpress.Models
{
    public class ShippingAddress
    {
        [Required]
        [Key]
        [ScaffoldColumn(false)]
        public int AddressId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name Field is Required")]
        public string senderName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country Field is Required")]
        public string senderCountry { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State Field is Required")]
        public string senderState { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City Field is Required")]
        public string senderCity { get; set; }

        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street Name is Required")]
        public string senderStreet { get; set; }

        [Display(Name = "Number")]
        [Required(ErrorMessage = "House Number is Required")]
        public string senderHouseNum { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Contact Number is Required ")]
        public string senderPhoneNum { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name Field is Required")]
        public string receiverName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country Field is Required")]
        public string receiverCountry { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State Field is Required")]
        public string receiverState { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City Field is Required")]
        public string receiverCity { get; set; }

        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "Street Name is Required")]
        public string receiverStreet { get; set; }

        [Display(Name = "House Number")]
        [Required(ErrorMessage = "House Number is Required")]
        public string receiverHouseNum { get; set; }

        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Contact Number is Required ")]
        public string receiverPhoneNum { get; set; }
    }
}
