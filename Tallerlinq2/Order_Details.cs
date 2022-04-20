using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tallerlinq2
{
    public partial class Order_Details
    {
        public float detallex()
        {
            return (float)(UnitPrice * Quantity);
        }
    }
}