using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class RetailLocation
    {
        public String retailLocationName { get; set; }
        public String retailLocationAddress { get; set; }
        public int retailLocationPK { get; private set; }

        public RetailLocation()
        {
        }

    }
}
