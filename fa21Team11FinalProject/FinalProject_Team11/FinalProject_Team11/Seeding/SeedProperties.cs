using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace FinalProject_Team11.Seeding
{
	public static class SeedProperties
{
	public static void SeedAllProperty(AppDbContext db)
	{
		if (db.Properties.Count() == 183)
			{
			throw new NotSupportedException("The database already contains all 183 properties!");
		}

		Int32 intPropertiesAdded = 0;
		String strPropertyAddress = "Begin"; //helps to keep track of error on books
		List<Property> Properties = new List<Property>();

		try
		{
			Property p1 = new Property()
			{
				PropertyZip = "72227",
				PropertyState = "PA",
				PropertyAddress = "8714 Mann Plaza",
				PropertyCity = "Lisaside",
				WeekendPrice = 171.57m,
				WeekdayPrice = 152.68m,
				CleaningFee = 8.88m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 9,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p1.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p1.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p1);

			Property p2 = new Property()
			{
				PropertyZip = "05565",
				PropertyState = "FL",
				PropertyAddress = "96593 White View Apt. 094",
				PropertyCity = "Jonesberg",
				WeekendPrice = 148.15m,
				WeekdayPrice = 120.81m,
				CleaningFee = 8.02m,
				PropertyBedroom = 7,
				PropertyBathroom = 8,
				PropertyGuest = 8,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p2.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p2.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p2);

			Property p3 = new Property()
			{
				PropertyZip = "80819",
				PropertyState = "MD",
				PropertyAddress = "848 Melissa Springs Suite 947",
				PropertyCity = "Kellerstad",
				WeekendPrice = 132.99m,
				WeekdayPrice = 127.96m,
				CleaningFee = 13.37m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 8,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p3.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p3.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p3);

			Property p4 = new Property()
			{
				PropertyZip = "79428",
				PropertyState = "ND",
				PropertyAddress = "30413 Norton Isle Suite 012",
				PropertyCity = "North Lisa",
				WeekendPrice = 185.35m,
				WeekdayPrice = 80.2m,
				CleaningFee = 5.57m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 14,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p4.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p4.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p4);

			Property p5 = new Property()
			{
				PropertyZip = "63315",
				PropertyState = "DE",
				PropertyAddress = "39916 Mitchell Crescent",
				PropertyCity = "New Andrewburgh",
				WeekendPrice = 100.37m,
				WeekdayPrice = 170.25m,
				CleaningFee = 18.64m,
				PropertyBedroom = 2,
				PropertyBathroom = 3,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p5.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p5.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p5);

			Property p6 = new Property()
			{
				PropertyZip = "24135",
				PropertyState = "NE",
				PropertyAddress = "086 Mary Cliff",
				PropertyCity = "North Deborah",
				WeekendPrice = 162.6m,
				WeekdayPrice = 220.24m,
				CleaningFee = 10.83m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p6.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p6.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p6);

			Property p7 = new Property()
			{
				PropertyZip = "58475",
				PropertyState = "PA",
				PropertyAddress = "91634 Strong Mountains Apt. 302",
				PropertyCity = "West Alyssa",
				WeekendPrice = 204.87m,
				WeekdayPrice = 213.37m,
				CleaningFee = 25.04m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 9,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p7.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p7.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p7);

			Property p8 = new Property()
			{
				PropertyZip = "10865",
				PropertyState = "WA",
				PropertyAddress = "6984 Price Shoals",
				PropertyCity = "Erictown",
				WeekendPrice = 140.89m,
				WeekdayPrice = 159.69m,
				CleaningFee = 27.13m,
				PropertyBedroom = 2,
				PropertyBathroom = 3,
				PropertyGuest = 8,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p8.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p8.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p8);

			Property p9 = new Property()
			{
				PropertyZip = "51359",
				PropertyState = "ME",
				PropertyAddress = "423 Bell Heights",
				PropertyCity = "Brittanyberg",
				WeekendPrice = 295.39m,
				WeekdayPrice = 200.73m,
				CleaningFee = 14.91m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p9.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p9.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p9);

			Property p10 = new Property()
			{
				PropertyZip = "87296",
				PropertyState = "WI",
				PropertyAddress = "93523 Dana Lane",
				PropertyCity = "Johnsonshire",
				WeekendPrice = 110.8m,
				WeekdayPrice = 170.39m,
				CleaningFee = 8.67m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p10.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p10.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p10);

			Property p11 = new Property()
			{
				PropertyZip = "07035",
				PropertyState = "NH",
				PropertyAddress = "1427 Odonnell Rapids",
				PropertyCity = "North Troyport",
				WeekendPrice = 126.29m,
				WeekdayPrice = 217.15m,
				CleaningFee = 26.48m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 14,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p11.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p11.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p11);

			Property p12 = new Property()
			{
				PropertyZip = "37198",
				PropertyState = "ME",
				PropertyAddress = "81206 Stewart Forest Apt. 089",
				PropertyCity = "East Davidborough",
				WeekendPrice = 293.26m,
				WeekdayPrice = 205.21m,
				CleaningFee = 28.74m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 8,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p12.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p12.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p12);

			Property p13 = new Property()
			{
				PropertyZip = "85034",
				PropertyState = "SD",
				PropertyAddress = "76104 Marsh Crescent",
				PropertyCity = "Dennishaven",
				WeekendPrice = 126.99m,
				WeekdayPrice = 123.13m,
				CleaningFee = 18.73m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p13.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p13.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p13);

			Property p14 = new Property()
			{
				PropertyZip = "60619",
				PropertyState = "SD",
				PropertyAddress = "0003 Grant Lakes",
				PropertyCity = "Port Karafort",
				WeekendPrice = 188.81m,
				WeekdayPrice = 89.19m,
				CleaningFee = 11.98m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 14,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p14.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p14.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p14);

			Property p15 = new Property()
			{
				PropertyZip = "21978",
				PropertyState = "KY",
				PropertyAddress = "236 Smith Drive Suite 555",
				PropertyCity = "West Kimberlyton",
				WeekendPrice = 132.96m,
				WeekdayPrice = 198.3m,
				CleaningFee = 13.96m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 11,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p15.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p15.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p15);

			Property p16 = new Property()
			{
				PropertyZip = "14742",
				PropertyState = "MT",
				PropertyAddress = "6824 Timothy Garden Apt. 428",
				PropertyCity = "West Richardmouth",
				WeekendPrice = 297.31m,
				WeekdayPrice = 181.5m,
				CleaningFee = 10.09m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 10,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p16.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p16.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p16);

			Property p17 = new Property()
			{
				PropertyZip = "11894",
				PropertyState = "SC",
				PropertyAddress = "5517 Holly Meadow Apt. 452",
				PropertyCity = "Lake Anne",
				WeekendPrice = 139.22m,
				WeekdayPrice = 134.09m,
				CleaningFee = 9.75m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p17.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p17.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p17);

			Property p18 = new Property()
			{
				PropertyZip = "28976",
				PropertyState = "TX",
				PropertyAddress = "30601 Hawkins Highway",
				PropertyCity = "Morashire",
				WeekendPrice = 160.61m,
				WeekdayPrice = 187.65m,
				CleaningFee = 7.5m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 9,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p18.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p18.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p18);

			Property p19 = new Property()
			{
				PropertyZip = "28798",
				PropertyState = "AZ",
				PropertyAddress = "49263 Wilson View Apt. 873",
				PropertyCity = "South Raymondborough",
				WeekendPrice = 133.25m,
				WeekdayPrice = 206.95m,
				CleaningFee = 14.04m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 5,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p19.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p19.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p19);

			Property p20 = new Property()
			{
				PropertyZip = "68819",
				PropertyState = "NE",
				PropertyAddress = "76582 Vanessa Oval",
				PropertyCity = "New Richard",
				WeekendPrice = 242.89m,
				WeekdayPrice = 99.54m,
				CleaningFee = 6.61m,
				PropertyBedroom = 5,
				PropertyBathroom = 4,
				PropertyGuest = 12,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p20.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p20.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p20);

			Property p21 = new Property()
			{
				PropertyZip = "50177",
				PropertyState = "FL",
				PropertyAddress = "7389 Alec Squares Suite 508",
				PropertyCity = "Port Jonathan",
				WeekendPrice = 165.32m,
				WeekdayPrice = 112.62m,
				CleaningFee = 24.26m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p21.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p21.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p21);

			Property p22 = new Property()
			{
				PropertyZip = "66355",
				PropertyState = "NC",
				PropertyAddress = "18013 Billy Bridge Suite 522",
				PropertyCity = "Schmitthaven",
				WeekendPrice = 119.02m,
				WeekdayPrice = 199.21m,
				CleaningFee = 11.63m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p22.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p22.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p22);

			Property p23 = new Property()
			{
				PropertyZip = "51431",
				PropertyState = "NJ",
				PropertyAddress = "891 Bullock Ford",
				PropertyCity = "Amandachester",
				WeekendPrice = 244.93m,
				WeekdayPrice = 179.05m,
				CleaningFee = 21.78m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 11,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p23.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p23.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p23);

			Property p24 = new Property()
			{
				PropertyZip = "50853",
				PropertyState = "MT",
				PropertyAddress = "02489 Cook Park",
				PropertyCity = "Sherriport",
				WeekendPrice = 227.35m,
				WeekdayPrice = 207.24m,
				CleaningFee = 5.5m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 6,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p24.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p24.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p24);

			Property p25 = new Property()
			{
				PropertyZip = "20341",
				PropertyState = "UT",
				PropertyAddress = "23450 Timothy Divide",
				PropertyCity = "Wuland",
				WeekendPrice = 278.36m,
				WeekdayPrice = 116.01m,
				CleaningFee = 24.73m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 11,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p25.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p25.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p25);

			Property p26 = new Property()
			{
				PropertyZip = "85565",
				PropertyState = "OH",
				PropertyAddress = "0976 Williams Mountains Apt. 009",
				PropertyCity = "Lake Mario",
				WeekendPrice = 293.42m,
				WeekdayPrice = 225.14m,
				CleaningFee = 10.42m,
				PropertyBedroom = 6,
				PropertyBathroom = 7,
				PropertyGuest = 7,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p26.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p26.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p26);

			Property p27 = new Property()
			{
				PropertyZip = "51884",
				PropertyState = "WY",
				PropertyAddress = "1097 Santos Springs Suite 264",
				PropertyCity = "New Michelleborough",
				WeekendPrice = 126.45m,
				WeekdayPrice = 70.24m,
				CleaningFee = 18.69m,
				PropertyBedroom = 2,
				PropertyBathroom = 2,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p27.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p27.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p27);

			Property p28 = new Property()
			{
				PropertyZip = "66353",
				PropertyState = "SC",
				PropertyAddress = "5100 Scott Burg",
				PropertyCity = "East Clayton",
				WeekendPrice = 224.07m,
				WeekdayPrice = 186.38m,
				CleaningFee = 28.24m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p28.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p28.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p28);

			Property p29 = new Property()
			{
				PropertyZip = "57004",
				PropertyState = "NV",
				PropertyAddress = "412 Snow Manors Apt. 161",
				PropertyCity = "South Kimtown",
				WeekendPrice = 120.93m,
				WeekdayPrice = 112.47m,
				CleaningFee = 23.28m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p29.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p29.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p29);

			Property p30 = new Property()
			{
				PropertyZip = "48447",
				PropertyState = "IN",
				PropertyAddress = "5415 David Square",
				PropertyCity = "West Michaeltown",
				WeekendPrice = 100.02m,
				WeekdayPrice = 214.81m,
				CleaningFee = 17.78m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p30.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p30.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p30);

			Property p31 = new Property()
			{
				PropertyZip = "62982",
				PropertyState = "DE",
				PropertyAddress = "03104 Norris Rapids",
				PropertyCity = "Port Donald",
				WeekendPrice = 161.6m,
				WeekdayPrice = 159.87m,
				CleaningFee = 10.34m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 11,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p31.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p31.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p31);

			Property p32 = new Property()
			{
				PropertyZip = "16915",
				PropertyState = "FL",
				PropertyAddress = "03557 Phillips Wells Suite 291",
				PropertyCity = "New Beverlyburgh",
				WeekendPrice = 203.6m,
				WeekdayPrice = 70.55m,
				CleaningFee = 5.09m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p32.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p32.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p32);

			Property p33 = new Property()
			{
				PropertyZip = "39742",
				PropertyState = "MT",
				PropertyAddress = "332 Watson Shore Apt. 290",
				PropertyCity = "Millerland",
				WeekendPrice = 299.34m,
				WeekdayPrice = 176.37m,
				CleaningFee = 17.38m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p33.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p33.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p33);

			Property p34 = new Property()
			{
				PropertyZip = "54060",
				PropertyState = "MS",
				PropertyAddress = "645 John Roads",
				PropertyCity = "Danahaven",
				WeekendPrice = 229.98m,
				WeekdayPrice = 172.83m,
				CleaningFee = 23.55m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 14,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p34.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p34.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p34);

			Property p35 = new Property()
			{
				PropertyZip = "55774",
				PropertyState = "HI",
				PropertyAddress = "3547 Stephanie Underpass Apt. 418",
				PropertyCity = "Port Jacqueline",
				WeekendPrice = 143.71m,
				WeekdayPrice = 177.08m,
				CleaningFee = 19.21m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 5,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p35.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p35.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p35);

			Property p36 = new Property()
			{
				PropertyZip = "59363",
				PropertyState = "UT",
				PropertyAddress = "5825 Welch Corners",
				PropertyCity = "Fischerport",
				WeekendPrice = 113.86m,
				WeekdayPrice = 76.66m,
				CleaningFee = 27.87m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 10,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p36.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p36.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p36);

			Property p37 = new Property()
			{
				PropertyZip = "71770",
				PropertyState = "IN",
				PropertyAddress = "41489 Roger Terrace",
				PropertyCity = "Davisfort",
				WeekendPrice = 299.09m,
				WeekdayPrice = 177.37m,
				CleaningFee = 23.78m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 6,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p37.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p37.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p37);

			Property p38 = new Property()
			{
				PropertyZip = "05147",
				PropertyState = "CO",
				PropertyAddress = "014 Aaron Locks Suite 714",
				PropertyCity = "Justinborough",
				WeekendPrice = 158.42m,
				WeekdayPrice = 104.05m,
				CleaningFee = 5.36m,
				PropertyBedroom = 2,
				PropertyBathroom = 2,
				PropertyGuest = 5,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p38.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p38.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p38);

			Property p39 = new Property()
			{
				PropertyZip = "28062",
				PropertyState = "SC",
				PropertyAddress = "8518 Pamela Track Apt. 164",
				PropertyCity = "Aprilshire",
				WeekendPrice = 210.59m,
				WeekdayPrice = 199.37m,
				CleaningFee = 8.83m,
				PropertyBedroom = 3,
				PropertyBathroom = 2,
				PropertyGuest = 1,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p39.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p39.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p39);

			Property p40 = new Property()
			{
				PropertyZip = "88090",
				PropertyState = "OH",
				PropertyAddress = "864 Ramos Port Apt. 211",
				PropertyCity = "Moralesmouth",
				WeekendPrice = 153.69m,
				WeekdayPrice = 94.48m,
				CleaningFee = 16.85m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 9,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p40.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p40.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p40);

			Property p41 = new Property()
			{
				PropertyZip = "28775",
				PropertyState = "RI",
				PropertyAddress = "637 Neal Island Suite 074",
				PropertyCity = "Lake Tyler",
				WeekendPrice = 196.14m,
				WeekdayPrice = 88.82m,
				CleaningFee = 6.97m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 14,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p41.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p41.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p41);

			Property p42 = new Property()
			{
				PropertyZip = "75585",
				PropertyState = "WV",
				PropertyAddress = "0811 Smith Canyon Apt. 904",
				PropertyCity = "Jessicabury",
				WeekendPrice = 123.22m,
				WeekdayPrice = 119.58m,
				CleaningFee = 18.45m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p42.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p42.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p42);

			Property p43 = new Property()
			{
				PropertyZip = "17438",
				PropertyState = "MD",
				PropertyAddress = "7562 Fisher Spur",
				PropertyCity = "Hernandezberg",
				WeekendPrice = 283.77m,
				WeekdayPrice = 218.87m,
				CleaningFee = 19.07m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 2,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p43.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p43.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p43);

			Property p44 = new Property()
			{
				PropertyZip = "07027",
				PropertyState = "VT",
				PropertyAddress = "5667 Blair Underpass",
				PropertyCity = "South Shelby",
				WeekendPrice = 239.76m,
				WeekdayPrice = 76.19m,
				CleaningFee = 11.37m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p44.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p44.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p44);

			Property p45 = new Property()
			{
				PropertyZip = "01008",
				PropertyState = "MI",
				PropertyAddress = "6708 Carpenter Overpass Suite 735",
				PropertyCity = "Bobbyton",
				WeekendPrice = 229.04m,
				WeekdayPrice = 161.17m,
				CleaningFee = 25.01m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 7,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p45.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p45.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p45);

			Property p46 = new Property()
			{
				PropertyZip = "60236",
				PropertyState = "ND",
				PropertyAddress = "16396 Shawn Junction",
				PropertyCity = "New Nicolemouth",
				WeekendPrice = 220.69m,
				WeekdayPrice = 106.06m,
				CleaningFee = 11.82m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 6,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p46.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p46.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p46);

			Property p47 = new Property()
			{
				PropertyZip = "01707",
				PropertyState = "CA",
				PropertyAddress = "4486 Olson Well",
				PropertyCity = "North Kevin",
				WeekendPrice = 138.96m,
				WeekdayPrice = 151.44m,
				CleaningFee = 6.72m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 10,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p47.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p47.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p47);

			Property p48 = new Property()
			{
				PropertyZip = "33233",
				PropertyState = "HI",
				PropertyAddress = "67771 Christopher Courts Apt. 637",
				PropertyCity = "Port Ronaldfurt",
				WeekendPrice = 134.28m,
				WeekdayPrice = 102.43m,
				CleaningFee = 19.81m,
				PropertyBedroom = 5,
				PropertyBathroom = 5,
				PropertyGuest = 2,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p48.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p48.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p48);

			Property p49 = new Property()
			{
				PropertyZip = "79756",
				PropertyState = "NY",
				PropertyAddress = "5561 Bishop Turnpike",
				PropertyCity = "Lake Kenneth",
				WeekendPrice = 259.87m,
				WeekdayPrice = 94.31m,
				CleaningFee = 22.33m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 11,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p49.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p49.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p49);

			Property p50 = new Property()
			{
				PropertyZip = "36216",
				PropertyState = "SD",
				PropertyAddress = "3019 Gerald Mall Apt. 340",
				PropertyCity = "Trevinoville",
				WeekendPrice = 263.32m,
				WeekdayPrice = 151.69m,
				CleaningFee = 13.27m,
				PropertyBedroom = 5,
				PropertyBathroom = 5,
				PropertyGuest = 1,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p50.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p50.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p50);

			Property p51 = new Property()
			{
				PropertyZip = "43477",
				PropertyState = "NY",
				PropertyAddress = "84331 Leonard Fort Suite 749",
				PropertyCity = "East Lisa",
				WeekendPrice = 204.28m,
				WeekdayPrice = 204.04m,
				CleaningFee = 11.07m,
				PropertyBedroom = 7,
				PropertyBathroom = 8,
				PropertyGuest = 10,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p51.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p51.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p51);

			Property p52 = new Property()
			{
				PropertyZip = "17819",
				PropertyState = "VA",
				PropertyAddress = "62281 Kathy Tunnel",
				PropertyCity = "Hudsonborough",
				WeekendPrice = 224.19m,
				WeekdayPrice = 165.51m,
				CleaningFee = 24.26m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 9,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p52.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p52.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p52);

			Property p53 = new Property()
			{
				PropertyZip = "97149",
				PropertyState = "NM",
				PropertyAddress = "9927 Christina Burg Suite 774",
				PropertyCity = "East Angelaburgh",
				WeekendPrice = 121.74m,
				WeekdayPrice = 106.87m,
				CleaningFee = 5.62m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 6,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p53.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p53.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p53);

			Property p54 = new Property()
			{
				PropertyZip = "45480",
				PropertyState = "IA",
				PropertyAddress = "142 Warner View Suite 460",
				PropertyCity = "North Leslie",
				WeekendPrice = 148.76m,
				WeekdayPrice = 212.32m,
				CleaningFee = 20.2m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 9,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p54.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p54.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p54);

			Property p55 = new Property()
			{
				PropertyZip = "03720",
				PropertyState = "AR",
				PropertyAddress = "5240 Berry Centers",
				PropertyCity = "West Andrew",
				WeekendPrice = 111.01m,
				WeekdayPrice = 164.02m,
				CleaningFee = 26.21m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p55.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p55.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p55);

			Property p56 = new Property()
			{
				PropertyZip = "85576",
				PropertyState = "HI",
				PropertyAddress = "51056 Patricia Forge",
				PropertyCity = "Grahamstad",
				WeekendPrice = 167.53m,
				WeekdayPrice = 117.45m,
				CleaningFee = 24.75m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 10,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p56.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p56.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p56);

			Property p57 = new Property()
			{
				PropertyZip = "92199",
				PropertyState = "VA",
				PropertyAddress = "0648 Malone Port Apt. 662",
				PropertyCity = "New Devonhaven",
				WeekendPrice = 176.53m,
				WeekdayPrice = 209.47m,
				CleaningFee = 5.83m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p57.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p57.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p57);

			Property p58 = new Property()
			{
				PropertyZip = "05261",
				PropertyState = "SC",
				PropertyAddress = "23028 Jennifer Meadow Apt. 972",
				PropertyCity = "West Matthewfurt",
				WeekendPrice = 199.1m,
				WeekdayPrice = 153.04m,
				CleaningFee = 18.62m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 14,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p58.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p58.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p58);

			Property p59 = new Property()
			{
				PropertyZip = "72649",
				PropertyState = "LA",
				PropertyAddress = "2738 Martin Terrace Suite 547",
				PropertyCity = "Smithhaven",
				WeekendPrice = 199.22m,
				WeekdayPrice = 196.56m,
				CleaningFee = 20.71m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 11,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p59.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p59.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p59);

			Property p60 = new Property()
			{
				PropertyZip = "97488",
				PropertyState = "KY",
				PropertyAddress = "984 Stephen Stravenue",
				PropertyCity = "South Michaelton",
				WeekendPrice = 178.29m,
				WeekdayPrice = 117.03m,
				CleaningFee = 6.47m,
				PropertyBedroom = 4,
				PropertyBathroom = 6,
				PropertyGuest = 3,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p60.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p60.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p60);

			Property p61 = new Property()
			{
				PropertyZip = "42837",
				PropertyState = "LA",
				PropertyAddress = "98522 Mathis Viaduct Apt. 909",
				PropertyCity = "West Michael",
				WeekendPrice = 252.79m,
				WeekdayPrice = 133.35m,
				CleaningFee = 9.15m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p61.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p61.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p61);

			Property p62 = new Property()
			{
				PropertyZip = "56059",
				PropertyState = "OH",
				PropertyAddress = "620 Ashley Mills Apt. 507",
				PropertyCity = "Julieborough",
				WeekendPrice = 296.05m,
				WeekdayPrice = 171.15m,
				CleaningFee = 18.26m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 9,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p62.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p62.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p62);

			Property p63 = new Property()
			{
				PropertyZip = "02288",
				PropertyState = "LA",
				PropertyAddress = "212 Shelly Roads",
				PropertyCity = "Fischerview",
				WeekendPrice = 163.88m,
				WeekdayPrice = 132.81m,
				CleaningFee = 7.46m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 10,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p63.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p63.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p63);

			Property p64 = new Property()
			{
				PropertyZip = "50851",
				PropertyState = "OK",
				PropertyAddress = "8885 Lee Tunnel Suite 208",
				PropertyCity = "Port Donna",
				WeekendPrice = 140.73m,
				WeekdayPrice = 228.84m,
				CleaningFee = 17.13m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 7,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p64.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p64.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p64);

			Property p65 = new Property()
			{
				PropertyZip = "03009",
				PropertyState = "NM",
				PropertyAddress = "693 Michael Estate",
				PropertyCity = "Lake Michael",
				WeekendPrice = 139.83m,
				WeekdayPrice = 155.03m,
				CleaningFee = 21.05m,
				PropertyBedroom = 4,
				PropertyBathroom = 5,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p65.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p65.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p65);

			Property p66 = new Property()
			{
				PropertyZip = "92905",
				PropertyState = "NY",
				PropertyAddress = "342 Miller Mission",
				PropertyCity = "Lake Jennifer",
				WeekendPrice = 249.24m,
				WeekdayPrice = 128.41m,
				CleaningFee = 6.63m,
				PropertyBedroom = 4,
				PropertyBathroom = 5,
				PropertyGuest = 1,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p66.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p66.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p66);

			Property p67 = new Property()
			{
				PropertyZip = "65056",
				PropertyState = "AK",
				PropertyAddress = "71664 Kim Throughway",
				PropertyCity = "Chelsealand",
				WeekendPrice = 286.53m,
				WeekdayPrice = 163.68m,
				CleaningFee = 25.57m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 9,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p67.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p67.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p67);

			Property p68 = new Property()
			{
				PropertyZip = "11181",
				PropertyState = "AZ",
				PropertyAddress = "66660 Gomez Port Apt. 945",
				PropertyCity = "South Thomashaven",
				WeekendPrice = 137.17m,
				WeekdayPrice = 93.86m,
				CleaningFee = 28.18m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p68.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p68.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p68);

			Property p69 = new Property()
			{
				PropertyZip = "53480",
				PropertyState = "FL",
				PropertyAddress = "0131 Williams Ville Apt. 562",
				PropertyCity = "Richardberg",
				WeekendPrice = 120.61m,
				WeekdayPrice = 86.25m,
				CleaningFee = 11.39m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p69.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p69.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p69);

			Property p70 = new Property()
			{
				PropertyZip = "11353",
				PropertyState = "OR",
				PropertyAddress = "22708 Madison Spurs",
				PropertyCity = "Herringstad",
				WeekendPrice = 241.25m,
				WeekdayPrice = 182.46m,
				CleaningFee = 18.29m,
				PropertyBedroom = 6,
				PropertyBathroom = 7,
				PropertyGuest = 2,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p70.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p70.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p70);

			Property p71 = new Property()
			{
				PropertyZip = "05560",
				PropertyState = "FL",
				PropertyAddress = "3454 Holmes Motorway",
				PropertyCity = "Port Rachel",
				WeekendPrice = 123.04m,
				WeekdayPrice = 89.88m,
				CleaningFee = 19.14m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 1,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p71.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p71.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p71);

			Property p72 = new Property()
			{
				PropertyZip = "93500",
				PropertyState = "GA",
				PropertyAddress = "805 James Turnpike",
				PropertyCity = "Carrmouth",
				WeekendPrice = 219.86m,
				WeekdayPrice = 81.55m,
				CleaningFee = 13.38m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 12,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p72.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p72.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p72);

			Property p73 = new Property()
			{
				PropertyZip = "44515",
				PropertyState = "NV",
				PropertyAddress = "8081 Smith Trail",
				PropertyCity = "North Ronaldstad",
				WeekendPrice = 196.09m,
				WeekdayPrice = 130.47m,
				CleaningFee = 14.53m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 3,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p73.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p73.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p73);

			Property p74 = new Property()
			{
				PropertyZip = "07347",
				PropertyState = "MS",
				PropertyAddress = "125 Ian Crossroad Apt. 593",
				PropertyCity = "South Deannaport",
				WeekendPrice = 136.82m,
				WeekdayPrice = 148.1m,
				CleaningFee = 15.57m,
				PropertyBedroom = 2,
				PropertyBathroom = 1,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p74.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p74.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p74);

			Property p75 = new Property()
			{
				PropertyZip = "54532",
				PropertyState = "NH",
				PropertyAddress = "1607 Munoz River",
				PropertyCity = "Emilyshire",
				WeekendPrice = 209.77m,
				WeekdayPrice = 147.55m,
				CleaningFee = 27.65m,
				PropertyBedroom = 6,
				PropertyBathroom = 7,
				PropertyGuest = 3,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p75.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p75.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p75);

			Property p76 = new Property()
			{
				PropertyZip = "65516",
				PropertyState = "UT",
				PropertyAddress = "3615 David Keys Apt. 269",
				PropertyCity = "West Stephenside",
				WeekendPrice = 126.47m,
				WeekdayPrice = 86.8m,
				CleaningFee = 17.6m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 3,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p76.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p76.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p76);

			Property p77 = new Property()
			{
				PropertyZip = "20721",
				PropertyState = "AZ",
				PropertyAddress = "640 Mary Common",
				PropertyCity = "Michaelville",
				WeekendPrice = 173.01m,
				WeekdayPrice = 121.75m,
				CleaningFee = 12.53m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 7,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p77.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p77.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p77);

			Property p78 = new Property()
			{
				PropertyZip = "43567",
				PropertyState = "LA",
				PropertyAddress = "395 Timothy Road",
				PropertyCity = "Williamsbury",
				WeekendPrice = 198.1m,
				WeekdayPrice = 160.23m,
				CleaningFee = 10.82m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 5,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p78.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p78.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p78);

			Property p79 = new Property()
			{
				PropertyZip = "01239",
				PropertyState = "OR",
				PropertyAddress = "3267 Walter Dam",
				PropertyCity = "Cunninghamtown",
				WeekendPrice = 127.7m,
				WeekdayPrice = 110.64m,
				CleaningFee = 26.67m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 7,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p79.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p79.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p79);

			Property p80 = new Property()
			{
				PropertyZip = "03966",
				PropertyState = "MS",
				PropertyAddress = "00580 Brandon Creek",
				PropertyCity = "Port Eric",
				WeekendPrice = 236.71m,
				WeekdayPrice = 227.6m,
				CleaningFee = 20.22m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 2,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p80.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p80.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p80);

			Property p81 = new Property()
			{
				PropertyZip = "29996",
				PropertyState = "MS",
				PropertyAddress = "325 Amanda Cliffs Apt. 695",
				PropertyCity = "South Paulabury",
				WeekendPrice = 135.59m,
				WeekdayPrice = 115.37m,
				CleaningFee = 29.8m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p81.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p81.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p81);

			Property p82 = new Property()
			{
				PropertyZip = "93980",
				PropertyState = "CT",
				PropertyAddress = "40956 Amanda Walk Apt. 260",
				PropertyCity = "Simonfurt",
				WeekendPrice = 271.49m,
				WeekdayPrice = 93.35m,
				CleaningFee = 8.54m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 5,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p82.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p82.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p82);

			Property p83 = new Property()
			{
				PropertyZip = "23687",
				PropertyState = "KS",
				PropertyAddress = "25762 Gill Creek Suite 525",
				PropertyCity = "Mccoyton",
				WeekendPrice = 247.15m,
				WeekdayPrice = 171.37m,
				CleaningFee = 17.22m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 5,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p83.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p83.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p83);

			Property p84 = new Property()
			{
				PropertyZip = "04593",
				PropertyState = "GA",
				PropertyAddress = "6048 Johnson Loop Suite 635",
				PropertyCity = "East Daniel",
				WeekendPrice = 299.6m,
				WeekdayPrice = 95.59m,
				CleaningFee = 24.3m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 8,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p84.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p84.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p84);

			Property p85 = new Property()
			{
				PropertyZip = "96954",
				PropertyState = "RI",
				PropertyAddress = "1168 Gary Fords Apt. 308",
				PropertyCity = "Port Trevor",
				WeekendPrice = 278.17m,
				WeekdayPrice = 194.84m,
				CleaningFee = 5.88m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 11,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p85.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p85.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p85);

			Property p86 = new Property()
			{
				PropertyZip = "62271",
				PropertyState = "MS",
				PropertyAddress = "164 Matthew Parkway Suite 826",
				PropertyCity = "Jimmyfurt",
				WeekendPrice = 100.08m,
				WeekdayPrice = 112.03m,
				CleaningFee = 28.82m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 8,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p86.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p86.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p86);

			Property p87 = new Property()
			{
				PropertyZip = "05222",
				PropertyState = "CO",
				PropertyAddress = "1220 Heidi Rue Apt. 998",
				PropertyCity = "West Haleyburgh",
				WeekendPrice = 182.77m,
				WeekdayPrice = 127.97m,
				CleaningFee = 13.02m,
				PropertyBedroom = 5,
				PropertyBathroom = 4,
				PropertyGuest = 1,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p87.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p87.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p87);

			Property p88 = new Property()
			{
				PropertyZip = "22365",
				PropertyState = "SD",
				PropertyAddress = "751 Wood Square Suite 732",
				PropertyCity = "Port Melissaburgh",
				WeekendPrice = 186.01m,
				WeekdayPrice = 120.07m,
				CleaningFee = 26.71m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 13,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p88.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p88.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p88);

			Property p89 = new Property()
			{
				PropertyZip = "53609",
				PropertyState = "OR",
				PropertyAddress = "376 Smith Dale Suite 279",
				PropertyCity = "South Sarahland",
				WeekendPrice = 122.31m,
				WeekdayPrice = 137.96m,
				CleaningFee = 26.29m,
				PropertyBedroom = 2,
				PropertyBathroom = 2,
				PropertyGuest = 9,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p89.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p89.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p89);

			Property p90 = new Property()
			{
				PropertyZip = "09478",
				PropertyState = "CA",
				PropertyAddress = "79148 Pierce Lock Suite 423",
				PropertyCity = "Erikberg",
				WeekendPrice = 234.61m,
				WeekdayPrice = 226.57m,
				CleaningFee = 16.41m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 6,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p90.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p90.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p90);

			Property p91 = new Property()
			{
				PropertyZip = "01425",
				PropertyState = "ID",
				PropertyAddress = "147 Lisa Hill Apt. 512",
				PropertyCity = "Port Elizabethshire",
				WeekendPrice = 145.15m,
				WeekdayPrice = 95.73m,
				CleaningFee = 9.93m,
				PropertyBedroom = 4,
				PropertyBathroom = 6,
				PropertyGuest = 10,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p91.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p91.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p91);

			Property p92 = new Property()
			{
				PropertyZip = "29941",
				PropertyState = "KY",
				PropertyAddress = "971 Hansen Well Suite 103",
				PropertyCity = "South Mary",
				WeekendPrice = 145.72m,
				WeekdayPrice = 161.68m,
				CleaningFee = 24.36m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 4,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p92.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p92.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p92);

			Property p93 = new Property()
			{
				PropertyZip = "47577",
				PropertyState = "WY",
				PropertyAddress = "511 Berry Fork Suite 623",
				PropertyCity = "Sharonfort",
				WeekendPrice = 260.18m,
				WeekdayPrice = 183.81m,
				CleaningFee = 7.46m,
				PropertyBedroom = 4,
				PropertyBathroom = 5,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p93.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p93.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p93);

			Property p94 = new Property()
			{
				PropertyZip = "94134",
				PropertyState = "WI",
				PropertyAddress = "65873 Chen Knolls",
				PropertyCity = "Ramirezfurt",
				WeekendPrice = 117.17m,
				WeekdayPrice = 215.38m,
				CleaningFee = 24.31m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 14,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p94.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p94.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p94);

			Property p95 = new Property()
			{
				PropertyZip = "57039",
				PropertyState = "IN",
				PropertyAddress = "8799 Emma Parkway Suite 735",
				PropertyCity = "North Thomasfurt",
				WeekendPrice = 242.21m,
				WeekdayPrice = 145.51m,
				CleaningFee = 11.89m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 11,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p95.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p95.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p95);

			Property p96 = new Property()
			{
				PropertyZip = "23718",
				PropertyState = "ND",
				PropertyAddress = "30068 David View Apt. 173",
				PropertyCity = "New Peggychester",
				WeekendPrice = 161.21m,
				WeekdayPrice = 142.76m,
				CleaningFee = 20.92m,
				PropertyBedroom = 4,
				PropertyBathroom = 6,
				PropertyGuest = 7,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p96.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p96.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p96);

			Property p97 = new Property()
			{
				PropertyZip = "26932",
				PropertyState = "MD",
				PropertyAddress = "298 Johnathan Cove Apt. 402",
				PropertyCity = "South Jamie",
				WeekendPrice = 176.37m,
				WeekdayPrice = 170.07m,
				CleaningFee = 8.54m,
				PropertyBedroom = 6,
				PropertyBathroom = 7,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p97.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p97.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p97);

			Property p98 = new Property()
			{
				PropertyZip = "74554",
				PropertyState = "CO",
				PropertyAddress = "171 Harrison Motorway",
				PropertyCity = "Davidview",
				WeekendPrice = 234.81m,
				WeekdayPrice = 145.08m,
				CleaningFee = 26.14m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 10,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p98.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p98.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p98);

			Property p99 = new Property()
			{
				PropertyZip = "32097",
				PropertyState = "NE",
				PropertyAddress = "3576 Sergio Avenue",
				PropertyCity = "Benjaminmouth",
				WeekendPrice = 260.62m,
				WeekdayPrice = 111.73m,
				CleaningFee = 15.89m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p99.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p99.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p99);

			Property p100 = new Property()
			{
				PropertyZip = "21519",
				PropertyState = "RI",
				PropertyAddress = "37457 Tanya Pike Apt. 348",
				PropertyCity = "North Ericton",
				WeekendPrice = 214.62m,
				WeekdayPrice = 70.63m,
				CleaningFee = 5.29m,
				PropertyBedroom = 2,
				PropertyBathroom = 1,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p100.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p100.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p100);

			Property p101 = new Property()
			{
				PropertyZip = "76875",
				PropertyState = "PA",
				PropertyAddress = "3673 Peter Turnpike Suite 835",
				PropertyCity = "New Sandra",
				WeekendPrice = 172.79m,
				WeekdayPrice = 229.03m,
				CleaningFee = 14.05m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 6,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p101.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p101.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p101);

			Property p102 = new Property()
			{
				PropertyZip = "80451",
				PropertyState = "TX",
				PropertyAddress = "939 Johnson Oval Suite 830",
				PropertyCity = "North Dennismouth",
				WeekendPrice = 133.53m,
				WeekdayPrice = 169.34m,
				CleaningFee = 18.06m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 6,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p102.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p102.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p102);

			Property p103 = new Property()
			{
				PropertyZip = "51726",
				PropertyState = "NV",
				PropertyAddress = "645 Jennings Estates",
				PropertyCity = "Angelastad",
				WeekendPrice = 109.44m,
				WeekdayPrice = 155.52m,
				CleaningFee = 8.28m,
				PropertyBedroom = 2,
				PropertyBathroom = 3,
				PropertyGuest = 4,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p103.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p103.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p103);

			Property p104 = new Property()
			{
				PropertyZip = "77240",
				PropertyState = "MT",
				PropertyAddress = "1231 Stephanie Lock Suite 835",
				PropertyCity = "North Richardland",
				WeekendPrice = 182.33m,
				WeekdayPrice = 180.2m,
				CleaningFee = 17.78m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 5,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p104.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p104.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p104);

			Property p105 = new Property()
			{
				PropertyZip = "98152",
				PropertyState = "CO",
				PropertyAddress = "302 Parker Plains Apt. 197",
				PropertyCity = "East Robertstad",
				WeekendPrice = 212.7m,
				WeekdayPrice = 212.86m,
				CleaningFee = 6.82m,
				PropertyBedroom = 3,
				PropertyBathroom = 2,
				PropertyGuest = 1,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p105.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p105.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p105);

			Property p106 = new Property()
			{
				PropertyZip = "98277",
				PropertyState = "MS",
				PropertyAddress = "098 Hernandez Green",
				PropertyCity = "New Sergiobury",
				WeekendPrice = 262.3m,
				WeekdayPrice = 188.71m,
				CleaningFee = 21.88m,
				PropertyBedroom = 4,
				PropertyBathroom = 6,
				PropertyGuest = 8,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p106.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p106.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p106);

			Property p107 = new Property()
			{
				PropertyZip = "80082",
				PropertyState = "NE",
				PropertyAddress = "94102 Sims Port Suite 187",
				PropertyCity = "Florestown",
				WeekendPrice = 128.05m,
				WeekdayPrice = 83.34m,
				CleaningFee = 11.29m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 8,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p107.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p107.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p107);

			Property p108 = new Property()
			{
				PropertyZip = "71531",
				PropertyState = "ND",
				PropertyAddress = "01630 Baker Crescent",
				PropertyCity = "Kellyborough",
				WeekendPrice = 125.27m,
				WeekdayPrice = 204.02m,
				CleaningFee = 21.15m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 4,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p108.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p108.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p108);

			Property p109 = new Property()
			{
				PropertyZip = "14157",
				PropertyState = "OK",
				PropertyAddress = "70452 Forbes Courts",
				PropertyCity = "Mosesland",
				WeekendPrice = 172.1m,
				WeekdayPrice = 90.98m,
				CleaningFee = 18.09m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p109.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p109.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p109);

			Property p110 = new Property()
			{
				PropertyZip = "26899",
				PropertyState = "MO",
				PropertyAddress = "0835 Angela Station",
				PropertyCity = "East Heather",
				WeekendPrice = 299.91m,
				WeekdayPrice = 158.64m,
				CleaningFee = 23.09m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p110.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p110.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p110);

			Property p111 = new Property()
			{
				PropertyZip = "42872",
				PropertyState = "VT",
				PropertyAddress = "2458 Jason Village Suite 248",
				PropertyCity = "North Donnamouth",
				WeekendPrice = 189.3m,
				WeekdayPrice = 107.97m,
				CleaningFee = 9.05m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p111.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p111.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p111);

			Property p112 = new Property()
			{
				PropertyZip = "78301",
				PropertyState = "CO",
				PropertyAddress = "1243 Grimes Corners",
				PropertyCity = "Shawchester",
				WeekendPrice = 193.24m,
				WeekdayPrice = 214.14m,
				CleaningFee = 26.1m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 2,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p112.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p112.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p112);

			Property p113 = new Property()
			{
				PropertyZip = "34523",
				PropertyState = "DC",
				PropertyAddress = "558 Williams Station",
				PropertyCity = "Port Pamela",
				WeekendPrice = 192.46m,
				WeekdayPrice = 106.3m,
				CleaningFee = 17.59m,
				PropertyBedroom = 6,
				PropertyBathroom = 7,
				PropertyGuest = 4,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p113.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p113.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p113);

			Property p114 = new Property()
			{
				PropertyZip = "63064",
				PropertyState = "VT",
				PropertyAddress = "4934 Lozano Place Suite 716",
				PropertyCity = "Gavinton",
				WeekendPrice = 257.37m,
				WeekdayPrice = 116.99m,
				CleaningFee = 5.63m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 6,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p114.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p114.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p114);

			Property p115 = new Property()
			{
				PropertyZip = "35700",
				PropertyState = "LA",
				PropertyAddress = "41227 Patricia Lake",
				PropertyCity = "Martinezbury",
				WeekendPrice = 108.28m,
				WeekdayPrice = 203.03m,
				CleaningFee = 11.35m,
				PropertyBedroom = 2,
				PropertyBathroom = 1,
				PropertyGuest = 3,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p115.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p115.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p115);

			Property p116 = new Property()
			{
				PropertyZip = "55206",
				PropertyState = "VA",
				PropertyAddress = "028 Harris Drive Apt. 422",
				PropertyCity = "Amyburgh",
				WeekendPrice = 262.77m,
				WeekdayPrice = 163.3m,
				CleaningFee = 13.74m,
				PropertyBedroom = 2,
				PropertyBathroom = 2,
				PropertyGuest = 14,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p116.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p116.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p116);

			Property p117 = new Property()
			{
				PropertyZip = "98240",
				PropertyState = "IA",
				PropertyAddress = "06268 Lewis Place Suite 121",
				PropertyCity = "Port Patriciatown",
				WeekendPrice = 108.52m,
				WeekdayPrice = 156.25m,
				CleaningFee = 23.66m,
				PropertyBedroom = 3,
				PropertyBathroom = 2,
				PropertyGuest = 4,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p117.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p117.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p117);

			Property p118 = new Property()
			{
				PropertyZip = "87205",
				PropertyState = "WI",
				PropertyAddress = "5641 Brenda Streets Apt. 008",
				PropertyCity = "Lake Seanmouth",
				WeekendPrice = 153.42m,
				WeekdayPrice = 178.27m,
				CleaningFee = 24.69m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 12,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p118.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p118.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p118);

			Property p119 = new Property()
			{
				PropertyZip = "58221",
				PropertyState = "ME",
				PropertyAddress = "92555 Shaw Spurs Suite 207",
				PropertyCity = "New Randy",
				WeekendPrice = 184.92m,
				WeekdayPrice = 92.51m,
				CleaningFee = 12.82m,
				PropertyBedroom = 7,
				PropertyBathroom = 8,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p119.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p119.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p119);

			Property p120 = new Property()
			{
				PropertyZip = "18885",
				PropertyState = "NY",
				PropertyAddress = "559 Foster Locks Suite 933",
				PropertyCity = "Robinsonhaven",
				WeekendPrice = 225.85m,
				WeekdayPrice = 224.62m,
				CleaningFee = 17.9m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 6,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p120.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p120.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p120);

			Property p121 = new Property()
			{
				PropertyZip = "00638",
				PropertyState = "WY",
				PropertyAddress = "4647 Kristine Fields Suite 710",
				PropertyCity = "New Dakota",
				WeekendPrice = 174.02m,
				WeekdayPrice = 112.61m,
				CleaningFee = 17.48m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 10,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p121.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p121.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p121);

			Property p122 = new Property()
			{
				PropertyZip = "31451",
				PropertyState = "ME",
				PropertyAddress = "92594 Emily Shoals",
				PropertyCity = "North Cathyburgh",
				WeekendPrice = 119.06m,
				WeekdayPrice = 189.98m,
				CleaningFee = 25.11m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p122.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p122.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p122);

			Property p123 = new Property()
			{
				PropertyZip = "26297",
				PropertyState = "MS",
				PropertyAddress = "551 Casey Squares Apt. 209",
				PropertyCity = "Michaelborough",
				WeekendPrice = 114.73m,
				WeekdayPrice = 72.03m,
				CleaningFee = 18.38m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 6,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p123.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p123.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p123);

			Property p124 = new Property()
			{
				PropertyZip = "04610",
				PropertyState = "PA",
				PropertyAddress = "2998 Willis Wall",
				PropertyCity = "North Brian",
				WeekendPrice = 144.51m,
				WeekdayPrice = 216.21m,
				CleaningFee = 10.81m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p124.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p124.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p124);

			Property p125 = new Property()
			{
				PropertyZip = "86618",
				PropertyState = "MD",
				PropertyAddress = "164 Schultz Road",
				PropertyCity = "Lake Bryan",
				WeekendPrice = 233.9m,
				WeekdayPrice = 132.69m,
				CleaningFee = 15.8m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p125.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p125.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p125);

			Property p126 = new Property()
			{
				PropertyZip = "80124",
				PropertyState = "GA",
				PropertyAddress = "9541 Brock Estate Apt. 848",
				PropertyCity = "Franklinchester",
				WeekendPrice = 285.05m,
				WeekdayPrice = 220.97m,
				CleaningFee = 20.98m,
				PropertyBedroom = 2,
				PropertyBathroom = 1,
				PropertyGuest = 9,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p126.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p126.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p126);

			Property p127 = new Property()
			{
				PropertyZip = "63590",
				PropertyState = "MS",
				PropertyAddress = "588 Alan Rest",
				PropertyCity = "Port Stephanieville",
				WeekendPrice = 180.86m,
				WeekdayPrice = 224.98m,
				CleaningFee = 11.91m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p127.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p127.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p127);

			Property p128 = new Property()
			{
				PropertyZip = "53548",
				PropertyState = "MT",
				PropertyAddress = "216 Brandon Loop Apt. 096",
				PropertyCity = "New Jessica",
				WeekendPrice = 239.97m,
				WeekdayPrice = 221.98m,
				CleaningFee = 9.24m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 12,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p128.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p128.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p128);

			Property p129 = new Property()
			{
				PropertyZip = "35611",
				PropertyState = "LA",
				PropertyAddress = "782 Dawn Radial",
				PropertyCity = "Port Christopher",
				WeekendPrice = 297.25m,
				WeekdayPrice = 76.56m,
				CleaningFee = 20.42m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 1,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p129.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p129.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p129);

			Property p130 = new Property()
			{
				PropertyZip = "42879",
				PropertyState = "WA",
				PropertyAddress = "008 Nancy Route Suite 228",
				PropertyCity = "North Stephanie",
				WeekendPrice = 129.36m,
				WeekdayPrice = 128.71m,
				CleaningFee = 23.76m,
				PropertyBedroom = 2,
				PropertyBathroom = 3,
				PropertyGuest = 3,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p130.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p130.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p130);

			Property p131 = new Property()
			{
				PropertyZip = "71569",
				PropertyState = "MO",
				PropertyAddress = "115 Jon Isle Suite 788",
				PropertyCity = "North Lesliefurt",
				WeekendPrice = 210.63m,
				WeekdayPrice = 114.21m,
				CleaningFee = 21.08m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 9,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p131.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p131.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p131);

			Property p132 = new Property()
			{
				PropertyZip = "87566",
				PropertyState = "DE",
				PropertyAddress = "132 Poole Pass Suite 212",
				PropertyCity = "North Patrick",
				WeekendPrice = 280.37m,
				WeekdayPrice = 146.82m,
				CleaningFee = 26.78m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 11,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p132.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p132.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p132);

			Property p133 = new Property()
			{
				PropertyZip = "67652",
				PropertyState = "WY",
				PropertyAddress = "457 Vargas Island Suite 853",
				PropertyCity = "Lake Patrickstad",
				WeekendPrice = 249.39m,
				WeekdayPrice = 134.72m,
				CleaningFee = 19.19m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p133.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p133.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p133);

			Property p134 = new Property()
			{
				PropertyZip = "45184",
				PropertyState = "HI",
				PropertyAddress = "1569 Amy Path",
				PropertyCity = "North Ashleyton",
				WeekendPrice = 111.23m,
				WeekdayPrice = 111.6m,
				CleaningFee = 13.48m,
				PropertyBedroom = 7,
				PropertyBathroom = 8,
				PropertyGuest = 7,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p134.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p134.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p134);

			Property p135 = new Property()
			{
				PropertyZip = "04078",
				PropertyState = "IL",
				PropertyAddress = "0375 Sandra Trace Suite 826",
				PropertyCity = "Gailshire",
				WeekendPrice = 168.47m,
				WeekdayPrice = 89m,
				CleaningFee = 14.93m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 3,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p135.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p135.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p135);

			Property p136 = new Property()
			{
				PropertyZip = "50437",
				PropertyState = "MN",
				PropertyAddress = "759 Good Port",
				PropertyCity = "New Russell",
				WeekendPrice = 208.35m,
				WeekdayPrice = 208.64m,
				CleaningFee = 7.09m,
				PropertyBedroom = 5,
				PropertyBathroom = 5,
				PropertyGuest = 6,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p136.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p136.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p136);

			Property p137 = new Property()
			{
				PropertyZip = "34147",
				PropertyState = "WV",
				PropertyAddress = "3895 Allen Junction",
				PropertyCity = "West John",
				WeekendPrice = 195.41m,
				WeekdayPrice = 172.51m,
				CleaningFee = 21.53m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p137.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p137.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p137);

			Property p138 = new Property()
			{
				PropertyZip = "36340",
				PropertyState = "MS",
				PropertyAddress = "7329 Jacobs Station",
				PropertyCity = "New Tylerborough",
				WeekendPrice = 146.12m,
				WeekdayPrice = 163.15m,
				CleaningFee = 18.98m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 8,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p138.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p138.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p138);

			Property p139 = new Property()
			{
				PropertyZip = "88806",
				PropertyState = "MD",
				PropertyAddress = "5003 Cassandra Estates Suite 148",
				PropertyCity = "Haleychester",
				WeekendPrice = 161.49m,
				WeekdayPrice = 81.5m,
				CleaningFee = 16.41m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p139.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p139.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p139);

			Property p140 = new Property()
			{
				PropertyZip = "76853",
				PropertyState = "TN",
				PropertyAddress = "10524 Parker Mall Suite 531",
				PropertyCity = "Port Courtneyhaven",
				WeekendPrice = 120.73m,
				WeekdayPrice = 177.94m,
				CleaningFee = 9.5m,
				PropertyBedroom = 5,
				PropertyBathroom = 7,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p140.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p140.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
			Properties.Add(p140);

			Property p141 = new Property()
			{
				PropertyZip = "93533",
				PropertyState = "MO",
				PropertyAddress = "300 Madison Stream",
				PropertyCity = "Christophershire",
				WeekendPrice = 187.08m,
				WeekdayPrice = 121.01m,
				CleaningFee = 16.48m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 6,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p141.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p141.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p141);

			Property p142 = new Property()
			{
				PropertyZip = "96763",
				PropertyState = "FL",
				PropertyAddress = "4229 Derrick Wells",
				PropertyCity = "West Tyler",
				WeekendPrice = 241.45m,
				WeekdayPrice = 199.68m,
				CleaningFee = 25.94m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 6,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p142.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p142.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p142);

			Property p143 = new Property()
			{
				PropertyZip = "92174",
				PropertyState = "VA",
				PropertyAddress = "26239 Michael Shoals",
				PropertyCity = "Gregoryview",
				WeekendPrice = 111.91m,
				WeekdayPrice = 162.01m,
				CleaningFee = 14.35m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 9,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p143.User = db.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
			p143.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p143);

			Property p144 = new Property()
			{
				PropertyZip = "88294",
				PropertyState = "IN",
				PropertyAddress = "302 Joy Spring Apt. 622",
				PropertyCity = "Ryanhaven",
				WeekendPrice = 163.73m,
				WeekdayPrice = 173.36m,
				CleaningFee = 25.35m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 12,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p144.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p144.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p144);

			Property p145 = new Property()
			{
				PropertyZip = "23464",
				PropertyState = "CA",
				PropertyAddress = "734 Craig Overpass Suite 589",
				PropertyCity = "Jefferyside",
				WeekendPrice = 287.28m,
				WeekdayPrice = 216.1m,
				CleaningFee = 22.2m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 8,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p145.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p145.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p145);

			Property p146 = new Property()
			{
				PropertyZip = "35243",
				PropertyState = "CA",
				PropertyAddress = "272 Green Street",
				PropertyCity = "Port Lacey",
				WeekendPrice = 247.34m,
				WeekdayPrice = 211.51m,
				CleaningFee = 11.73m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 7,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p146.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p146.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p146);

			Property p147 = new Property()
			{
				PropertyZip = "61935",
				PropertyState = "IL",
				PropertyAddress = "8056 Dunn Trail Apt. 049",
				PropertyCity = "Blackshire",
				WeekendPrice = 189.08m,
				WeekdayPrice = 111.4m,
				CleaningFee = 19.58m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p147.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p147.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p147);

			Property p148 = new Property()
			{
				PropertyZip = "72324",
				PropertyState = "CA",
				PropertyAddress = "86187 Antonio Fort",
				PropertyCity = "North Carmen",
				WeekendPrice = 109.87m,
				WeekdayPrice = 150.69m,
				CleaningFee = 13.3m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 7,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p148.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p148.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p148);

			Property p149 = new Property()
			{
				PropertyZip = "84393",
				PropertyState = "NJ",
				PropertyAddress = "71318 Cassandra Plaza",
				PropertyCity = "Burkeview",
				WeekendPrice = 227.55m,
				WeekdayPrice = 184.21m,
				CleaningFee = 19.52m,
				PropertyBedroom = 7,
				PropertyBathroom = 7,
				PropertyGuest = 10,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p149.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p149.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p149);

			Property p150 = new Property()
			{
				PropertyZip = "62346",
				PropertyState = "NH",
				PropertyAddress = "5303 Lewis Springs",
				PropertyCity = "Port Adrian",
				WeekendPrice = 207.51m,
				WeekdayPrice = 204.67m,
				CleaningFee = 26.36m,
				PropertyBedroom = 2,
				PropertyBathroom = 1,
				PropertyGuest = 2,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p150.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p150.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p150);

			Property p151 = new Property()
			{
				PropertyZip = "02837",
				PropertyState = "IA",
				PropertyAddress = "465 Wiley Corners Apt. 759",
				PropertyCity = "East Michellechester",
				WeekendPrice = 213.84m,
				WeekdayPrice = 129.14m,
				CleaningFee = 12.81m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 11,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p151.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p151.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p151);

			Property p152 = new Property()
			{
				PropertyZip = "68847",
				PropertyState = "LA",
				PropertyAddress = "521 Flores Stream",
				PropertyCity = "West Rebeccaborough",
				WeekendPrice = 254.37m,
				WeekdayPrice = 77.06m,
				CleaningFee = 6.03m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 3,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p152.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p152.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p152);

			Property p153 = new Property()
			{
				PropertyZip = "35218",
				PropertyState = "NE",
				PropertyAddress = "0271 Soto Drives Apt. 975",
				PropertyCity = "New Edgar",
				WeekendPrice = 233.17m,
				WeekdayPrice = 179.91m,
				CleaningFee = 11.04m,
				PropertyBedroom = 4,
				PropertyBathroom = 5,
				PropertyGuest = 9,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p153.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p153.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p153);

			Property p154 = new Property()
			{
				PropertyZip = "32697",
				PropertyState = "NM",
				PropertyAddress = "27862 Kent Mountains",
				PropertyCity = "Lake Michaelville",
				WeekendPrice = 153.38m,
				WeekdayPrice = 90.54m,
				CleaningFee = 6.91m,
				PropertyBedroom = 6,
				PropertyBathroom = 5,
				PropertyGuest = 14,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p154.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p154.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p154);

			Property p155 = new Property()
			{
				PropertyZip = "95889",
				PropertyState = "OR",
				PropertyAddress = "917 Mclaughlin Glens",
				PropertyCity = "Martinville",
				WeekendPrice = 226.89m,
				WeekdayPrice = 225.59m,
				CleaningFee = 28.99m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 2,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p155.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p155.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p155);

			Property p156 = new Property()
			{
				PropertyZip = "82153",
				PropertyState = "KY",
				PropertyAddress = "3032 Michelle Drives",
				PropertyCity = "North Daniel",
				WeekendPrice = 157.15m,
				WeekdayPrice = 203.25m,
				CleaningFee = 15.68m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 13,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p156.User = db.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
			p156.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p156);

			Property p157 = new Property()
			{
				PropertyZip = "32202",
				PropertyState = "SD",
				PropertyAddress = "601 Maria Mission Apt. 554",
				PropertyCity = "Myerstown",
				WeekendPrice = 269.55m,
				WeekdayPrice = 223.27m,
				CleaningFee = 11.35m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 9,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p157.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p157.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p157);

			Property p158 = new Property()
			{
				PropertyZip = "17431",
				PropertyState = "OH",
				PropertyAddress = "238 Shawn Well",
				PropertyCity = "Port Johnshire",
				WeekendPrice = 112.64m,
				WeekdayPrice = 173.63m,
				CleaningFee = 6.38m,
				PropertyBedroom = 7,
				PropertyBathroom = 8,
				PropertyGuest = 14,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p158.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p158.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p158);

			Property p159 = new Property()
			{
				PropertyZip = "37901",
				PropertyState = "SC",
				PropertyAddress = "41743 Berger Inlet Apt. 527",
				PropertyCity = "South Tammymouth",
				WeekendPrice = 163.2m,
				WeekdayPrice = 176.23m,
				CleaningFee = 14.77m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p159.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p159.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p159);

			Property p160 = new Property()
			{
				PropertyZip = "17895",
				PropertyState = "MO",
				PropertyAddress = "9983 Mary Grove Apt. 643",
				PropertyCity = "Beardview",
				WeekendPrice = 209.33m,
				WeekdayPrice = 219.53m,
				CleaningFee = 24.51m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p160.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p160.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p160);

			Property p161 = new Property()
			{
				PropertyZip = "90576",
				PropertyState = "HI",
				PropertyAddress = "03541 Ryan Islands Apt. 562",
				PropertyCity = "East Michaelfort",
				WeekendPrice = 269.63m,
				WeekdayPrice = 126.25m,
				CleaningFee = 8.27m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 10,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p161.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p161.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p161);

			Property p162 = new Property()
			{
				PropertyZip = "94980",
				PropertyState = "SC",
				PropertyAddress = "6591 Angela Mission Apt. 108",
				PropertyCity = "Penabury",
				WeekendPrice = 286.86m,
				WeekdayPrice = 143.98m,
				CleaningFee = 20.48m,
				PropertyBedroom = 5,
				PropertyBathroom = 6,
				PropertyGuest = 14,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p162.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p162.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p162);

			Property p163 = new Property()
			{
				PropertyZip = "44974",
				PropertyState = "CO",
				PropertyAddress = "492 Ramirez Crossing",
				PropertyCity = "Aaronberg",
				WeekendPrice = 144.6m,
				WeekdayPrice = 121.91m,
				CleaningFee = 10.12m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 10,
				Pets = false,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p163.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p163.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p163);

			Property p164 = new Property()
			{
				PropertyZip = "66170",
				PropertyState = "DE",
				PropertyAddress = "35974 Sharon Locks Apt. 101",
				PropertyCity = "Jennyport",
				WeekendPrice = 114.46m,
				WeekdayPrice = 137.8m,
				CleaningFee = 17.74m,
				PropertyBedroom = 7,
				PropertyBathroom = 9,
				PropertyGuest = 1,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p164.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p164.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p164);

			Property p165 = new Property()
			{
				PropertyZip = "22495",
				PropertyState = "UT",
				PropertyAddress = "89403 Gabriella Mills",
				PropertyCity = "East Steven",
				WeekendPrice = 155.1m,
				WeekdayPrice = 128.63m,
				CleaningFee = 23.05m,
				PropertyBedroom = 3,
				PropertyBathroom = 4,
				PropertyGuest = 11,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p165.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p165.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p165);

			Property p166 = new Property()
			{
				PropertyZip = "85059",
				PropertyState = "NH",
				PropertyAddress = "601 Kyle Roads",
				PropertyCity = "Clarkfurt",
				WeekendPrice = 284.39m,
				WeekdayPrice = 209.11m,
				CleaningFee = 6.25m,
				PropertyBedroom = 4,
				PropertyBathroom = 5,
				PropertyGuest = 4,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p166.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p166.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p166);

			Property p167 = new Property()
			{
				PropertyZip = "61092",
				PropertyState = "IN",
				PropertyAddress = "60969 Justin Passage Suite 774",
				PropertyCity = "Joshuaburgh",
				WeekendPrice = 121m,
				WeekdayPrice = 128.59m,
				CleaningFee = 19.36m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 7,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p167.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p167.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p167);

			Property p168 = new Property()
			{
				PropertyZip = "43986",
				PropertyState = "PA",
				PropertyAddress = "7943 Tina Mount",
				PropertyCity = "East Lisa",
				WeekendPrice = 104.47m,
				WeekdayPrice = 122.88m,
				CleaningFee = 25.31m,
				PropertyBedroom = 4,
				PropertyBathroom = 3,
				PropertyGuest = 14,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p168.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p168.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p168);

			Property p169 = new Property()
			{
				PropertyZip = "91397",
				PropertyState = "NC",
				PropertyAddress = "6775 James Ford",
				PropertyCity = "South Victorialand",
				WeekendPrice = 275.5m,
				WeekdayPrice = 211.24m,
				CleaningFee = 15.74m,
				PropertyBedroom = 1,
				PropertyBathroom = 3,
				PropertyGuest = 9,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p169.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p169.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p169);

			Property p170 = new Property()
			{
				PropertyZip = "67849",
				PropertyState = "VT",
				PropertyAddress = "431 Johnson Neck Suite 039",
				PropertyCity = "Mariechester",
				WeekendPrice = 126.24m,
				WeekdayPrice = 124.65m,
				CleaningFee = 24.3m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p170.User = db.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
			p170.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p170);

			Property p171 = new Property()
			{
				PropertyZip = "20687",
				PropertyState = "NM",
				PropertyAddress = "15666 Justin Locks",
				PropertyCity = "Lake Ryanport",
				WeekendPrice = 112.05m,
				WeekdayPrice = 70.11m,
				CleaningFee = 27.45m,
				PropertyBedroom = 6,
				PropertyBathroom = 6,
				PropertyGuest = 3,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p171.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p171.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p171);

			Property p172 = new Property()
			{
				PropertyZip = "30222",
				PropertyState = "TX",
				PropertyAddress = "9947 Torres Viaduct Apt. 506",
				PropertyCity = "Benjaminport",
				WeekendPrice = 152.09m,
				WeekdayPrice = 174.87m,
				CleaningFee = 18.44m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 11,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p172.User = db.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
			p172.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
			Properties.Add(p172);

			Property p173 = new Property()
			{
				PropertyZip = "21190",
				PropertyState = "NJ",
				PropertyAddress = "20866 Keith Mill",
				PropertyCity = "Susanton",
				WeekendPrice = 174.06m,
				WeekdayPrice = 96.8m,
				CleaningFee = 28.15m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 10,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p173.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p173.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p173);

			Property p174 = new Property()
			{
				PropertyZip = "04838",
				PropertyState = "AL",
				PropertyAddress = "04374 Nicholas Cliff Suite 001",
				PropertyCity = "Adrianport",
				WeekendPrice = 108.24m,
				WeekdayPrice = 205.01m,
				CleaningFee = 6.56m,
				PropertyBedroom = 1,
				PropertyBathroom = 1,
				PropertyGuest = 10,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p174.User = db.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
			p174.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
			Properties.Add(p174);

			Property p175 = new Property()
			{
				PropertyZip = "80130",
				PropertyState = "CA",
				PropertyAddress = "271 Andrew Summit",
				PropertyCity = "Port Craig",
				WeekendPrice = 148.39m,
				WeekdayPrice = 197.52m,
				CleaningFee = 20.55m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 7,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p175.User = db.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
			p175.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p175);

			Property p176 = new Property()
			{
				PropertyZip = "96166",
				PropertyState = "MN",
				PropertyAddress = "17611 Robbins Mission",
				PropertyCity = "New Curtis",
				WeekendPrice = 286.13m,
				WeekdayPrice = 219.69m,
				CleaningFee = 10.64m,
				PropertyBedroom = 3,
				PropertyBathroom = 3,
				PropertyGuest = 9,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p176.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p176.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p176);

			Property p177 = new Property()
			{
				PropertyZip = "40702",
				PropertyState = "MO",
				PropertyAddress = "80831 Kemp Pines",
				PropertyCity = "Annashire",
				WeekendPrice = 123.93m,
				WeekdayPrice = 91.26m,
				CleaningFee = 19.36m,
				PropertyBedroom = 1,
				PropertyBathroom = 2,
				PropertyGuest = 7,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p177.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p177.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p177);

			Property p178 = new Property()
			{
				PropertyZip = "86023",
				PropertyState = "IL",
				PropertyAddress = "96545 Smith Alley",
				PropertyCity = "West Joy",
				WeekendPrice = 254.38m,
				WeekdayPrice = 132.54m,
				CleaningFee = 14.83m,
				PropertyBedroom = 6,
				PropertyBathroom = 8,
				PropertyGuest = 7,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p178.User = db.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
			p178.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p178);

			Property p179 = new Property()
			{
				PropertyZip = "70897",
				PropertyState = "MT",
				PropertyAddress = "6146 Johnson Isle",
				PropertyCity = "South Arthur",
				WeekendPrice = 228.04m,
				WeekdayPrice = 227.96m,
				CleaningFee = 6.99m,
				PropertyBedroom = 2,
				PropertyBathroom = 4,
				PropertyGuest = 1,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p179.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p179.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p179);

			Property p180 = new Property()
			{
				PropertyZip = "69154",
				PropertyState = "MN",
				PropertyAddress = "0415 Smith Springs",
				PropertyCity = "Jeremyburgh",
				WeekendPrice = 228.81m,
				WeekdayPrice = 140.93m,
				CleaningFee = 29.74m,
				PropertyBedroom = 4,
				PropertyBathroom = 4,
				PropertyGuest = 3,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p180.User = db.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
			p180.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p180);

			Property p181 = new Property()
			{
				PropertyZip = "53524",
				PropertyState = "HI",
				PropertyAddress = "3999 Ricky Via",
				PropertyCity = "West Adamburgh",
				WeekendPrice = 255.43m,
				WeekdayPrice = 137.35m,
				CleaningFee = 16.62m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 6,
				Pets = true,
				Parking = true,
				PropertyStatus = PropertyStatus.Activated
			};
			p181.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p181.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "House");
			Properties.Add(p181);

			Property p182 = new Property()
			{
				PropertyZip = "24886",
				PropertyState = "MN",
				PropertyAddress = "83787 Stuart Key",
				PropertyCity = "Davetown",
				WeekendPrice = 146.75m,
				WeekdayPrice = 172.99m,
				CleaningFee = 26.24m,
				PropertyBedroom = 7,
				PropertyBathroom = 6,
				PropertyGuest = 4,
				Pets = true,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p182.User = db.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
			p182.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p182);

			Property p183 = new Property()
			{
				PropertyZip = "56713",
				PropertyState = "TX",
				PropertyAddress = "690 Christina Park",
				PropertyCity = "Toddburgh",
				WeekendPrice = 157.96m,
				WeekdayPrice = 188.53m,
				CleaningFee = 6.69m,
				PropertyBedroom = 3,
				PropertyBathroom = 5,
				PropertyGuest = 1,
				Pets = false,
				Parking = false,
				PropertyStatus = PropertyStatus.Activated
			};
			p183.User = db.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
			p183.Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
			Properties.Add(p183);


			try
			{
				foreach (Property propertyToAdd in Properties)
				{
					strPropertyAddress = propertyToAdd.PropertyAddress;
					Property dbProperty = db.Properties.FirstOrDefault(p => p.PropertyAddress == propertyToAdd.PropertyAddress);
					if (dbProperty == null)
					{
						db.Properties.Add(propertyToAdd);
						db.SaveChanges();
						intPropertiesAdded += 1;
					}
					else
					{
						dbProperty.PropertyAddress = propertyToAdd.PropertyAddress;
						dbProperty.PropertyZip = propertyToAdd.PropertyZip;
						dbProperty.PropertyState = propertyToAdd.PropertyState;
						dbProperty.PropertyCity = propertyToAdd.PropertyCity;
						dbProperty.WeekdayPrice = propertyToAdd.WeekdayPrice;
						dbProperty.Pets = propertyToAdd.Pets;
						dbProperty.Parking = propertyToAdd.Parking;
						dbProperty.CleaningFee = propertyToAdd.CleaningFee;
						dbProperty.PropertyBedroom = propertyToAdd.PropertyBedroom;
						dbProperty.PropertyBathroom = propertyToAdd.PropertyBathroom;
						dbProperty.PropertyGuest = propertyToAdd.PropertyGuest;
						dbProperty.Category = propertyToAdd.Category;
						db.Update(dbProperty);
						db.SaveChanges();
						intPropertiesAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:" + intPropertiesAdded + "; Error on " + strPropertyAddress;
				throw new InvalidOperationException(ex.Message + msg);
			}
		}
		catch (Exception e)
		{
			throw new InvalidOperationException(e.Message);
		}
	}
}
}
