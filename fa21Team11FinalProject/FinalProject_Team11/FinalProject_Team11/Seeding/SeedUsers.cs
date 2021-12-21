using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

using FinalProject_Team11.Models;
using FinalProject_Team11.Utilities;
using FinalProject_Team11.DAL;
using System.Threading.Tasks;

namespace FinalProject_Team11.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125595133",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Baker",
                    FirstName = "Christopher",
                    MI = "L",
                    Address = "1245 Lake America Blvd.",
                    ZipCode = "78733",
                    Birthday = new DateTime(1968, 11, 28),
                    Is_Active = true
                },
                Password = "hellothere",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mb@puppy.com",
                    Email = "mb@puppy.com",
                    PhoneNumber = "2102702860",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Bradicus",
                    FirstName = "Michelle",
                    MI = "Q",
                    Address = "1300 Small Pine Lane",
                    ZipCode = "78261",
                    Birthday = new DateTime(1988, 02, 07),
                    Is_Active = true
                },
                Password = "555533",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "fd@puppy.com",
                    Email = "fd@puppy.com",
                    PhoneNumber = "8175683686",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Broccoli",
                    FirstName = "Franco",
                    MI = "V",
                    Address = "62 Cookie Rd",
                    ZipCode = "77019",
                    Birthday = new DateTime(1999, 11, 07),
                    Is_Active = true
                },
                Password = "666645",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wendy@puppy.com",
                    Email = "wendy@puppy.com",
                    PhoneNumber = "5125967209",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Charile",
                    FirstName = "Wendy",
                    MI = "L",
                    Address = "202 Bellmoth Hall",
                    ZipCode = "78713",
                    Birthday = new DateTime(1992, 10, 27),
                    Is_Active = true
                },
                Password = "Kansas",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "limchou@puppy.com",
                    Email = "limchou@puppy.com",
                    PhoneNumber = "2107748586",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Chou",
                    FirstName = "Lim",
                    MI = "Q",
                    Address = "1600 Barbara Lane",
                    ZipCode = "78266",
                    Birthday = new DateTime(1961, 11, 11),
                    Is_Active = true
                },
                Password = "Rockwall",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "444444.Dave@aool.com",
                    Email = "444444.Dave@aool.com",
                    PhoneNumber = "2142667242",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Dave",
                    FirstName = "Shan",
                    MI = "D",
                    Address = "234 Puppy Circle",
                    ZipCode = "75208",
                    Birthday = new DateTime(1972, 12, 19),
                    Is_Active = true
                },
                Password = "444444",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louann@puppy.com",
                    Email = "louann@puppy.com",
                    PhoneNumber = "8172580736",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Feeley",
                    FirstName = "Lou Ann",
                    MI = "K",
                    Address = "700 S 9th Street W",
                    ZipCode = "77010",
                    Birthday = new DateTime(1958, 08, 01),
                    Is_Active = true
                },
                Password = "longhorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tfreeley@puppy.com",
                    Email = "tfreeley@puppy.com",
                    PhoneNumber = "8173279674",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Freeley",
                    FirstName = "Tesa",
                    MI = "P",
                    Address = "4334 Meanview Ave.",
                    ZipCode = "77009",
                    Birthday = new DateTime(2001, 07, 12),
                    Is_Active = true
                },
                Password = "puppies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mgar@puppy.com",
                    Email = "mgar@puppy.com",
                    PhoneNumber = "8176617531",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Garcia",
                    FirstName = "Margaret",
                    MI = "L",
                    Address = "594 Puppyview",
                    ZipCode = "77003",
                    Birthday = new DateTime(1956, 11, 17),
                    Is_Active = true
                },
                Password = "horses",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148499570",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Harley",
                    FirstName = "Charles",
                    MI = "E",
                    Address = "One Ranger Pkwy",
                    ZipCode = "75261",
                    Birthday = new DateTime(1998, 05, 29),
                    Is_Active = true
                },
                Password = "mycats",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jeff@puppy.com",
                    Email = "jeff@puppy.com",
                    PhoneNumber = "5127002600",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Stark",
                    FirstName = "Jeffrey",
                    MI = "T",
                    Address = "337 40th St.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1974, 05, 02),
                    Is_Active = true
                },
                Password = "jeffery",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148989608",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Hearn",
                    FirstName = "John",
                    MI = "B",
                    Address = "4445 South First",
                    ZipCode = "75237",
                    Birthday = new DateTime(1983, 12, 29),
                    Is_Active = true
                },
                Password = "posicles",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "hicks43@puppy.com",
                    Email = "hicks43@puppy.com",
                    PhoneNumber = "2105812952",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Hicks",
                    FirstName = "Mark",
                    MI = "J",
                    Address = "32 NE Mark Ln., Ste 910",
                    ZipCode = "78239",
                    Birthday = new DateTime(1989, 12, 16),
                    Is_Active = true
                },
                Password = "guac45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124702808",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Ingram",
                    FirstName = "Brad",
                    MI = "S",
                    Address = "6548 La Chess St.",
                    ZipCode = "78736",
                    Birthday = new DateTime(1958, 09, 18),
                    Is_Active = true
                },
                Password = "father",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "father.Ingram@aool.com",
                    Email = "father.Ingram@aool.com",
                    PhoneNumber = "5124677352",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Jacobs",
                    FirstName = "Todd",
                    MI = "L",
                    Address = "4564 Palm St.",
                    ZipCode = "78731",
                    Birthday = new DateTime(1975, 12, 09),
                    Is_Active = true
                },
                Password = "555897",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "victoria@puppy.com",
                    Email = "victoria@puppy.com",
                    PhoneNumber = "5129481386",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Lawrence",
                    FirstName = "Victoria",
                    MI = "M",
                    Address = "6639 Butterfly Ln.",
                    ZipCode = "78761",
                    Birthday = new DateTime(1981, 05, 29),
                    Is_Active = true
                },
                Password = "something",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102473963",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Lineback",
                    FirstName = "Brad",
                    MI = "W",
                    Address = "1300 Pirateland St",
                    ZipCode = "78293",
                    Birthday = new DateTime(1973, 05, 19),
                    Is_Active = true
                },
                Password = "treelover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105368614",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Lowe",
                    FirstName = "Evan",
                    MI = "S",
                    Address = "3201 Pineapple Drive",
                    ZipCode = "78279",
                    Birthday = new DateTime(1993, 06, 07),
                    Is_Active = true
                },
                Password = "headear",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "luce_chuck@puppy.com",
                    Email = "luce_chuck@puppy.com",
                    PhoneNumber = "2107007535",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Luce",
                    FirstName = "Chuck",
                    MI = "B",
                    Address = "2345 Silent Clouds",
                    ZipCode = "78268",
                    Birthday = new DateTime(1995, 06, 11),
                    Is_Active = true
                },
                Password = "gooseyloosey",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124772125",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "MacLeod",
                    FirstName = "Jennifer",
                    MI = "D",
                    Address = "2504 Far East Blvd.",
                    ZipCode = "78731",
                    Birthday = new DateTime(1965, 10, 11),
                    Is_Active = true
                },
                Password = "rainyday",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@puppy.com",
                    Email = "liz@puppy.com",
                    PhoneNumber = "5124603832",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Markham",
                    FirstName = "Elizabeth",
                    MI = "P",
                    Address = "7861 Chevy Mace Rd",
                    ZipCode = "78732",
                    Birthday = new DateTime(1989, 06, 18),
                    Is_Active = true
                },
                Password = "ember22",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mclarence@puppy.com",
                    Email = "mclarence@puppy.com",
                    PhoneNumber = "8174979188",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Martin",
                    FirstName = "Clarence",
                    MI = "A",
                    Address = "87 Alcedo St.",
                    ZipCode = "77045",
                    Birthday = new DateTime(1984, 04, 28),
                    Is_Active = true
                },
                Password = "lamemartin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lamemartin.Martin@aool.com",
                    Email = "lamemartin.Martin@aool.com",
                    PhoneNumber = "8178770705",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Martinez",
                    FirstName = "Gregory",
                    MI = "R",
                    Address = "8295 Moon Blvd.",
                    ZipCode = "77030",
                    Birthday = new DateTime(1981, 12, 27),
                    Is_Active = true
                },
                Password = "gregory",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177482602",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Miller",
                    FirstName = "Charles",
                    MI = "R",
                    Address = "8962 Side St.",
                    ZipCode = "77031",
                    Birthday = new DateTime(1987, 05, 05),
                    Is_Active = true
                },
                Password = "mucky44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "nelson.Kelly@puppy.com",
                    Email = "nelson.Kelly@puppy.com",
                    PhoneNumber = "8177482602",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Nelson",
                    FirstName = "Kelly",
                    MI = "T",
                    Address = "2601 Green River",
                    ZipCode = "78703",
                    Birthday = new DateTime(1969, 08, 03),
                    Is_Active = true
                },
                Password = "Tree34",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jojoe@puppy.com",
                    Email = "jojoe@puppy.com",
                    PhoneNumber = "2143149884",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Nguyen",
                    FirstName = "Joe",
                    MI = "C",
                    Address = "1249 4th NW St.",
                    ZipCode = "75238",
                    Birthday = new DateTime(1956, 02, 06),
                    Is_Active = true
                },
                Password = "jvb485bg",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103474912",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "O'Reilly",
                    FirstName = "Bill",
                    MI = "T",
                    Address = "8800 Gringo Drive",
                    ZipCode = "78260",
                    Birthday = new DateTime(1989, 03, 14),
                    Is_Active = true
                },
                Password = "Bobbygirl",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "or@puppy.com",
                    Email = "or@puppy.com",
                    PhoneNumber = "2142369553",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Radkovich",
                    FirstName = "Anka",
                    MI = "L",
                    Address = "1300 Freaky",
                    ZipCode = "75260",
                    Birthday = new DateTime(1952, 10, 26),
                    Is_Active = true
                },
                Password = "radioactive",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123768733",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rhodes",
                    FirstName = "Megan",
                    MI = "C",
                    Address = "4587 Rightfield Rd.",
                    ZipCode = "78707",
                    Birthday = new DateTime(1958, 03, 18),
                    Is_Active = true
                },
                Password = "gopigs",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "erynrice@puppy.com",
                    Email = "erynrice@puppy.com",
                    PhoneNumber = "5123900644",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rice",
                    FirstName = "Eryn",
                    MI = "M",
                    Address = "3405 Rio Small",
                    ZipCode = "78705",
                    Birthday = new DateTime(2000, 11, 02),
                    Is_Active = true
                },
                Password = "iloveme",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178928361",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rodriguez",
                    FirstName = "Jorge",
                    MI = "",
                    Address = "6788 Cotten Street",
                    ZipCode = "77057",
                    Birthday = new DateTime(1979, 01, 01),
                    Is_Active = true
                },
                Password = "565656",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128776930",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rogers",
                    FirstName = "Allen",
                    MI = "B",
                    Address = "4965 Rabbit Hill",
                    ZipCode = "78732",
                    Birthday = new DateTime(2000, 03, 12),
                    Is_Active = true
                },
                Password = "treeman",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "o_st-jean@home.com",
                    Email = "o_st-jean@home.com",
                    PhoneNumber = "2104169665",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Saint-Jean",
                    FirstName = "Olivier",
                    MI = "M",
                    Address = "255 Slap Dr.",
                    ZipCode = "78292",
                    Birthday = new DateTime(1997, 05, 01),
                    Is_Active = true
                },
                Password = "55htrq",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ss34@puppy.com",
                    Email = "ss34@puppy.com",
                    PhoneNumber = "5123521797",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Saunders",
                    FirstName = "Sarah",
                    MI = "J",
                    Address = "332 Fish C",
                    ZipCode = "78705",
                    Birthday = new DateTime(1994, 05, 31),
                    Is_Active = true
                },
                Password = "leaves",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124534071",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Sewell",
                    FirstName = "William",
                    MI = "T",
                    Address = "2365 34st St.",
                    ZipCode = "78709",
                    Birthday = new DateTime(1951, 12, 10),
                    Is_Active = true
                },
                Password = "borbj44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheff44@puppy.com",
                    Email = "sheff44@puppy.com",
                    PhoneNumber = "5125503154",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Sheffield",
                    FirstName = "Martin",
                    MI = "J",
                    Address = "3886 Road A",
                    ZipCode = "78705",
                    Birthday = new DateTime(1993, 07, 02),
                    Is_Active = true
                },
                Password = "ldiul485",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "johnsmith187@puppy.com",
                    Email = "johnsmith187@puppy.com",
                    PhoneNumber = "2108345875",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Smith",
                    FirstName = "John",
                    MI = "A",
                    Address = "23 Known Forge Dr.",
                    ZipCode = "78280",
                    Birthday = new DateTime(1985, 06, 13),
                    Is_Active = true
                },
                Password = "kribv75",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142370654",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Stroud",
                    FirstName = "Dustin",
                    MI = "P",
                    Address = "1212 Henrietta Rd",
                    ZipCode = "75221",
                    Birthday = new DateTime(1974, 07, 14),
                    Is_Active = true
                },
                Password = "klavjkb48",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "eric_stuart@puppy.com",
                    Email = "eric_stuart@puppy.com",
                    PhoneNumber = "5128202322",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Stuart",
                    FirstName = "Eric",
                    MI = "D",
                    Address = "5576 Big Ring",
                    ZipCode = "78746",
                    Birthday = new DateTime(1968, 06, 17),
                    Is_Active = true
                },
                Password = "vkb451",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174584890",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Stump",
                    FirstName = "Peter",
                    MI = "L",
                    Address = "1300 Kellen Square",
                    ZipCode = "77018",
                    Birthday = new DateTime(2001, 07, 23),
                    Is_Active = true
                },
                Password = "kdsiu4",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@puppy.com",
                    Email = "tanner@puppy.com",
                    PhoneNumber = "8174614916",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Tanner",
                    FirstName = "Jeremy",
                    MI = "S",
                    Address = "4347 Palmstead",
                    ZipCode = "77044",
                    Birthday = new DateTime(1973, 12, 28),
                    Is_Active = true
                },
                Password = "klrfbj45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylordjay@puppy.com",
                    Email = "taylordjay@puppy.com",
                    PhoneNumber = "5124772439",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Taylor",
                    FirstName = "Allison",
                    MI = "R",
                    Address = "467 Nueces St.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1999, 09, 30),
                    Is_Active = true
                },
                Password = "lraggrhb854",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lraggrhb854.Taylor@aool.com",
                    Email = "lraggrhb854.Taylor@aool.com",
                    PhoneNumber = "5124536618",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Taylor",
                    FirstName = "Rachel",
                    MI = "K",
                    Address = "345 Shortview Dr.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1956, 02, 24),
                    Is_Active = true
                },
                Password = "alsuib95",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tee_frank@hootmail.com",
                    Email = "tee_frank@hootmail.com",
                    PhoneNumber = "8178789530",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Tee",
                    FirstName = "Frank",
                    MI = "J",
                    Address = "5590 Big Dr.",
                    ZipCode = "77004",
                    Birthday = new DateTime(1964, 11, 11),
                    Is_Active = true
                },
                Password = "kd1734",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tuck33@puppy.com",
                    Email = "tuck33@puppy.com",
                    PhoneNumber = "2148495141",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Tucker",
                    FirstName = "Clent",
                    MI = "J",
                    Address = "3132 Main St.",
                    ZipCode = "75315",
                    Birthday = new DateTime(1990, 06, 25),
                    Is_Active = true
                },
                Password = "kjdb983",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "avelasco@puppy.com",
                    Email = "avelasco@puppy.com",
                    PhoneNumber = "2144009625",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Velasco",
                    FirstName = "Allen",
                    MI = "G",
                    Address = "634 W. 4th",
                    ZipCode = "75207",
                    Birthday = new DateTime(1966, 12, 13),
                    Is_Active = true
                },
                Password = "odrb02",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148499231",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "West",
                    FirstName = "Jake",
                    MI = "T",
                    Address = "RR 3244",
                    ZipCode = "75323",
                    Birthday = new DateTime(1968, 02, 06),
                    Is_Active = true
                },
                Password = "kndl847",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louielouie@puppy.com",
                    Email = "louielouie@puppy.com",
                    PhoneNumber = "2145674085",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Winthorpe",
                    FirstName = "Louis",
                    MI = "L",
                    Address = "2500 Madre Blvd",
                    ZipCode = "78746",
                    Birthday = new DateTime(1961, 07, 23),
                    Is_Active = true
                },
                Password = "lb2394",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124569229",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Wood",
                    FirstName = "Reagan",
                    MI = "B",
                    Address = "447 Westlake Dr.",
                    ZipCode = "78746",
                    Birthday = new DateTime(1988, 10, 24),
                    Is_Active = true
                },
                Password = "drai494",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jacobs@yahoo.com",
                    Email = "jacobs@yahoo.com",
                    PhoneNumber = "8176663948",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Jacobs",
                    FirstName = "Todd",
                    MI = "L",
                    Address = "4564 Elm St.",
                    ZipCode = "77003",
                    Birthday = new DateTime(1978, 01, 29),
                    Is_Active = true
                },
                Password = "tj2245",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rice@yahoo.com",
                    Email = "rice@yahoo.com",
                    PhoneNumber = "2148545987",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rice",
                    FirstName = "Eryn",
                    MI = "M",
                    Address = "3405 Rio Grande",
                    ZipCode = "75261",
                    Birthday = new DateTime(2003, 06, 11),
                    Is_Active = true
                },
                Password = "ricearoni",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ingram@gmail.com",
                    Email = "ingram@gmail.com",
                    PhoneNumber = "5127049017",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Ingram",
                    FirstName = "John",
                    MI = "R",
                    Address = "6548 La Posada Ct.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1980, 06, 25),
                    Is_Active = true
                },
                Password = "ingram68",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "martinez@aol.com",
                    Email = "martinez@aol.com",
                    PhoneNumber = "2105859369",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Martinez",
                    FirstName = "Paul",
                    MI = "G",
                    Address = "8295 Sunset Blvd.",
                    ZipCode = "78239",
                    Birthday = new DateTime(1969, 06, 25),
                    Is_Active = true
                },
                Password = "party1",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@utexas.edu",
                    Email = "tanner@utexas.edu",
                    PhoneNumber = "5129527803",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Tanner",
                    FirstName = "Jared",
                    MI = "F",
                    Address = "4347 Almstead",
                    ZipCode = "78761",
                    Birthday = new DateTime(1979, 06, 02),
                    Is_Active = true
                },
                Password = "sandman",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chung@yahoo.com",
                    Email = "chung@yahoo.com",
                    PhoneNumber = "2107053952",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Chung",
                    FirstName = "Lauren",
                    MI = "R",
                    Address = "234 RR 12",
                    ZipCode = "78268",
                    Birthday = new DateTime(1976, 03, 24),
                    Is_Active = true
                },
                Password = "listen",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "loter@yahoo.com",
                    Email = "loter@yahoo.com",
                    PhoneNumber = "5124650249",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Loter",
                    FirstName = "Wandavison",
                    MI = "T",
                    Address = "3453 RR 3235",
                    ZipCode = "78732",
                    Birthday = new DateTime(1966, 09, 23),
                    Is_Active = true
                },
                Password = "pottery",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "morales@aol.com",
                    Email = "morales@aol.com",
                    PhoneNumber = "8177529019",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Morales",
                    FirstName = "Heather",
                    MI = "R",
                    Address = "4501 RR 140",
                    ZipCode = "77031",
                    Birthday = new DateTime(1971, 01, 16),
                    Is_Active = true
                },
                Password = "heckin",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rankin@yahoo.com",
                    Email = "rankin@yahoo.com",
                    PhoneNumber = "5122997370",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rankin",
                    FirstName = "Martin",
                    MI = "P",
                    Address = "340 Second St",
                    ZipCode = "78703",
                    Birthday = new DateTime(1961, 05, 16),
                    Is_Active = true
                },
                Password = "rankmark",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "gonzalez@aol.com",
                    Email = "gonzalez@aol.com",
                    PhoneNumber = "2142415970",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Gonzalez",
                    FirstName = "Garth",
                    MI = "R",
                    Address = "103 Manor Rd",
                    ZipCode = "75260",
                    Birthday = new DateTime(1993, 12, 10),
                    Is_Active = true
                },
                Password = "gg2017",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylor@bevobnb.com",
                    Email = "taylor@bevobnb.com",
                    PhoneNumber = "2149036025",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Taylor",
                    FirstName = "Albert",
                    MI = "F",
                    Address = "467 Nueces St.",
                    ZipCode = "75237",
                    Birthday = new DateTime(1954, 8, 14),
                    Is_Active = true
                },
                Password = "TRY563",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheffield@bevobnb.com",
                    Email = "sheffield@bevobnb.com",
                    PhoneNumber = "5124749225",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Sheffiled",
                    FirstName = "Molly",
                    MI = "R",
                    Address = "3886 Avenue A",
                    ZipCode = "78736",
                    Birthday = new DateTime(1986, 8, 27),
                    Is_Active = true
                },
                Password = "longsnores",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "macleod@bevobnb.com",
                    Email = "macleod@bevobnb.com",
                    PhoneNumber = "886719249",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "MacLeod",
                    FirstName = "Jenny",
                    MI = "I",
                    Address = "2504 Far West Blvd.",
                    ZipCode = "78731",
                    Birthday = new DateTime(1984, 12, 05),
                    Is_Active = true
                },
                Password = "kittys",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rhodes@bevobnb.com",
                    Email = "rhodes@bevobnb.com",
                    PhoneNumber = "2102520380",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rhodes",
                    FirstName = "Michelle",
                    MI = "N",
                    Address = "4587 Enfield Rd.",
                    ZipCode = "78293",
                    Birthday = new DateTime(1972, 7, 2),
                    Is_Active = true
                },
                Password = "puppies",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "stuart@bevobnb.com",
                    Email = "stuart@bevobnb.com",
                    PhoneNumber = "212121212",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Stuart",
                    FirstName = "Evan",
                    MI = "Q",
                    Address = "5576 Toro Ring",
                    ZipCode = "78279",
                    Birthday = new DateTime(1984, 4, 17),
                    Is_Active = true
                },
                Password = "coolboi",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "swanson@bevobnb.com",
                    Email = "swanson@bevobnb.com",
                    PhoneNumber = "444444444",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Swanson",
                    FirstName = "Ron",
                    MI = "P",
                    Address = "245 River Rd",
                    ZipCode = "78731",
                    Birthday = new DateTime(1991, 7, 25),
                    Is_Active = true
                },
                Password = "swanbong",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "white@bevobnb.com",
                    Email = "white@bevobnb.com",
                    PhoneNumber = "8175025605",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "White",
                    FirstName = "Jabriel",
                    MI = "M",
                    Address = "12 Valley View",
                    ZipCode = "77045",
                    Birthday = new DateTime(1986, 03, 17),
                    Is_Active = true
                },
                Password = "456789",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "montgomery@bevobnb.com",
                    Email = "montgomery@bevobnb.com",
                    PhoneNumber = "8178817122",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Montgomery",
                    FirstName = "Washington",
                    MI = "X",
                    Address = "210 Blanco Dr",
                    ZipCode = "77030",
                    Birthday = new DateTime(1961, 05, 04),
                    Is_Active = true
                },
                Password = "python4",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "walker@bevobnb.com",
                    Email = "walker@bevobnb.com",
                    PhoneNumber = "2143196301",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Walker",
                    FirstName = "Lisa",
                    MI = "O",
                    Address = "9 Bison Circle",
                    ZipCode = "75238",
                    Birthday = new DateTime(2003, 04, 18),
                    Is_Active = true
                },
                Password = "walkameter",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chang@bevobnb.com",
                    Email = "chang@bevobnb.com",
                    PhoneNumber = "2103521329",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Chang",
                    FirstName = "Gregory",
                    MI = "J",
                    Address = "9003 Joshua St",
                    ZipCode = "78260",
                    Birthday = new DateTime(1958, 04, 26),
                    Is_Active = true
                },
                Password = "pupgang",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "derek@bevobnb.com",
                    Email = "derek@bevobnb.com",
                    PhoneNumber = "5125556789",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Dreibrodt",
                    FirstName = "Derek",
                    MI = "X",
                    Address = "4 Privet Dr",
                    ZipCode = "78705",
                    Birthday = new DateTime(2001, 01, 01),
                    Is_Active = true
                },
                Password = "2cool4u",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rester@bevobnb.com",
                    Email = "rester@bevobnb.com",
                    PhoneNumber = "2103521329",

                    //Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    LastName = "Rester",
                    FirstName = "Amy",
                    MI = "K",
                    Address = "2110 Speedway",
                    ZipCode = "78705",
                    Birthday = new DateTime(2000, 01, 01),
                    Is_Active = true
                },
                Password = "KIzGreat",
                RoleName = "Admin"
            });

            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }
}
