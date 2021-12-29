using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApplication
{
    public class Unavailability
    {

        public Unavailability(bool morning, bool afternoon, bool evening)
        {
            Morning = morning;
            Afternoon = afternoon;
            Evening = evening;
        }

        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Evening { get; set; }

    }
}
