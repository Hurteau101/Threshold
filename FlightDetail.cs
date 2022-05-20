using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Threshold
{
    public class FlightDetail
    {
        /// <summary>
        ///  Store legs information in this class. 
        /// </summary>
        public DateTime Date_ID { get; set; }
        public string Flight_Number { get; set; }
        public int Passenger_Weight { get; set; }
        public int Bag_Weight { get; set; }
        public int Cargo_Weight { get; set; }
        public int Equipment { get; set; }
        public int AWI { get; set; }
        public int Fuel { get; set; }
        public int Taxi_Burn { get; set; }
        public int Contigency { get; set; }
        public int TakeOff_Weight { get; set; }
        public int Landing_Weight { get; set; }
        public int Passenger_Number { get; set; }
        public int Seatpacks { get; set; }
        public string Aircraft { get; set; }
        public string Notes { get; set; }
        public string Crew { get; set; }
        public string Aircraft_Type { get; set; }
        public int Leg_Number { get; set; }
        public int Aircraft_Weight { get; set; }
        public int Fuel_Burn { get; set; }
        public string Aircraft_Configuration { get; set; }
    }
}
