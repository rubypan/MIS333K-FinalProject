using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_Team11.Models
{
    public class Category
    {
        public Int32 CategoryID { get; set; }

        [Display(Name = "Category")]
        public String CategoryName { get; set; }

        //navigational property for books - a single category will be associated with many properties
        public List<Property> Properties { get; set; }

        public Category()
        {
            if (Properties == null)
            {
                Properties = new List<Property>();
            }
        }

        internal void Add(Category dbCategory)
        {
            throw new NotImplementedException();
        }
    }
}
