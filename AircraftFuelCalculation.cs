using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public class AircraftFuelCalculation
    {
        public TextBox Fuel_L1 { get; set; }
        public TextBox Fuel_L2 { get; set; }
        public TextBox Fuel_L3 { get; set; }
        public TextBox Fuel_L4 { get; set; }
        public TextBox Fuel_L5 { get; set; }
        public TextBox Fuel_L6 { get; set; }
        public TextBox TaxiBurn_L1 { get; set; }
        public TextBox TaxiBurn_L2 { get; set; }
        public TextBox TaxiBurn_L3 { get; set; }
        public TextBox TaxiBurn_L4 { get; set; }
        public TextBox TaxiBurn_L5 { get; set; }
        public TextBox Contigency_L1 { get; set; }
        public TextBox Contigency_L2 { get; set; }
        public TextBox Contigency_L3 { get; set; }
        public TextBox Contigency_L4 { get; set; }
        public TextBox Contigency_L5 { get; set; }
        public TextBox FuelBurn_L1 { get; set; }
        public TextBox FuelBurn_L2 { get; set; }
        public TextBox FuelBurn_L3 { get; set; }
        public TextBox FuelBurn_L4 { get; set; }
        public TextBox FuelBurn_L5 { get; set; }
        public int ReturnFuel_L1 { get; set; }
        public int ReturnFuel_L2 { get; set; }
        public int ReturnFuel_L3 { get; set; }
        public int ReturnFuel_L4 { get; set; }
        public int ReturnFuel_L5 { get; set; }

        ///***** THROW ERROR MESSAGE IF ANY LEGS CONTAIN 0 IN FUEL --- I NEED TO DO THIS ****

        /// <summary>
        /// Calculate Return Fuel for Aircrafts 
        /// </summary>
        /// <param name="numberOfLegs"></param>
        public void ReturnFuel(int numberOfLegs)
        {
            if(numberOfLegs == 2)
            {
                ReturnFuel_L1 = (HelperMethods.GetTextAsInteger(Fuel_L2) + HelperMethods.GetTextAsInteger(FuelBurn_L1) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L1) + HelperMethods.GetTextAsInteger(Contigency_L1));

                Fuel_L1.Text = ReturnFuel_L1.ToString();
            }
            else if(numberOfLegs == 3)
            {
                ReturnFuel_L2 = (HelperMethods.GetTextAsInteger(Fuel_L3) + HelperMethods.GetTextAsInteger(FuelBurn_L2) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L2) + HelperMethods.GetTextAsInteger(Contigency_L2));

                ReturnFuel_L1 = ReturnFuel_L2 + HelperMethods.GetTextAsInteger(FuelBurn_L1) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L1) + HelperMethods.GetTextAsInteger(Contigency_L1);

                Fuel_L2.Text = ReturnFuel_L2.ToString();
                Fuel_L1.Text = ReturnFuel_L1.ToString();
            }
            else if (numberOfLegs == 4)
            {
                ReturnFuel_L3 = (HelperMethods.GetTextAsInteger(Fuel_L4) + HelperMethods.GetTextAsInteger(FuelBurn_L3) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L3) + HelperMethods.GetTextAsInteger(Contigency_L3));

                ReturnFuel_L2 = ReturnFuel_L3 + HelperMethods.GetTextAsInteger(FuelBurn_L2) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L2) + HelperMethods.GetTextAsInteger(Contigency_L2);

                ReturnFuel_L1 = ReturnFuel_L2 + HelperMethods.GetTextAsInteger(FuelBurn_L1) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L1) + HelperMethods.GetTextAsInteger(Contigency_L1);

                Fuel_L3.Text = ReturnFuel_L3.ToString();
                Fuel_L2.Text = ReturnFuel_L2.ToString();
                Fuel_L1.Text = ReturnFuel_L1.ToString();
            }
            else if(numberOfLegs == 5)
            {
                ReturnFuel_L4 = (HelperMethods.GetTextAsInteger(Fuel_L5) + HelperMethods.GetTextAsInteger(FuelBurn_L4) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L4) + HelperMethods.GetTextAsInteger(Contigency_L4));

                ReturnFuel_L3 = ReturnFuel_L4 + HelperMethods.GetTextAsInteger(FuelBurn_L3) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L3) + HelperMethods.GetTextAsInteger(Contigency_L3);

                ReturnFuel_L2 = ReturnFuel_L3 + HelperMethods.GetTextAsInteger(FuelBurn_L2) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L2) + HelperMethods.GetTextAsInteger(Contigency_L2);

                ReturnFuel_L1 = ReturnFuel_L2 + HelperMethods.GetTextAsInteger(FuelBurn_L1) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L1) + HelperMethods.GetTextAsInteger(Contigency_L1);

                Fuel_L4.Text = ReturnFuel_L4.ToString();
                Fuel_L3.Text = ReturnFuel_L3.ToString();
                Fuel_L2.Text = ReturnFuel_L2.ToString();
                Fuel_L1.Text = ReturnFuel_L1.ToString();
            }
            else if(numberOfLegs == 6)
            {
                ReturnFuel_L5 = (HelperMethods.GetTextAsInteger(Fuel_L6) + HelperMethods.GetTextAsInteger(FuelBurn_L5) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L5) + HelperMethods.GetTextAsInteger(Contigency_L5));

                ReturnFuel_L4 = ReturnFuel_L5 + HelperMethods.GetTextAsInteger(FuelBurn_L4) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L4) + HelperMethods.GetTextAsInteger(Contigency_L4);

                ReturnFuel_L3 = ReturnFuel_L4 + HelperMethods.GetTextAsInteger(FuelBurn_L3) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L3) + HelperMethods.GetTextAsInteger(Contigency_L3);

                ReturnFuel_L2 = ReturnFuel_L3 + HelperMethods.GetTextAsInteger(FuelBurn_L2) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L2) + HelperMethods.GetTextAsInteger(Contigency_L2);

                ReturnFuel_L1 = ReturnFuel_L2 + HelperMethods.GetTextAsInteger(FuelBurn_L1) +
                    HelperMethods.GetTextAsInteger(TaxiBurn_L1) + HelperMethods.GetTextAsInteger(Contigency_L1);

                Fuel_L5.Text = ReturnFuel_L5.ToString();
                Fuel_L4.Text = ReturnFuel_L4.ToString();
                Fuel_L3.Text = ReturnFuel_L3.ToString();
                Fuel_L2.Text = ReturnFuel_L2.ToString();
                Fuel_L1.Text = ReturnFuel_L1.ToString();
            }
        }
    }
}
