using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_Team11.Models
{
    public enum PropertyStatus { Activated, Pending, Deactivated }

    public class Property
    {
        //primary key
        public Int32 PropertyID { get; set; }

        //navigational properties
        [Display(Name = "Property Status:")]
        public PropertyStatus PropertyStatus { get; set; }

        [Display(Name = "Address:")]
        public String? PropertyAddress { get; set; }

        [Display(Name = "State:")]
        public String? PropertyState { get; set; }

        [Display(Name = "City:")]
        public String? PropertyCity { get; set; }

        [Display(Name = "Zip Code:")]
        public String? PropertyZip { get; set; }

        [Display(Name = "Weekday Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal? WeekdayPrice { get; set; }

        [Display(Name = "Weekend Price:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal? WeekendPrice { get; set; }

        [Display(Name = "Number of Bedrooms:")]
        public Int32? PropertyBedroom { get; set; }

        [Display(Name = "Number of Bathrooms:")]
        public Int32? PropertyBathroom { get; set; }

        [Display(Name = "Pets Allowed?")]
        public bool Pets { get; set; }

        [Display(Name = "Parking Free?")]
        public bool Parking { get; set; }

        [Display(Name = "Cleaning Fee:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal? CleaningFee { get; set; }

        [Display(Name = "Guest Limit:")]
        public Int32? PropertyGuest { get; set; }

        [Display(Name = "Discount Percentage:")]
        [DisplayFormat(DataFormatString = "{0:P}")]
        public Decimal? DiscountPercentage { get; set; }

        [Display(Name = "Minimum number of nights for discounts:")]
        public Int32? DiscountNights { get; set; }


        [DisplayFormat(DataFormatString = "{0:n1}")]
        public Decimal? PropertyRating
        {
            //avg function
            get 
            {
                if (Reviews.Count() == 0)
                {
                    return 0.0m;
                }
                else
                {
                    Decimal avgrat = (decimal)Reviews.Average(m => m.rating);
                    avgrat = Math.Round(avgrat, 1);
                    return avgrat;
                }
                
            }
        }

        //Navigational Properties
        public AppUser User { get; set; }
        public Category Category { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Review> Reviews { get; set; }

        public Property()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }
    }
}