using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Helper
    {
        /// <summary>
        /// Returns the animals current age.
        /// </summary>
        /// <param name="BirthYear"></param>
        /// <returns></returns>
        public static int GetMyAge(int BirthYear)
        {
            // Set a variable to the current year
            var CurentYear = DateTime.Now.Year;
            // Do the math
            var result = CurentYear - BirthYear;
            // Return result
            return result;
        }
    }
}