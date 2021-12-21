using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_Team11.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public IActionResult Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            //limit the list to only the order details that belong to this order
            List<Reservation> rds = _context.Reservations
                                          .Include(rd => rd.Property)
                                          .Where(rd => rd.Order.OrderID == orderID)
                                          .ToList();

            return View(rds);
        }

        //// GET: Reservations/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var reservation = await _context.Reservations
        //        .FirstOrDefaultAsync(m => m.ReservationID == id);
        //    if (reservation == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(reservation);
        //}

        // GET: Reservations/Create
        [Authorize(Roles = "Customer, Admin")]
        public IActionResult Create(Int32 propertyID)
        {
            Reservation reservation = new Reservation();

            reservation.Property = _context.Properties.Find(propertyID);
            reservation.Checkin_date = System.DateTime.Now;
            reservation.Checkout_date = System.DateTime.Now.AddDays(1);

            return View(reservation);
        }



        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer, Admin")]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            reservation.Property = _context.Properties.FirstOrDefault(p => p.PropertyID == reservation.Property.PropertyID);

            //see if available
            //search for dates
            var dateQuery = from r in _context.Reservations select r;


            dateQuery = dateQuery.Include(r => r.Property).Where(r => r.Checkin_date >= reservation.Checkout_date || r.Checkout_date <= reservation.Checkin_date);

            List<Reservation> reservations = dateQuery.ToList();
            if (reservations.Count != 0)
            {
                List<Reservation> unavailable = _context.Reservations.Include(r => r.Property).ToList().Except(reservations).ToList();  //all reservations that cause problems


                unavailable = unavailable.Where(r => r.Property.PropertyID == reservation.Property.PropertyID).ToList();
                if (unavailable.Count > 0)
                {
                    return View("Error", new string[] { "This property is not available for your dates." });
                }
            }



            Order order = _context.Orders.FirstOrDefault(o => o.User.UserName == User.Identity.Name && o.OrderStatus == OrderStatus.Pending);

            if (order == null)
            {
                order = new Order();
                order.OrderStatus = OrderStatus.Pending;
                order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);
                order.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                _context.Add(order);
                _context.SaveChanges();
            }

            reservation.Order = order;

            reservation.CleaningFee = Convert.ToDecimal(reservation.Property.CleaningFee);
            reservation.User_Email = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Email;

            ////calculate total fees
            ////calculate stay price
            //reservation.StayPrice = Convert.ToDecimal(reservation.WeekDaysCount * reservation.Property.WeekdayPrice + reservation.WeekendDaysCount * reservation.Property.WeekendPrice);//+ (reservation.Property.WeekendPrice * reservation.WeekendDaysCount);

            //calculate total fees
            //calculate stay price
            reservation.StayPrice = Convert.ToDecimal(reservation.WeekDaysCount * reservation.Property.WeekdayPrice + reservation.WeekendDaysCount * reservation.Property.WeekendPrice);//+ (reservation.Property.WeekendPrice * reservation.WeekendDaysCount);
            if ((reservation.Checkout_date - reservation.Checkin_date).Days - 1 >= reservation.Property.DiscountNights)
            {
                reservation.StayPrice *= (1 - reservation.Property.DiscountPercentage ?? 0);
                reservation.CleaningFee *= (1 - reservation.Property.DiscountPercentage ?? 0);
            }


            _context.Add(reservation);


            await _context.SaveChangesAsync();


            //TODO: Decide where to go next
            return RedirectToAction("Details", "Orders", new { id = reservation.Order.OrderID });

        }


        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //user did not specify a order detail to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order detail to edit!" });
            }

            //find the order detail
            Reservation reservation = await _context.Reservations
                                                   .Include(od => od.Property)
                                                   .Include(od => od.Order)
                                                   .FirstOrDefaultAsync(od => od.ReservationID == id);
            if (reservation == null)
            {
                return View("Error", new String[] { "This order detail was not found" });
            }
            return View(reservation);
        }



        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reservation reservation)
        {
            if (id != reservation.ReservationID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            //information is not valid, try again
            if (ModelState.IsValid == false)
            {
                return View(reservation);
            }

            //create a new order detail
            Reservation dbOD;
            //if code gets this far, update the record
            try
            {
                //find the existing order detail in the database
                //include both order and product
                dbOD = _context.Reservations
                      .Include(od => od.Property)
                      .Include(od => od.Order)
                      .FirstOrDefault(od => od.ReservationID == reservation.ReservationID);

                //update the scalar properties
                dbOD.Checkin_date = reservation.Checkin_date;
                dbOD.Checkout_date = reservation.Checkout_date;
                dbOD.StayPrice = Convert.ToDecimal(dbOD.WeekDaysCount * dbOD.Property.WeekdayPrice + dbOD.WeekendDaysCount * dbOD.Property.WeekendPrice);


                //save changes
                _context.Update(dbOD);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the order details index page
            return RedirectToAction("Details", "Orders", new { id = dbOD.Order.OrderID });

        }
    }

}
