using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Extension
{
    public static class GetCurrentDateExtension
    {
        public static DateTime GetCurrentTime()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            DateTime dt =
                DateTime.ParseExact(currentDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return dt;
        }
    }
}
