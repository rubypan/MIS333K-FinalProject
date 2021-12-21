using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FinalProject_Team11.Models
{
    public enum SearchButtom
    {
        [Display(Name = "Less than")] Lessthan,
        [Display(Name = "Greater than")] Greaterthan,
    }

    public class AllPropertiesReportViewModel
    {
        public String Address { get; set; }

        public String State { get; set; }

        public String City { get; set; }

        [Display(Name = "Total stay revenue:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalStayRevenue { get; set; }

        [Display(Name = "Total cleaning fees collected:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCleaningFees { get; set; }

        [Display(Name = "Total stay revenue and cleaning fees combined:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCombinedRevenue { get; set; }

        [Display(Name = "Total completed reservations:")]
        public Int32 TotalCompletedReservations { get; set; }

        public IEnumerable<AppUser> Customers { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Reservation> Reservations { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class SearchReportViewModel
    {
        [Display(Name = "Search by stay revenue:")]
        [Range(minimum: 0, maximum: Double.MaxValue, ErrorMessage = "Price must be at least zero")]
        public Decimal? TotalStayRevenue { get; set; }

        [Display(Name = "Search by cleaning fees collected:")]
        [Range(minimum: 0, maximum: Double.MaxValue, ErrorMessage = "Price must be at least zero")]
        public Decimal? TotalCleaningFees { get; set; }

        [Display(Name = "Search by stay revenue and cleaning fees combined:")]
        [Range(minimum: 0, maximum: Double.MaxValue, ErrorMessage = "Price must be at least zero")]
        public Decimal? TotalCombinedRevenue { get; set; }

        [Display(Name = "Search by completed reservations:")]
        public Int32? TotalCompletedReservations { get; set; }

        [Display(Name = " ")]
        public SearchButtom SearchStayRevenue { get; set; }

        [Display(Name = " ")]
        public SearchButtom SearchCleaningFees { get; set; }

        [Display(Name = " ")]
        public SearchButtom SearchCombinedRevenue { get; set; }

        [Display(Name = " ")]
        public SearchButtom SearchCompletedReservations { get; set; }
    }

    public class AdminReportViewModel
    {
        [Display(Name = "Total commission BevoBnB earned:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCommissionEarned { get; set; }

        [Display(Name = "Total number of reservations")]
        public Int32 TotalReservationNumber { get; set; }

        [Display(Name = "Average commission per reservation:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal AvgCommissionPerReservation { get; set; }

        [Display(Name = "Total number of properties:")]
        public Int32 TotalPropertiesNumber { get; set; }
    }
}