using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_Team11.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Middle Name:")]
        public String? MI { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name ="User Name:")]
        public String FullName
        {
            get { return FirstName + " " + MI + " " +LastName; }
        }

      
        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Zip Code is required.")]
        [Display(Name = "Zip Code")]
        public String ZipCode { get; set; }

        //TO DO: birthday should be at least 18 years old
        //On controller
        [Required(ErrorMessage = "Birthday is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Birthday { get; set; }

        //[Display(Name = "Is active or not?")]
        public bool Is_Active { get; set; }

        //Navigational properties
        public List<Property> Properties { get; set; }

        public List<Order> Orders { get; set; }

        public List<Review> Reviews { get; set; }

        //add reviews relationship
        public AppUser()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }

            if (Orders == null)
            {
                Orders = new List<Order>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }


    }
}
