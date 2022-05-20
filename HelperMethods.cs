using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class HelperMethods
    {
        /// <summary>
        /// Convert string to int. 
        /// </summary>
        /// <param name="tb"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetTextAsInteger(TextBox tb)
        {
            if(Int32.TryParse(tb.Text, out int result))
            {
                return result;
            }      
            /// ***** UNCOMMENT ONCE PROGRAM IS LIVE *****
            //else if(string.IsNullOrEmpty(tb.Text))
            //{
            //    return Convert.ToInt32(tb.Text = "0");
            //}
            else
            {
                throw new Exception("Cannot convert string to int");
            }
        }

        public static int GetTextAsInteger(ComboBox cb)
        {
            if (Int32.TryParse(cb.Text, out int result))
            {
                return result;
            }
            /// ***** UNCOMMENT ONCE PROGRAM IS LIVE *****
            else if (string.IsNullOrEmpty(cb.Text))
            {
                return Convert.ToInt32(cb.Text = "0");
            }
            else
            {
                throw new Exception("Cannot convert string to int");
            }
        }
     

    }
}
