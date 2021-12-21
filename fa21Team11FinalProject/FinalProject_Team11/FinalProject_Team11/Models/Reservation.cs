using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace FinalProject_Team11.Models
{
    public class Reservation
    {
        private const Decimal TAX_RATE = 0.10m;

        public Int32 ReservationID { get; set; }

        [Display(Name = "Reservation Email:")]
        [Required(ErrorMessage = "The email is required!")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String User_Email { get; set; }

        [Required(ErrorMessage = "Check-in date is required!")]
        [Display(Name = "Check-in Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Checkin_date { get; set; }

        [Required(ErrorMessage = "Check-out date is required!")]
        [Display(Name = "Check-out Date:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM d, yyyy}")]
        public DateTime Checkout_date { get; set; }



        public List<DateTime> AllDates
        {
            get
            {
                var dates = new List<DateTime>();

                for (var dt = Checkin_date; dt < Checkout_date; dt = dt.AddDays(1))
                {
                    dates.Add(dt);
                }

                return dates;
            }
        }

        public Int32? WeekDaysCount
        {
            get
            {
                var mondays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Monday).Count();
                var tuesdays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Tuesday).Count();
                var wednesdays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Wednesday).Count();
                var thursdays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Thursday).Count();
                var sundays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Sunday).Count();
                return mondays + tuesdays + wednesdays + thursdays + sundays;
            }
        }

        public Int32? WeekendDaysCount
        {
            get
            {
                var saturdays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Saturday).Count();
                var fridays = AllDates.Where(d => d.DayOfWeek == DayOfWeek.Friday).Count();
                return saturdays + fridays;
            }
        }

        [Display(Name = "Cleaning Fee:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CleaningFee { get; set; }

        [Display(Name = "Stay Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal StayPrice { get; set; }

        [Display(Name = "Subtotal Fee:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal
        {
            get { return CleaningFee + StayPrice; }
        }

        [Display(Name = "Tax Amount:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TaxAmount
        {
            get { return Subtotal * TAX_RATE; }
        }

        [Display(Name = "Total Fee:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalFee
        {
            get { return Subtotal + TaxAmount; }
        }



        //navigational properties
        public Order Order { get; set; }

        public Property Property { get; set; }


    }
}