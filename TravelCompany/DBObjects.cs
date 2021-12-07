using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TravelCompany
{
    public static class DBObjects
    {
        public static Travel_companyEntities Entities { get; } = new Travel_companyEntities();
    }
}
