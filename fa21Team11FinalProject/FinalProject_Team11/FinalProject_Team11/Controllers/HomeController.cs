using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

//TODO: Upddate this namespace to match your project name
namespace FinalProject_Team11.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        public ActionResult Index()
        {
            var query = from b in _context.Properties
                        select b;
            List<Property> SelectedProperties = query.Include(b => b.Category).Include(r => r.Reviews).ToList();
            //Populate the view bag with a count of all books
            ViewBag.AllProperties = _context.Properties.Count();

            //Populate the view bag with a count of selected books
            ViewBag.SelectedProperties = SelectedProperties.Count;
            return View(_context.Properties.ToList());

        }

        public IActionResult Details(int? id)//id is the id of the property you want to see
        {
            if (id == null) //PropertyID not specified
            {
                //user did not specify a PropertyID – take them to the error view
                return View("Error", new String[] { "PropertyID not specified - which property do you want to view?" });
            }
            //look up the property in the database based on the id; be sure to include the genre
            Property property = _context.Properties.Include(b => b.Category).Include(r => r.Reviews)
            .FirstOrDefault(b => b.PropertyID == id);

            if (property == null) //No property with this id exists in the database
            {
                //there is not a property with this id in the database – show the user an error view
                return View("Error", new String[] { "Property not found in database" });
            }
            //if code gets this far, all is well – display the details
            return View(property);
        }

        public ActionResult DetailedSearch()
        {
            //Populate view bag with
            ViewBag.AllCategories = GetAllCategories();
            SearchViewModel svm = new SearchViewModel();
            return View(svm);
        }

        public ActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //start the query
            var query = from b in _context.Properties select b;

            //search by city
            if (String.IsNullOrEmpty(svm.City) == false)

            {
                query = query.Where(b => b.PropertyCity == svm.City);
            }

            //search by state
            if (String.IsNullOrEmpty(svm.State) == false)
            {
                query = query.Where(b => b.PropertyState == svm.State);
            }

           

            //search by guest numbers
            if (svm.GuestNumber != null)
            {
                query = query.Where(b => b.PropertyGuest == svm.GuestNumber);
            }

            //search by price
            if (svm.WeekdayPrice != null)
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    ViewBag.AllCategories = GetAllCategories();
                    return View("DetailedSearch", svm);
                }
                else
                {
                    if (svm.SearchWeekday == SearchWeekday.Greaterthan)
                    {
                        query = query.Where(b => b.WeekdayPrice >= svm.WeekdayPrice);
                    }
                    else if (svm.SearchWeekday == SearchWeekday.Lessthan)
                    {
                        query = query.Where(b => b.WeekdayPrice <= svm.WeekdayPrice);
                    }
                }
            }

            if (svm.WeekendPrice != null)
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    ViewBag.AllCategories = GetAllCategories();
                    return View("DetailedSearch", svm);
                }
                else
                {
                    if (svm.SearchWeekend == SearchWeekend.Greaterthan)
                    {
                        query = query.Where(b => b.WeekendPrice >= svm.WeekendPrice);
                    }
                    else if (svm.SearchWeekend == SearchWeekend.Lessthan)
                    {
                        query = query.Where(b => b.WeekendPrice <= svm.WeekendPrice);
                    }
                }
            }



            //search by Category
            if (svm.CategoryID != 0)
            {
                query = query.Where(b => b.Category.CategoryID == svm.CategoryID);
            }

            //search by boolean
            if(svm.FreeParking == true)
            {
                query = query.Where(b => b.Parking == true);
            }

            if (svm.Pet == true)
            {
                query = query.Where(b => b.Pets == true);
            }

            //search by date
            //if (svm. SelectedCheckinDate!= null)
            //{
            //query = query.Where(b => b.>= svm.SelectedCheckinDate);

            //}


            List<Property> SelectedPropertyList = query.Include(b => b.Category).Include(r => r.Reviews).ToList();

            //search by ratings
            if (svm.Ratings != null)
            {
                if (ModelState.IsValid == false)
                {

                    ViewBag.AllCategories = GetAllCategories();
                    return View("DetailedSearch", svm);
                }

                else if (ModelState.IsValid == true)
                {
                    if (svm.SearchRating == SearchRating.Greaterthan)
                    {
                        SelectedPropertyList = SelectedPropertyList.Where(b => b.PropertyRating >= svm.Ratings).ToList();
                    }
                    else if (svm.SearchRating == SearchRating.Lessthan)
                    {
                        SelectedPropertyList = SelectedPropertyList.Where(b => b.PropertyRating <= svm.Ratings).ToList();
                    }
                }

            }

            //Populate the view bag with a count of all properties
            ViewBag.AllProperties = _context.Properties.Count();
            //Populate the view bag with a count of selected properties
            ViewBag.SelectedProperties = SelectedPropertyList.Count;

            return View("Index", SelectedPropertyList);
        }

        private SelectList GetAllCategories()
        {
            //Get the list of months from the database
            List<Category> categoryList = _context.Categories.ToList();

            //add a dummy entry so the user can select all categories
            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "All Categories" };
            categoryList.Add(SelectNone);

            //create the select list
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), nameof(Category.CategoryID), nameof(Category.CategoryName));

            //return the SelectList
            return categorySelectList;
        }

    }
}
