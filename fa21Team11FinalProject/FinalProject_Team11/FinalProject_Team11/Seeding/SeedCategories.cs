using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

//TODO: Update these using statements to include your project name
using FinalProject_Team11.Models;
using FinalProject_Team11.Utilities;
using FinalProject_Team11.DAL;
using System.Threading.Tasks;
using System.Linq;

namespace FinalProject_Team11.Seeding
{
	public static class SeedCategories
	{
		public static void SeedAllCategory(AppDbContext db)
		{
			if (db.Categories.Count() == 5)
			{
				throw new NotSupportedException("The database already contains all 5 categories!");
			}

			Int32 intCategoriesAdded = 0;
			String strCategoryName = "Begin"; //helps to keep track of error on categories


			try
			{
				List<Category> Categories = new List<Category>();

				Category c1 = new Category()
				{
					CategoryName = "House"
				};
				Categories.Add(c1);

				Category c2 = new Category()
				{
					CategoryName = "Cabin"
				};
				Categories.Add(c2);

				Category c3 = new Category()
				{
					CategoryName = "Apartment"
				};
				Categories.Add(c3);

				Category c4 = new Category()
				{
					CategoryName = "Condo"
				};
				Categories.Add(c4);

				Category c5 = new Category()
				{
					CategoryName = "Hotel"
				};
				Categories.Add(c5);
				foreach (Category categoryToAdd in Categories)
				{
					strCategoryName = categoryToAdd.CategoryName;
					Category dbCategory = db.Categories.FirstOrDefault(c => c.CategoryName == categoryToAdd.CategoryName);
					if (dbCategory == null)
					{
						db.Categories.Add(categoryToAdd);
						db.SaveChanges();
						intCategoriesAdded += 1;
					}
					else
					{
						dbCategory.CategoryName = categoryToAdd.CategoryName;
						db.Update(dbCategory);
						db.SaveChanges();
						intCategoriesAdded += 1;
					}
				}
			}
			catch (Exception ex)
			{
				String msg = "Repositories added:" + intCategoriesAdded + "; Error on " + strCategoryName;
				throw new InvalidOperationException(ex.Message + msg);
			}

		}
	}
}


