using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication.CustomExceptions
{
    public class LowerThanMinQuantityException: Exception
    {

        public LowerThanMinQuantityException(string productname):
            base($"{productname}'s warehouse amount can't be lower than its minimum quantity!")
        {

        }
    }
}
