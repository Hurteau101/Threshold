using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    internal class Permissions
    {
        // This can be changed to a basic List of MenuStrip Items potentially. 
        public Dictionary<Object, Type> ListOfMenus = new Dictionary<Object, Type>();
        public int RoleID { get; set; }

        /// <summary>
        /// Loop through list of menus and set visibility to false. 
        /// </summary>
        public void MenuStripPermission()
        {
            foreach (var item in ListOfMenus.Keys.OfType<ToolStripMenuItem>())
            {
                item.Visible = false;
            }
        }

        /// <summary>
        /// Set Cargo Board readonly permissions. 
        /// </summary>
        /// <param name="cargoBoard"></param>
        public void ReadOnlyPermissionCargo(DataGridView cargoBoard)
        {
            cargoBoard.Columns["Flight_Number"].ReadOnly = true;
            cargoBoard.Columns["Departure"].ReadOnly = true;
            cargoBoard.Columns["Routing"].ReadOnly = true;
            cargoBoard.Columns["Weight_Given"].ReadOnly = true;
            cargoBoard.Columns["Seatpacks"].ReadOnly = true;
            cargoBoard.Columns["Aircraft"].ReadOnly = true;
            cargoBoard.Columns["Cargo_Notes"].ReadOnly = true;
            cargoBoard.Columns["Seatblock"].ReadOnly = true;
        }

        /// <summary>
        /// Set Ramp Board readonly permissions. 
        /// </summary>
        /// <param name="cargoBoard"></param>
        public void ReadOnlyPermissionRamp(DataGridView cargoBoard)
        {
            cargoBoard.ReadOnly = true; 
        }
    }
}
