using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BintanaSystem
{
    public class DBConnection
    {
        public static string getAddress()
        {
            return @"Data Source = localhost;Initial Catalog=BintanaSystem; Integrated Security = TRUE";
        }
    }
}
