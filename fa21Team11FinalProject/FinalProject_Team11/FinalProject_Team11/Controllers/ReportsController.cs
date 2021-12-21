using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

//TODO: Change this using statement to match your project
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using FinalProject_Team11.Utilities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Team11.Controllers
{
    public enum DateSort { Before, After };

    public class ReportsController : Controller
    {
        private AppDbContext _db;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public ReportsController(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /////////// Host Report
        // GET: /<controller>/
        [Authorize(Roles = "Host")]
        public IActionResult Index()
        {
            String id = User.Identity.Name;
            AppUser user = _db.Users.FirstOrDefault(u => u.UserName == id);

            var query = from b in _db.Properties
                        select b;
            List<Property> SelectedProperties = query.Include(b => b.Category).Include(r => r.Reviews)
                .Where(r => r.User.Id == user.Id).ToList();
            //Populate the view bag with a count of all books
            ViewBag.AllProperties = _db.Properties.Count();

            //Populate the view bag with a count of selected books
            ViewBag.SelectedProperties = SelectedProperties.Count;
            return View(SelectedProperties);
        }

        [Authorize(Roles = "Host")]
        public async Task<IActionResult> HostReport(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Property to view!" });
            }

            Property property = await _db.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(p => p.PropertyID == id);

            if (property == null)
            {
                return View("Error", new String[] { "That Property was not found in the database." });
            }

            List<Reservation> SelectedReservations = new List<Reservation>();
            var rquery = from o in _db.Reservations select o;
            rquery = rquery.Include(o => o.Property)
                .Where(o => o.Property == property).Where(o => o.Property.PropertyID == id);
            SelectedReservations = rquery.ToList();

            //List<Order> allOrders = new List<Order>();
            //var oquery = from o in _db.Orders select o;
            //oquery = oquery.Include(o => o.Reservations).ThenInclude(o => o.Property);
            //allOrders = oquery.ToList();

            decimal TotalStayRevenue = 0;
            decimal TotalCleaningFees = 0;
            decimal TotalCombinedRevenue = 0;
            decimal stayrevenuepercent = 0.9m;
            int TotalCompletedReservations = 0;

            foreach (Reservation r in SelectedReservations)
            {
                if (r.Property.PropertyID == property.PropertyID)
                {
                    TotalCompletedReservations += 1;
                    TotalStayRevenue += stayrevenuepercent * r.StayPrice;
                    TotalCleaningFees += r.CleaningFee;
                    TotalCombinedRevenue += TotalStayRevenue + TotalCleaningFees;
                }
            }

            AllPropertiesReportViewModel prvm = new AllPropertiesReportViewModel();

            prvm.TotalStayRevenue = TotalStayRevenue;
            prvm.TotalCleaningFees = TotalCleaningFees;
            prvm.TotalCombinedRevenue = TotalCombinedRevenue;
            prvm.TotalCompletedReservations = TotalCompletedReservations;

            return View(prvm);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminReport()
        {
            List<Reservation> SelectedReservations = new List<Reservation>();
            var rquery = from o in _db.Reservations select o;
            rquery = rquery.Include(o => o.Property);
            SelectedReservations = rquery.ToList();

            //List<Order> allOrders = new List<Order>();
            //var oquery = from o in _db.Orders select o;
            //oquery = oquery.Include(o => o.Reservations).ThenInclude(o => o.Property);
            //allOrders = oquery.ToList();

            decimal TotalCommissionEarned = 0;
            int TotalReservationNumber = 0;
            decimal AvgCommissionPerReservation = 0;
            decimal CommissionPercent = 0.1m;
            int TotalPropertiesNumber = 0;

            foreach (Reservation r in SelectedReservations)
            {
                TotalCommissionEarned += CommissionPercent * r.StayPrice;
                TotalReservationNumber += 1;
            }
            AvgCommissionPerReservation = TotalCommissionEarned / TotalReservationNumber;
            TotalPropertiesNumber = 183;

            AdminReportViewModel arvp = new AdminReportViewModel();

            arvp.TotalCommissionEarned = TotalCommissionEarned;
            arvp.TotalReservationNumber = TotalReservationNumber;
            arvp.AvgCommissionPerReservation = AvgCommissionPerReservation;
            arvp.TotalPropertiesNumber = TotalPropertiesNumber;

            return View(arvp);
        }


        /////////// Host Report Search
        //
        public ActionResult SortReport()
        {
            //Populate view bag with
            SearchReportViewModel srvm = new SearchReportViewModel();
            return View(srvm);
        }

        public ActionResult DisplaySearchReportResults(SearchReportViewModel srvm)
        {
            List<AllPropertiesReportViewModel> allReports = new List<AllPropertiesReportViewModel>();

            //start the query
            var query = from r in allReports select r;

            //search by price
            if (srvm.TotalStayRevenue != null)
            {
                TryValidateModel(srvm);
                if (ModelState.IsValid == false)
                {
                    return View("DetailedSearch", srvm);
                }
                else
                {
                    if (srvm.SearchStayRevenue == SearchButtom.Greaterthan)
                    {
                        query = query.Where(r => r.TotalStayRevenue >= srvm.TotalStayRevenue);
                    }
                    else if (srvm.SearchStayRevenue == SearchButtom.Lessthan)
                    {
                        query = query.Where(r => r.TotalStayRevenue <= srvm.TotalStayRevenue);
                    }
                }
            }

            if (srvm.TotalCleaningFees != null)
            {
                TryValidateModel(srvm);
                if (ModelState.IsValid == false)
                {
                    return View("DetailedSearch", srvm);
                }
                else
                {
                    if (srvm.SearchCleaningFees == SearchButtom.Greaterthan)
                    {
                        query = query.Where(r => r.TotalCleaningFees >= srvm.TotalCleaningFees);
                    }
                    else if (srvm.SearchCleaningFees == SearchButtom.Lessthan)
                    {
                        query = query.Where(r => r.TotalCleaningFees <= srvm.TotalCleaningFees);
                    }
                }
            }

            if (srvm.TotalCombinedRevenue != null)
            {
                TryValidateModel(srvm);
                if (ModelState.IsValid == false)
                {
                    return View("DetailedSearch", srvm);
                }
                else
                {
                    if (srvm.SearchCombinedRevenue == SearchButtom.Greaterthan)
                    {
                        query = query.Where(r => r.TotalCombinedRevenue >= srvm.TotalCombinedRevenue);
                    }
                    else if (srvm.SearchCombinedRevenue == SearchButtom.Lessthan)
                    {
                        query = query.Where(r => r.TotalCombinedRevenue <= srvm.TotalCombinedRevenue);
                    }
                }
            }

            if (srvm.TotalCompletedReservations != null)
            {
                TryValidateModel(srvm);
                if (ModelState.IsValid == false)
                {
                    return View("DetailedSearch", srvm);
                }
                else
                {
                    if (srvm.SearchCompletedReservations == SearchButtom.Greaterthan)
                    {
                        query = query.Where(r => r.TotalCompletedReservations >= srvm.TotalCompletedReservations);
                    }
                    else if (srvm.SearchCompletedReservations == SearchButtom.Lessthan)
                    {
                        query = query.Where(r => r.TotalCompletedReservations <= srvm.TotalCompletedReservations);
                    }
                }
            }

            List<AllPropertiesReportViewModel> SelectedPropertyList = query.ToList();

            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _db.Properties.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedPropertyList.Count;

            return View("Index", SelectedPropertyList);
        }
    }
}