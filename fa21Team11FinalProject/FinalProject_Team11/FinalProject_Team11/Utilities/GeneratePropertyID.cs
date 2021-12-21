using FinalProject_Team11.DAL;
using System;
using System.Linq;

namespace FinalProject_Team11.Utilities
{
    public static class GeneratePropertyID
    {
        public static Int32 GetNextPropertyID(AppDbContext _context)
        {
            //Set a number where the Property numbers should start
            const Int32 START_ID = 3001;

            Int32 intMaxPropertyID; //the current maximum Property number
            Int32 intNextPropertyID; //the Property number for the next class

            if (_context.Properties.Count() == 0) //there are no Propertys in the database yet
            {
                intMaxPropertyID = START_ID; //Property numbers start at 3001
            }
            else
            {
                intMaxPropertyID = _context.Properties.Max(c => c.PropertyID); //this is the highest number in the database right now
            }

            //You added Propertys before you realized that you needed this code
            //and now you have some Property numbers less than 3000
            if (intMaxPropertyID < START_ID)
            {
                intMaxPropertyID = START_ID;
            }

            //add one to the current max to find the next one
            intNextPropertyID = intMaxPropertyID + 1;

            //return the value
            return intNextPropertyID;
        }

    }
}