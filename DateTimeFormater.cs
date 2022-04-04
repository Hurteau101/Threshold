using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class DateTimeFormater
    {
        public static DateTime DateDisplay { get; set; }

        /// <summary>
        /// Set DateTime Picker visual format.
        /// </summary>
        /// <param name="date"></param>
        public static void DateTimeDisplay(DateTimePicker date)
        {
            // Custom Date Picker Format 
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "ddd, dd MMM yyy";

            // Auto set date, from which date the ramp board showed. 
            date.Value = DateDisplay;
        }

        /// <summary>
        /// Get previous forms date and set this date to it. 
        /// </summary>
        /// <param name="date"></param>
        public static void GetPreviousDate(DateTimePicker date)
        {
            // Auto set date, from which date the ramp board showed. 
            date.Value = DateDisplay;
        }


    }
}
