using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Perimeter_Threshold
{
    class DisableFunctionLoadPlanner
    {
        /// <summary>
        /// Disable Seatpack Textbox if it's not Dash
        /// </summary>
        /// <param name="aircaftType"></param>
        /// <param name="seatpack_Leg1"></param>
        /// <param name="seatpack_Leg2"></param>
        /// <param name="seatpack_Leg3"></param>
        /// <param name="seatpack_Leg4"></param>
        /// <param name="seatpack_Leg5"></param>
        /// <param name="seatpack_Leg6"></param>
        /// <param name="seatpackPanel_Leg1"></param>
        public static void DisableSeatpacks(ComboBox aircraftType, List<TextBox> seatpacks, List<Panel> seatpackPanel)
        {
            if (!aircraftType.Text.Contains("Dash"))
            {
                foreach (var seatpack in seatpacks)
                {
                    seatpack.ReadOnly = true;
                    seatpack.Text = "0";
                    seatpack.BackColor = SystemColors.Control;
                    seatpack.TabStop = false;
                }
                foreach (var seatpack in seatpackPanel)
                {
                    seatpack.BackColor = SystemColors.Control;
                }

            }
            else
            {
                foreach (var seatpack in seatpacks)
                {
                    seatpack.ReadOnly = false;
                    seatpack.BackColor = Color.White;
                    seatpack.TabStop = true;
                }
                foreach (var seatpack in seatpackPanel)
                {
                    seatpack.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Disable AWI textbox if aircraft is a Dash. 
        /// </summary>
        /// <param name="aircraftType"></param>
        /// <param name="AWI"></param>
        /// <param name="panelAWI"></param>
        public static void DisableAWI(ComboBox aircraftType, List<TextBox> AWI, List<Panel> panelAWI)
        {
            if (aircraftType.Text.Contains("Dash"))
            {
                foreach (var awi in AWI)
                {
                    awi.ReadOnly = true;
                    awi.BackColor = SystemColors.Control;
                    awi.TabStop = false;

                }
                foreach (var awi in panelAWI)
                {
                    awi.BackColor = SystemColors.Control;
                }
            }
            else
            {
                foreach (var awi in AWI)
                {
                    awi.ReadOnly = false;
                    awi.BackColor = SystemColors.Window;
                    awi.TabStop = true;

                }
                foreach (var awi in panelAWI)
                {
                    awi.BackColor = SystemColors.Window;
                }
            }
        }
    }
}
