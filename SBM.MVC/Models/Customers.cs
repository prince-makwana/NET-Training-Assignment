﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBM.MVC.Models
{
    public class Customers
    {
        public int CustomerId { get; set; } 
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is Required.")]
        public string CustomerName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is Required.")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "ZipCode is Required.")]
        public string ZipCode { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "City is Required.")]
        public string City { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Country is Required.")]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact Number is Required.")]
        public string ContactNo { get; set; }

        public string OtherNo { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Id is Required.")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [DataType(DataType.Text)]
        public string Note { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Enter atleast 8 characters.")]
        public string Password { get; set; }

        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        //public virtual Appointments Appointment { get; set; }
        //public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}