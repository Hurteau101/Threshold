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
        }

        /// <summary>
        /// Audo set date, from which date the ramp board showed.
        /// </summary>
        /// <param name="date"></param>
        public static void AutoSetDate(DateTimePicker date)
        {
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

        /// <summary>
        /// Show the DateTime Picker. 
        /// </summary>
        /// <param name="date"></param>
        public static void ShowDate(DateTimePicker date, ToolStripMenuItem showMenu, ToolStripMenuItem hideMenu)
        {
            // Show date and format toolbar. 
            date.Show();
            showMenu.Checked = true;
            hideMenu.Checked = false;
            hideMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            showMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        }

        /// <summary>
        /// Hide the DateTime Picker. 
        /// </summary>
        /// <param name="date"></param>
        public static void HideDate(DateTimePicker date, ToolStripMenuItem showMenu, ToolStripMenuItem hideMenu)
        {
            // Hide date and format toolbar. 
            date.Hide();
            hideMenu.Checked = true;
            showMenu.Checked = false;
            hideMenu.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            showMenu.DisplayStyle = ToolStripItemDisplayStyle.Text;

        }

    }
}
