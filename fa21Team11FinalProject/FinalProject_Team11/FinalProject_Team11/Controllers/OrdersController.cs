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
using FinalProject_Team11.Utilities;

namespace FinalProject_Team11.Controllers
{
    //only logged-in users can access orders
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public IActionResult Index()
        {
            //Set up a list of orders to display
            List<Order> orders;
            if (User.IsInRole("Host, Admin"))
            {
                orders = _context.Orders
                         .Include(o => o.Reservations)
                         .ToList();
            }
            else //user is a customer, so only display their records
            {
                orders = _context.Orders
                         .Include(o => o.Reservations)
                         .Where(o => o.User.UserName == User.Identity.Name)
                         .ToList();
            }

            return View(orders);
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //the user did not specify an order to view
            if (id == null)
            {
                return View("Error", new String[] { "Please specify an order to view!" });
            }

            //find the order in the database
            Order order = await _context.Orders
                                .Include(o => o.Reservations)
                                .ThenInclude(o => o.Property)
                                .Include(o => o.User)
                                .FirstOrDefaultAsync(m => m.OrderID == id);

            //order was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            //make sure this order belongs to this user
            if (User.IsInRole("Customer") && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!  Don't be such a snoop!" });
            }

            // Send the user to the details page
            return View(order);
        }

        // GET: Orders/Create
        //only customers and admins can create orders
        [Authorize(Roles = "Customer, Admins")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer,Admins")]
        public async Task<IActionResult> Create([Bind("OrderNotes")] Order order)
        {
            // Find the next order number from the utilities class
            order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

            //Set the date of this order
            order.OrderDate = DateTime.Now;

            //Associate the order with the logged-in customer
            order.User = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            //make sure all properties are valid
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, add the registration to the database
            _context.Add(order);
            await _context.SaveChangesAsync();

            //send the user on to the action that will allow them to 
            //create a registration detail.  Be sure to pass along the RegistrationID
            //that you created when you added the registration to the database above
            return RedirectToAction("Create", "Reservations", new { orderID = order.OrderID });
        }

        // GET: Orders/Edit/5
        public IActionResult Edit(int? id)
        {
            //user did not specify an order to edit
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a registration to edit" });
            }

            //find the order in the database, and be sure to include details
            Order order = _context.Orders
                         .Include(o => o.Reservations)
                         .ThenInclude(o => o.Property)
                         .Include(o => o.User)
                         .FirstOrDefault(m => m.OrderID == id);
            

            //registration was not found in the database
            if (order == null)
            {
                return View("Error", new String[] { "This registration was not found in the database!" });
            }

            //registration does not belong to this user
            if (User.IsInRole("Customer") && order.User.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this registration!" });
            }

            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderNumber,OrderDate,OrderNotes")] Order order)
        {
            if (id != order.OrderID)
            {
                return View("Error", new String[] { "There was a problem editing this order. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(order);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Order dbOrder = _context.Orders.Find(order.OrderID);

                //update the notes
                dbOrder.OrderNotes = order.OrderNotes;

                _context.Update(dbOrder);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this order!", ex.Message });
            }

            //send the user to the Orders Index page.
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Confirm(int orderID)

        {
            Order dbOrder = _context.Orders.Include(o => o.User).FirstOrDefault(o => o.OrderID == orderID);

            //TODO：generate confirmation number
            dbOrder.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

            //TODO：set to completed
            dbOrder.OrderStatus = OrderStatus.Complete;
            _context.Update(dbOrder);
            _context.SaveChanges();

            //TODO: send email

            String toEmailAddress = dbOrder.User.Email;
            String emailSubject = "Your Order Confirmation";
            String emailBody = "We are pleased to inform you that your order has been placed!";

            Utilities.EmailMessaging.SendEmail(toEmailAddress, emailSubject, emailBody);
            return View(dbOrder);
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }
    }

   
}
