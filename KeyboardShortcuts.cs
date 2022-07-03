using System;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class KeyboardShortcuts
    {
        /// <summary>
        /// Refresh Board
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool Refresh(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Go 1 day back from date on datetime picker. 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="boardDate"></param>
        public static void PreviousDay(KeyEventArgs e, DateTimePicker boardDate)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                boardDate.Value = boardDate.Value.AddDays(-1);
            }
        }

        /// <summary>
        /// Go 1 day forward from date on datetime picker. 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="boardDate"></param>
        public static void NextDay(KeyEventArgs e, DateTimePicker boardDate)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                boardDate.Value = boardDate.Value.AddDays(1);
            }
        }

        /// <summary>
        /// Go to current date. 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="boardDate"></param>
        public static void GoToCurrentDate(KeyEventArgs e, DateTimePicker boardDate)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                boardDate.Value = DateTime.Now;
            }
        }
    }
}
