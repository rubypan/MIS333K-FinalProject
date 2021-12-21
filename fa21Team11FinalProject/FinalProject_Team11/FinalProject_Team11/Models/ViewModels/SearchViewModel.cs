using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Team11.Models
{

    public enum SearchWeekend
    {
        [Display(Name = "Less than")] Lessthan,
        [Display(Name = "Greater than")] Greaterthan,
    }

    public enum SearchWeekday
    {
        [Display(Name = "Less than")] Lessthan,
        [Display(Name = "Greater than")] Greaterthan,
    }

    public enum SearchRating
    {
        [Display(Name = "Less than")] Lessthan,
        [Display(Name = "Greater than")] Greaterthan,
    }

    public class SearchViewModel
    {
        [Display(Name = "Search by city:")]
        public String? City { get; set; }

        [Display(Name = "Search by state:")]
        public String? State { get; set; }

        [Display(Name = "Search by guest ratings:")]
        [Range(minimum: 1.0, maximum: 5.0, ErrorMessage = "Ratings must be between 1.0 and 5.0")]
        public Decimal? Ratings { get; set; }

        [Display(Name = "Search by number of guest(s):")]
        public Int32? GuestNumber { get; set; }

        [Display(Name = "Search by weekend price:")]
        [Range(minimum: 0, maximum: Double.MaxValue, ErrorMessage = "Price must be at least zero")]
        public Decimal? WeekendPrice { get; set; }

        [Display(Name = "Search by weekday price:")]
        [Range(minimum: 0, maximum: Double.MaxValue, ErrorMessage = "Price must be at least zero")]
        public Decimal? WeekdayPrice { get; set; }

        [Display(Name = " ")]
        public SearchWeekend SearchWeekend { get; set; }

        [Display(Name = " ")]
        public SearchWeekday SearchWeekday { get; set; }

        [Display(Name = " ")]
        public SearchRating SearchRating { get; set; }

        [Display(Name = "Search by category:")]
        public int? CategoryID { get; set; }

        [Display(Name = "Search by number of bedroom(s):")]
        public Int32? BedroomNumber { get; set; }

        [Display(Name = "Search by number of bathroom(s):")]
        public Int32? BathroomNumber { get; set; }

        [Display(Name = "Pets Allowed?")]
        public Boolean Pet { get; set; }

        [Display(Name = "Free Parking?")]
        public Boolean FreeParking { get; set; }

        [Display(Name = "Check-in Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckinDate { get; set; }

        [Display(Name = "Check-out Date:")]
        [DataType(DataType.Date)]
        public DateTime? SelectedCheckoutDate { get; set; }



    }
}
