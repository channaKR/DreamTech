using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DesktopToyShop.Service
{
    public class SettingService
    {
        
        private DateTime StartDate;
        private DateTime EndDate;
        public int CalculateDate(DateTime startdate,DateTime enddate)
        {

            StartDate= new DateTime(startdate.Year, startdate.Month, startdate.Day);
            EndDate= new DateTime(enddate.Year, enddate.Month, enddate.Day);
            var days = EndDate - StartDate;
            return days.Days;
        }

        public Dictionary<string, int> Leaves(int sick,int casual)
        {
            return new Dictionary<string, int>
            {
                {"medical",sick },

                { "casual" , casual}
            };
        }

    }
}
