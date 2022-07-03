using System.Collections.Generic;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class LoadPlanCalculations
    {
        public TextBox Fuel { get; set; }
        public TextBox TaxiBurn { get; set; }
        public TextBox FuelBurn { get; set; }
        public TextBox ReturnFuel { get; set; }

        /// <summary>
        /// Copy seatpacks in Seatpack leg 1.
        /// </summary>
        /// <param name="seatpack_leg1"></param>
        /// <param name="seatpack_leg2"></param>
        /// <param name="seatpack_leg3"></param>
        /// <param name="seatpack_leg4"></param>
        /// <param name="seatpack_leg5"></param>
        /// <param name="seatpack_leg6"></param>
        public static void SeatpackCopy(TextBox seatpack_leg1, TextBox seatpack_leg2, TextBox seatpack_leg3,
            TextBox seatpack_leg4, TextBox seatpack_leg5, TextBox seatpack_leg6)
        {
            seatpack_leg2.Text = seatpack_leg1.Text;
            seatpack_leg3.Text = seatpack_leg1.Text;
            seatpack_leg4.Text = seatpack_leg1.Text;
            seatpack_leg5.Text = seatpack_leg1.Text;
            seatpack_leg6.Text = seatpack_leg1.Text;
        }

        /// <summary>
        /// Check to make sure bag weight isn't 0, if it is, make allowable bags weight combobox empty. 
        /// </summary>
        /// <param name="numberOfPax"></param>
        /// <param name="allowableBags"></param>
        public static void BagWeightValidator(List<TextBox> numberOfPax, List<ComboBox> allowableBags)
        {
            foreach (var paxNum in numberOfPax)
            {
                if(HelperMethods.GetTextAsInteger(paxNum) != 0)
                {
                    foreach (var bag in allowableBags)
                    {
                        bag.SelectedIndex = -1;   
                    }
                }
            }
        }

        /// <summary>
        /// Calculate the total weight of bags and cargo. 
        /// </summary>
        /// <param name="bagWeight"></param>
        /// <param name="cargoWeight"></param>
        /// <param name="totalWeights"></param>
        public static string TotalWeight(TextBox bagWeight, TextBox cargoWeight, TextBox totalWeights)
        {
            return totalWeights.Text = (HelperMethods.GetTextAsInteger(cargoWeight) + HelperMethods.GetTextAsInteger(bagWeight)).ToString();
        }

        /// <summary>
        /// Return Gross Take Off Weight
        /// </summary>
        /// <param name="aircraftWeight"></param>
        /// <param name="passengerWeight"></param>
        /// <param name="bagWeight"></param>
        /// <param name="cargoWeight"></param>
        /// <param name="equipmentWeight"></param>
        /// <param name="awiWeight"></param>
        /// <param name="fuelWeight"></param>
        /// <param name="grossWeight"></param>
        /// <returns></returns>
        public static string GrossTakeOffTotal(TextBox aircraftWeight, TextBox passengerWeight, TextBox bagWeight,
            TextBox cargoWeight, TextBox equipmentWeight, TextBox awiWeight, TextBox fuelWeight,
            TextBox grossWeight)
        {
           return grossWeight.Text = (HelperMethods.GetTextAsInteger(aircraftWeight) + HelperMethods.GetTextAsInteger(passengerWeight) +
            HelperMethods.GetTextAsInteger(bagWeight) + HelperMethods.GetTextAsInteger(cargoWeight) +
            HelperMethods.GetTextAsInteger(equipmentWeight) + HelperMethods.GetTextAsInteger(awiWeight) +
            HelperMethods.GetTextAsInteger(fuelWeight)).ToString();
        }

        /// <summary>
        /// Return bag weight total, depending on passenger number. 
        /// </summary>
        /// <param name="checkStatus"></param>
        /// <param name="bagTotal"></param>
        /// <param name="numberOfPassengers"></param>
        /// <param name="allowableBags"></param>
        /// <returns></returns>
        public static string CalculateBagWeight(CheckBox checkStatus, TextBox bagTotal, TextBox numberOfPassengers, ComboBox allowableBags)
        {
            if(checkStatus.Checked)
            {
                if (allowableBags.SelectedIndex != -1)
                {
                    return bagTotal.Text = (HelperMethods.GetTextAsInteger(numberOfPassengers) * HelperMethods.GetTextAsInteger(allowableBags)).ToString();
                }
            }

            return bagTotal.Text;          
        }

        /// <summary>
        /// Calculate Zero Fuel Weight
        /// </summary>
        /// <param name="passengerWeight"></param>
        /// <param name="bagWeight"></param>
        /// <param name="cargoWeight"></param>
        /// <param name="equipmentWeight"></param>
        /// <param name="awiWeight"></param>
        /// <param name="zeroFuelWeight"></param>
        /// <param name="zeroFuelDifference"></param>
        /// <returns></returns>
        public static string CalculateZeroFuelDifference(TextBox aircraftWeight, TextBox passengerWeight, TextBox bagWeight, TextBox cargoWeight, TextBox equipmentWeight,
            TextBox awiWeight, TextBox zeroFuelWeight, TextBox zeroFuelDifference)
        {
            return zeroFuelDifference.Text = ((HelperMethods.GetTextAsInteger(zeroFuelWeight) - (HelperMethods.GetTextAsInteger(aircraftWeight) +
                HelperMethods.GetTextAsInteger(passengerWeight) + 
                HelperMethods.GetTextAsInteger(bagWeight) +
                HelperMethods.GetTextAsInteger(cargoWeight) + HelperMethods.GetTextAsInteger(equipmentWeight) +
                HelperMethods.GetTextAsInteger(awiWeight))).ToString());
        }

        /// <summary>
        /// Calculate Landing Weight
        /// </summary>
        /// <param name="grossWeight"></param>
        /// <param name="fuelBurn"></param>
        /// <param name="taxiBurn"></param>
        /// <param name="contigency"></param>
        /// <param name="landingWeight"></param>
        /// <returns></returns>
        public static string CalculateLandingWeight(TextBox grossWeight, TextBox fuelBurn, TextBox taxiBurn, 
            TextBox contigency, TextBox landingWeight)
        {
            return landingWeight.Text = (HelperMethods.GetTextAsInteger(grossWeight) - HelperMethods.GetTextAsInteger(fuelBurn) -
                HelperMethods.GetTextAsInteger(taxiBurn) - HelperMethods.GetTextAsInteger(contigency)).ToString();
        }

        /// <summary>
        /// Calculate Take off weight difference
        /// </summary>
        /// <param name="maxTakeOffWeight"></param>
        /// <param name="grossWeight"></param>
        /// <param name="takeOffDifference"></param>
        /// <returns></returns>
        public static string MaxTakeOffDifference(TextBox maxTakeOffWeight, TextBox grossWeight, TextBox takeOffDifference)
        {
            return takeOffDifference.Text = (HelperMethods.GetTextAsInteger(maxTakeOffWeight) - HelperMethods.GetTextAsInteger(grossWeight)).ToString();
        }

        /// <summary>
        /// Calculate landing weight difference
        /// </summary>
        /// <param name="maxLandingWeight"></param>
        /// <param name="landingWeight"></param>
        /// <param name="landingWeightDifference"></param>
        /// <returns></returns>
        public static string LandingWeightDifference(TextBox maxLandingWeight, TextBox landingWeight, TextBox landingWeightDifference)
        {
            return landingWeightDifference.Text = (HelperMethods.GetTextAsInteger(maxLandingWeight) - HelperMethods.GetTextAsInteger(landingWeight)).ToString();
        }    
    }
}
