using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tallerlinq2
{
    public partial class Employees

    {
        public string NombreCompleto()
        {
            return LastName + "" + FirstName;
        }
    }
}