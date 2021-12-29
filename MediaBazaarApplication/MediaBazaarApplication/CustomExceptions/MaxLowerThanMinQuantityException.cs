using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication.CustomExceptions
{
    public class MaxLowerThanMinQuantityException : Exception
    {

        public MaxLowerThanMinQuantityException(string productname) :
            base($"{productname}'s maximum quantity can't be lower than its minimum quantity!")
        {

        }
    }
}
