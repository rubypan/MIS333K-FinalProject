using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_Team11.Models
{
    public enum OrderStatus { Pending, Complete, Cancelled }
    public class Order
    {
        private const Decimal TAX_RATE = 0.10m;

        public Int32 OrderID { get; set; }

        [Display(Name = "Order Number:")]
        public Int32 OrderNumber { get; set; }

        [Display(Name = "Order Date:")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Display(Name = "Order Notes:")]
        public String OrderNotes { get; set; }

        [Display(Name = "Cleaning Fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal CleaningFee
        {
            get { return Reservations.Sum(rd => rd.CleaningFee); }
        }

        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return Reservations.Sum(rd => rd.Subtotal); }
        }

        [Display(Name = "Tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Tax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }
        [Display(Name ="Order Status")]
        public OrderStatus OrderStatus { get; set; }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + Tax; }
        }

        // TODO: read-only properties for SearchReport for Host
        [Display(Name = "Total Cleaning Fees Collected")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalCleaning { get; set; }

        [Display(Name = "Total Stay Revenue")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalStayRevenue { get; set; }

        [Display(Name = "Total Revenue Combined")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TotalRevenue
        {
            get { return TotalCleaning + TotalStayRevenue; }
        }

        [Display(Name = "Total Completed Number of Reservations")]
        public Int32 TotalCompleted { get; set; }

        //Navigational Properties
        public AppUser User { get; set; }

        public List<Reservation> Reservations { get; set; }



        public Order()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
        }
    }
}