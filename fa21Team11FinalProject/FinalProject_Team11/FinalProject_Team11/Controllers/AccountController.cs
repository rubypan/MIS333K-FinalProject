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

//TODO: Change this namespace to match your project
namespace FinalProject_Team11.Controllers
{
    public enum UserStatusEnum { Active, Inactive }

    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            if (rvm.Birthday.AddYears(18) > System.DateTime.Now) //not 18 years old
            {
                ModelState.AddModelError("Age Error", "You must be at least 18 to register!");
            }

            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //TODO: Add the rest of the custom user fields here
                //FirstName is included as an example
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                Address = rvm.Address,
                Birthday = rvm.Birthday,
                ZipCode = rvm.ZipCode,
                MI = rvm.MI
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,

                //TODO: You will need to change this value if you want to 
                //add the user to a different role - just specify the role name.
                RoleName = "Customer"
            };

            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            {
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }
            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                String username = lvm.Email;
                AppUser currentUser = _context.Users.FirstOrDefault(r => r.UserName == username);
                //return ?? "/" means if returnUrl is null, substitute "/" (home)

                if (currentUser.Is_Active == false)
                {
                    await _signInManager.SignOutAsync();
                    return View("Error", new string[] { "Account is Disabled." });
                }
                return Redirect(returnUrl ?? "/");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(lvm);
            }
        }


        //GET: Account/Index
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;
            ivm.Address = user.Address;
            ivm.Birthday = user.Birthday;
            ivm.PhoneNumber = user.PhoneNumber;
            ivm.FirstName = user.FirstName;
            ivm.LastName = user.LastName;

            //send data to the view
            return View(ivm);
        }



        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            //don't let the user change the password for the default users
            //this will keep the sample working for everyone
            if (User.Identity.Name == "admin@example.com" || User.Identity.Name == "bevo@example.com")
            {
                return View("Error", new string[] { "You cannot change the password for the default users." });
            }

            return View();
        }



        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            if (User.Identity.Name == "admin@example.com" || User.Identity.Name == "bevo@example.com")
            {
                return View("Error", new string[] { "You cannot change the password for the default users." });
            }


            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET: /Account/Edit
        [Authorize]
        public ActionResult EditAccount()
        {
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            EditAccountViewModel evm = new EditAccountViewModel();

            evm.Address = user.Address;
            evm.PhoneNumber = user.PhoneNumber;
            evm.Birthday = user.Birthday;
            evm.id = user.Id;

            return View(evm);
        }



        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> EditAccount(EditAccountViewModel evm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    String id = User.Identity.Name;
                    evm.id = id;
                    //Find the logged in user using the UserManager
                    AppUser user = _context.Users.FirstOrDefault(u => u.UserName == evm.id);

                    user.Address = evm.Address;
                    user.PhoneNumber = evm.PhoneNumber;
                    user.Birthday = evm.Birthday;

                    _context.Update(user);
                    _context.SaveChanges();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(evm.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            return View(evm);
        }


        // /Account/ManageAdminAccounts
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ManageAdminAccounts()
        {
            List<AppUser> allAdmins = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var adminList = await _userManager.IsInRoleAsync(user, "Admin") ? members : nonMembers;
                adminList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.RoleMembers = members;

            foreach (var admin in re.RoleMembers)
            {
                allAdmins.Add(admin);
            }
            return View(allAdmins);
        }

        // /Account/ManageCustomerAccounts
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ManageCustomerAccounts()
        {
            List<AppUser> allCustomers = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var customerList = await _userManager.IsInRoleAsync(user, "Customer") ? members : nonMembers;
                customerList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.RoleMembers = members;

            foreach (var customer in re.RoleMembers)
            {
                allCustomers.Add(customer);
            }
            return View(allCustomers);
        }

        // /Account/ManageHostAccounts
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ManageHostAccounts()
        {
            List<AppUser> allHosts = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var adminList = await _userManager.IsInRoleAsync(user, "Host") ? members : nonMembers;
                adminList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.RoleMembers = members;

            foreach (var host in re.RoleMembers)
            {
                allHosts.Add(host);
            }
            return View(allHosts);
        }

        //GET: /Account/EditAccount
        [Authorize(Roles = "Admin")]
        public ActionResult ModifyAdminProfile(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            EditAccountViewModel evm = new EditAccountViewModel();

            evm.FirstName = account.FirstName;
            evm.MI = account.MI;
            evm.LastName = account.LastName;
            evm.Address = account.Address;
            evm.ZipCode = account.ZipCode;
            evm.Birthday = account.Birthday;
            evm.PhoneNumber = account.PhoneNumber;

            return View(evm);
        }

        //POST: /Account/EditAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult ModifyAdminProfile(EditAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                        .FirstOrDefault(c => c.Id == account.id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.MI = account.MI;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.ZipCode = account.ZipCode;
                    dbAccount.Birthday = account.Birthday;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ModifyAdminProfile", "Account");
            }
            return View(account);
        }

        //GET: /Account/EditAccount
        [Authorize(Roles = "Admin")]
        public ActionResult ModifyHostProfile(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            EditAccountViewModel evm = new EditAccountViewModel();

            evm.FirstName = account.FirstName;
            evm.MI = account.MI;
            evm.LastName = account.LastName;
            evm.Address = account.Address;
            evm.ZipCode = account.ZipCode;
            evm.Birthday = account.Birthday;
            evm.PhoneNumber = account.PhoneNumber;

            return View(evm);
        }

        //POST: /Account/EditAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult ModifyHostProfile(EditAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                        .FirstOrDefault(c => c.Id == account.id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.MI = account.MI;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.ZipCode = account.ZipCode;
                    dbAccount.Birthday = account.Birthday;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ModifyHostProfile", "Account");
            }
            return View(account);
        }

        //GET: /Account/EditAccount
        [Authorize(Roles = "Admin")]
        public ActionResult ModifyCustomerProfile(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            EditAccountViewModel evm = new EditAccountViewModel();

            evm.FirstName = account.FirstName;
            evm.MI = account.MI;
            evm.LastName = account.LastName;
            evm.Address = account.Address;
            evm.ZipCode = account.ZipCode;
            evm.Birthday = account.Birthday;
            evm.PhoneNumber = account.PhoneNumber;

            return View(evm);
        }

        //POST: /Account/EditAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult ModifyCustomerProfile(EditAccountViewModel account)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    AppUser dbAccount = _context.Users
                        .FirstOrDefault(c => c.Id == account.id);

                    dbAccount.FirstName = account.FirstName;
                    dbAccount.MI = account.MI;
                    dbAccount.LastName = account.LastName;
                    dbAccount.Address = account.Address;
                    dbAccount.ZipCode = account.ZipCode;
                    dbAccount.Birthday = account.Birthday;
                    dbAccount.PhoneNumber = account.PhoneNumber;

                    _context.Update(dbAccount);
                    _context.SaveChanges();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ModifyCustomerProfile", "Account");
            }
            return View(account);
        }


        // Hire new Admin
        // /Account/CreateAdminAccount
        [Authorize(Roles = "Admin")]
        public ActionResult CreateAdminAccount()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> CreateAdminAccount(RegisterViewModel model, LoginViewModel LoginModel)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,

                    //TODO: You will need to add all of the properties for your User model here
                    //Make sure that you have included ALL of the properties and that they match
                    //the model class EXACTLY!!
                    FirstName = model.FirstName,
                    MI = model.MI,
                    LastName = model.LastName,
                    Address = model.Address,
                    ZipCode = model.ZipCode,
                    Birthday = model.Birthday,
                };

                user.Is_Active = true;
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //TODO: Add user to desired role
                    //This will not work until you have seeded Identity OR added the "Customer" role 
                    //by navigating to the RoleAdmin controller and manually added the "Customer" role
                    await _userManager.AddToRoleAsync(user, "Admin");

                    //Do not want to sign this person in
                    //Microsoft.AspNetCore.Identity.SignInResult result1 = await _signInManager.PasswordSignInAsync(LoginModel.Email, LoginModel.Password, LoginModel.RememberMe, lockoutOnFailure: false);

                    return RedirectToAction("ManageAdminAccounts", "Account"); //this is like the index page
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        //fire admin or rehire admin
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeAdminUserStatus(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppUser account = _context.Users.FirstOrDefault(c => c.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            //want to return a whether UserStatus is "Active" or "Inactive" --> done in view

            return View(account);
        }

        //POST: /Account/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ChangeAdminUserStatus(string id, UserStatusEnum SelectedUserStatus)
        {
            AppUser currentUser = _context.Users.FirstOrDefault(c => c.Id == id);

            if (SelectedUserStatus == UserStatusEnum.Active)
            {
                currentUser.Is_Active = true;
            }
            else
            {
                currentUser.Is_Active = false;
            }

            //figure out if this is right
            _context.Update(currentUser);
            _context.SaveChanges();


            //repopulate list of all customers
            List<AppUser> allAdmins = new List<AppUser>();

            List<AppUser> members = new List<AppUser>();
            List<AppUser> nonMembers = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                var adminList = await _userManager.IsInRoleAsync(user, "Admin") ? members : nonMembers;
                adminList.Add(user);
            }
            RoleEditModel re = new RoleEditModel();
            re.RoleMembers = members;

            foreach (var admin in re.RoleMembers)
            {
                allAdmins.Add(admin);
            }

            //return allCustomers;

            return View("ManageAdminAccounts", allAdmins);
        }

        ///////////////Change Password
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeAdminPassword(string id)
        {
            ChangeOtherPasswordViewModel selectedAccount = new ChangeOtherPasswordViewModel();
            selectedAccount.AccountSelectedID = id;

            return View(selectedAccount);
        }

        // POST: /Account/ChangeAdminPassword
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangeAdminPassword(ChangeOtherPasswordViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser adminSelected = await _userManager.FindByIdAsync(id);
            string code = await _userManager.GeneratePasswordResetTokenAsync(adminSelected);
            var result = await _userManager.ResetPasswordAsync(adminSelected, code, model.NewPassword);
            if (result.Succeeded)
            {
                //don't want to sign in when password is changed
                //await _signInManager.SignInAsync(customerSelected, isPersistent: false);
                return RedirectToAction("ManageAdminAccounts", "Account");
            }
            AddErrors(result);
            return View(model);
        }


        // /Account/ChangeHostPassword
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeHostPassword(string id)
        {
            ChangeOtherPasswordViewModel selectedAccount = new ChangeOtherPasswordViewModel();
            selectedAccount.AccountSelectedID = id;

            return View(selectedAccount);
        }

        // POST: /Account/ChangeHostPassword
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangeHostPassword(ChangeOtherPasswordViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser hostSelected = await _userManager.FindByIdAsync(id);
            string code = await _userManager.GeneratePasswordResetTokenAsync(hostSelected);
            var result = await _userManager.ResetPasswordAsync(hostSelected, code, model.NewPassword);
            if (result.Succeeded)
            {
                //don't want to sign in when password is changed
                //await _signInManager.SignInAsync(customerSelected, isPersistent: false);
                return RedirectToAction("ManageHostAccounts", "Account");
            }
            AddErrors(result);
            return View(model);
        }

        // /Account/ChangeCustomerPassword
        [Authorize(Roles = "Admin")]
        public ActionResult ChangeCustomerPassword(string id)
        {
            ChangeOtherPasswordViewModel selectedAccount = new ChangeOtherPasswordViewModel();
            selectedAccount.AccountSelectedID = id;

            return View(selectedAccount);
        }

        // POST: /Account/ChangeCustomerPassword
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<ActionResult> ChangeCustomerPassword(ChangeOtherPasswordViewModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUser customerSelected = await _userManager.FindByIdAsync(id);
            string code = await _userManager.GeneratePasswordResetTokenAsync(customerSelected);
            var result = await _userManager.ResetPasswordAsync(customerSelected, code, model.NewPassword);
            if (result.Succeeded)
            {
                //don't want to sign in when password is changed
                //await _signInManager.SignInAsync(customerSelected, isPersistent: false);
                return RedirectToAction("ManageCustomerAccounts", "Account");
            }
            AddErrors(result);
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        private bool AccountExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }
    }
}