using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using FinalProject_Team11.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject_Team11.Controllers
{
    [Authorize(Roles = "Host")]
    public class PropertiesController : Controller
    {
        private readonly AppDbContext _context;

        public PropertiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .ToListAsync());
        }

        // GET: Properties/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            //id was not specified - show the user an error
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a Property to view!" });
            }

            //find the Property in the database
            //be sure to include the relevant navigational data
            Property Property = await _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(p => p.PropertyID == id);

            //Property was not found in the database
            if (Property == null)
            {
                return View("Error", new String[] { "That Property was not found in the database." });
            }

            return View(Property);
        }

        // GET: Properties/Create
        [Authorize(Roles = "Host")]
        public IActionResult Create()
        {
            ViewBag.AllCategories = GetAllCategories();
            return View();
        }


        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Create([Bind("PropertyID, PropertyAddress, PropertyBathroom, PropertyBedroom, PropertyCity, PropertyGuest, PropertyState, PropertyZip, WeekdayPrice, WeekendPrice, CleaningFee, DiscountNights, DiscountPercentage")] Property property, int SelectedCategory, string NewCategory)
        {
            //This code has been modified so that if the model state is not valid
            //we immediately go to the "sad path" and give the user a chance to try again

            if (ModelState.IsValid == false)
            {
                ViewBag.AllCategories = GetAllCategories();
                return View(property);
            }

            //property.PropertyID = Utilities.GeneratePropertyID.GetNextPropertyID(_context);
            _context.Add(property);
            _context.SaveChanges();

            if (SelectedCategory == 0)
            {
                Category newcategory = new Category();
                newcategory.CategoryName = NewCategory;
                _context.Add(newcategory);
                _context.SaveChanges();


                Category dbCategory = _context.Categories.Include(c => c.Properties).FirstOrDefault(c => c.CategoryID == newcategory.CategoryID);
                Property dbProperty = _context.Properties.Include(c => c.Category).FirstOrDefault(c => c.PropertyID == property.PropertyID);
                dbCategory.Properties.Add(dbProperty);
                dbProperty.Category = dbCategory;
                //lets user pick Category the Property belongs to, then add the category to the property instance and the property instance to the category                    _context.Add(newcategory);
                _context.Update(dbCategory);
                _context.Update(dbProperty);
                _context.SaveChanges();
            }
            else
            {
                Category dbCategory = _context.Categories.Include(c => c.Properties).FirstOrDefault(c => c.CategoryID == SelectedCategory);
                Property dbProperty = _context.Properties.Include(c => c.Category).FirstOrDefault(c => c.PropertyID == property.PropertyID);
                dbCategory.Properties.Add(dbProperty);
                //lets user pick category the property belongs to, then add the category to the property instance and the property instance to the category
                _context.Update(dbCategory);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
            //go back to the Create view to try again

        }

        // GET: Properties/Edit/5
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> Edit(int? id)
        {
            //if the user didn't specify a Property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a Property to edit!" });
            }

            //find the Property in the database
            //be sure to include the relevant navigational data
            Property property = await _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .FirstOrDefaultAsync(p => p.PropertyID == id);

            //if the Property does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This Property was not found!" });
            }
            ViewBag.AllCategories = GetAllCategories(property);
            return View(property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Host")]
        public IActionResult Edit(int id, [Bind("PropertyID, PropertyAddress, PropertyBathroom, PropertyBedroom, PropertyCity, PropertyGuest, PropertyState, PropertyZip, WeekdayPrice, WeekendPrice, CleaningFee, DiscountNights, DiscountPercentage")] Property property, int[] SelectedCategories)
        {
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllCategories = GetAllCategories(property);
                return View(property);
            }
            try
            {
                Property dbProperty = _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .FirstOrDefault(p => p.PropertyID == id);

                dbProperty.WeekdayPrice = property.WeekdayPrice;
                dbProperty.WeekendPrice = property.WeekendPrice;
                dbProperty.CleaningFee = property.CleaningFee;
                dbProperty.DiscountNights = property.DiscountNights;
                dbProperty.DiscountPercentage = property.DiscountPercentage;

                _context.Properties.Update(dbProperty);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this product.", ex.Message });
            }
            return RedirectToAction(nameof(Index));
        }

        //if (ModelState.IsValid)
        //{
        //    try
        //    {
        //        Property dbProperty = _context.Properties.Find(property.PropertyID);

        //        dbProperty.WeekdayPrice = property.WeekdayPrice;
        //        dbProperty.WeekendPrice = property.WeekendPrice;
        //        dbProperty.CleaningFee = property.CleaningFee;

        //        _context.Properties.Update(dbProperty);
        //        _context.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PropertyExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToAction(nameof(Index));
        //}
        //return View(property);
        // GET: Properties/EditStatus/5
        [Authorize(Roles = "Host")]
        public async Task<IActionResult> EditStatus(int? id)
        {
            //if the user didn't specify a Property id, we can't show them 
            //the data, so show an error instead
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a Property to edit!" });
            }

            //find the Property in the database
            //be sure to include the relevant navigational data
            Property property = await _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .FirstOrDefaultAsync(p => p.PropertyID == id);

            //if the Property does not exist in the database, then show the user
            //an error message
            if (property == null)
            {
                return View("Error", new string[] { "This Property was not found!" });
            }
            ViewBag.AllCategories = GetAllCategories(property);
            return View(property);
        }

        // POST: Properties/EditStatus/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Host")]
        public IActionResult EditStatus(int id, [Bind("PropertyID, PropertyStatus, PropertyAddress, PropertyBathroom, PropertyBedroom, PropertyCity, PropertyGuest, PropertyState, PropertyZip, WeekdayPrice, WeekendPrice, CleaningFee, DiscountNights, DiscountPercentage")] Property property, int[] SelectedCategories)
        {
            if (id != property.PropertyID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllCategories = GetAllCategories(property);
                return View(property);
            }
            try
            {
                Property dbProperty = _context.Properties
                .Include(p => p.Category)
                .Include(r => r.Reviews)
                .FirstOrDefault(p => p.PropertyID == id);

                dbProperty.PropertyStatus = property.PropertyStatus;

                _context.Properties.Update(dbProperty);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this property.", ex.Message });
            }
            return RedirectToAction(nameof(Index));
        }
        private bool PropertyExists(int id)
        {
            return _context.Properties.Any(e => e.PropertyID == id);
        }

        private SelectList GetAllCategories()
        {
            List<Category> allCategories = _context.Categories.ToList();

            Category NewCategory = new Category() { CategoryID = 0, CategoryName = "New Category" };
            allCategories.Add(NewCategory);

            SelectList CategoryList = new SelectList(allCategories.OrderBy(c => c.CategoryID), "CategoryID", "CategoryName");
            return CategoryList;
        }

        private SelectList GetAllCategories(Property propery)
        {
            //create a list of all the categories
            List<Category> allCategories = _context.Categories.ToList();

            //create the multiselect with the overload for currently selected categories
            SelectList CategoryList = new SelectList(allCategories, "CategoryID", "CategoryName", propery.Category.CategoryID);

            //return the list
            return CategoryList;
        }
    }
}
