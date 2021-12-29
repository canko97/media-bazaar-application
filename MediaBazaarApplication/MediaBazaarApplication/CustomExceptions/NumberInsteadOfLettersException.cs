using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication.CustomExceptions
{
    public class NumberInsteadOfLettersException: Exception
    {
        public NumberInsteadOfLettersException(string productname, string wrongobject):
            base($"Make sure that the {wrongobject} of {productname} is numbers only!")
        {

        }
    }
}
