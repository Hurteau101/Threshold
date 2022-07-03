using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class LoadPlanner : Form
    {
        public LoadPlanner()
        {
            InitializeComponent();
        }

        public static int NumberOfLegs { get; set; }
        public static string Departure { get; set; }
        public static string Main_Routing { get; set; }
        public string FullName { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }

        /// <summary>
        /// Create a generic list, to provide any type of return type. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="leg1"></param>
        /// <param name="leg2"></param>
        /// <param name="leg3"></param>
        /// <param name="leg4"></param>
        /// <param name="leg5"></param>
        /// <param name="leg6"></param>
        /// <returns></returns>
        private List<T> ReturnListOfTypes<T>(T leg1, T leg2, T leg3,
            T leg4, T leg5, T leg6)
        {
            List<T> legs = new List<T>();
            
            legs.Add(leg1);
            legs.Add(leg2);
            legs.Add(leg3);
            legs.Add(leg4);
            legs.Add(leg5);
            legs.Add(leg6);

            return legs;
        }

        /// <summary>
        /// Insert flight details that are the same for every flight. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertCommonFlightDetails()
        {
            return new FlightDetail
            {
                Date_ID = dateTimeLoadPlanner.Value.Date,
                Flight_Number = cbFlightNumber.Text,
                Aircraft = cbAircraft.Text,
                Aircraft_Type = cbAircraftType.Text,
                Aircraft_Weight = HelperMethods.GetTextAsInteger(tbAircraftWeight),
                Crew = cbCrew.Text,             
            };
        }

        /// <summary>
        /// Save Leg 1 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg1Details()
        {
             var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 1;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L1);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L1);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L1);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L1);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L1);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L1);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L1);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L1);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L1);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L1);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L1);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L1);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L1);
                if(radioALC.Checked)
                {
                    flightLegDetails.Notes = tbNotes.Text;
                }
                flightLegDetails.Aircraft_Configuration = tbSeats_L1.Text;
                flightLegDetails.Aircraft_Location = cbAC_Location.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save Leg 2 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg2Details()
        {
            var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 2;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L2);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L2);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L2);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L2);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L2);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L2);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L2);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L2);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L2);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L2);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L2);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L2);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L2);
                flightLegDetails.Notes = tbNotes_L2.Text;
                flightLegDetails.Aircraft_Configuration = tbSeats_L2.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save Leg 3 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg3Details()
        {
            var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 3;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L3);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L3);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L3);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L3);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L3);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L3);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L3);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L3);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L3);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L3);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L3);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L3);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L3);
                flightLegDetails.Notes = tbNotes_L3.Text;
                flightLegDetails.Aircraft_Configuration = tbSeats_L3.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save Leg 4 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg4Details()
        {
            var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 4;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L4);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L4);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L4);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L4);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L4);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L4);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L4);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L4);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L4);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L4);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L4);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L4);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L4);
                flightLegDetails.Notes = tbNotes_L4.Text;
                flightLegDetails.Aircraft_Configuration = tbSeats_L4.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save Leg 5 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg5Details()
        {
            var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 5;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L5);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L5);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L5);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L5);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L5);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L5);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L5);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L5);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L5);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L5);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L5);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L5);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L5);
                flightLegDetails.Notes = tbNotes_L5.Text;
                flightLegDetails.Aircraft_Configuration = tbSeats_L5.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save Leg 6 Flight details to FlightDetail class. 
        /// </summary>
        /// <returns></returns>
        private FlightDetail InsertLeg6Details()
        {
            var flightLegDetails = InsertCommonFlightDetails();
            {
                InsertCommonFlightDetails(); // Return the Flight Details that are the same for every flight and pass to this return type. 
                flightLegDetails.Leg_Number = 6;
                flightLegDetails.Passenger_Weight = HelperMethods.GetTextAsInteger(tbPax_L6);
                flightLegDetails.Bag_Weight = HelperMethods.GetTextAsInteger(tbBags_L6);
                flightLegDetails.Cargo_Weight = HelperMethods.GetTextAsInteger(tbCargo_L6);
                flightLegDetails.Equipment = HelperMethods.GetTextAsInteger(tbEquip_L6);
                flightLegDetails.AWI = HelperMethods.GetTextAsInteger(tbAWI_L6);
                flightLegDetails.Fuel = HelperMethods.GetTextAsInteger(tbFuel_L6);
                flightLegDetails.Contigency = HelperMethods.GetTextAsInteger(tbCont_L6);
                flightLegDetails.Taxi_Burn = HelperMethods.GetTextAsInteger(tbTaxiBurn_L6);
                flightLegDetails.TakeOff_Weight = HelperMethods.GetTextAsInteger(tbMTOW_L6);
                flightLegDetails.Landing_Weight = HelperMethods.GetTextAsInteger(tbMLW_L6);
                flightLegDetails.Passenger_Number = HelperMethods.GetTextAsInteger(tbPaxNo_L6);
                flightLegDetails.Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L6);
                flightLegDetails.Fuel_Burn = HelperMethods.GetTextAsInteger(tbFuelBurn_L6);
                flightLegDetails.Notes = tbNotes_L6.Text;
                flightLegDetails.Aircraft_Configuration = tbSeats_L6.Text;
            };

            return flightLegDetails;
        }

        /// <summary>
        /// Save only the amount of legs needed.
        /// </summary>
        private void SaveLegs()
        {
            switch (NumberOfLegs)
            {
                case 1:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    break;
                case 2:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    SaveDataALC.SaveFlight(InsertLeg2Details());
                    break;
                case 3:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    SaveDataALC.SaveFlight(InsertLeg2Details());
                    SaveDataALC.SaveFlight(InsertLeg3Details());
                    break;
                case 4:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    SaveDataALC.SaveFlight(InsertLeg2Details());
                    SaveDataALC.SaveFlight(InsertLeg3Details());
                    SaveDataALC.SaveFlight(InsertLeg4Details());
                    break;
                case 5:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    SaveDataALC.SaveFlight(InsertLeg2Details());
                    SaveDataALC.SaveFlight(InsertLeg3Details());
                    SaveDataALC.SaveFlight(InsertLeg4Details());
                    SaveDataALC.SaveFlight(InsertLeg5Details());
                    break;
                case 6:
                    SaveDataALC.SaveFlight(InsertLeg1Details());
                    SaveDataALC.SaveFlight(InsertLeg2Details());
                    SaveDataALC.SaveFlight(InsertLeg3Details());
                    SaveDataALC.SaveFlight(InsertLeg4Details());
                    SaveDataALC.SaveFlight(InsertLeg5Details());
                    SaveDataALC.SaveFlight(InsertLeg6Details());
                    break;
            }
        }

        /// <summary>
        /// Load all of leg 1 information from database. 
        /// </summary>
        private void LoadLeg1Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 1))
            {
                tbPax_L1.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L1.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L1.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L1.Text = flightInfo.Equipment.ToString();
                tbAWI_L1.Text = flightInfo.AWI.ToString();
                tbFuel_L1.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L1.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L1.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L1.Text = flightInfo.Contigency.ToString();
                tbMTOW_L1.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L1.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L1.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L1.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L1.Text = flightInfo.Landing_Weight.ToString();                
            }
        }

        /// <summary>
        /// Load all of leg 2 information from database.
        /// </summary>
        private void LoadLeg2Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 2))
            {
                tbPax_L2.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L2.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L2.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L2.Text = flightInfo.Equipment.ToString();
                tbAWI_L2.Text = flightInfo.AWI.ToString();
                tbFuel_L2.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L2.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L2.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L2.Text = flightInfo.Contigency.ToString();
                tbMTOW_L2.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L2.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L2.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L2.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L2.Text = flightInfo.Landing_Weight.ToString();
            }
        }

        /// <summary>
        /// Load all of leg 3 information from database.
        /// </summary>
        private void LoadLeg3Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 3))
            {
                tbPax_L3.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L3.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L3.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L3.Text = flightInfo.Equipment.ToString();
                tbAWI_L3.Text = flightInfo.AWI.ToString();
                tbFuel_L3.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L3.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L3.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L3.Text = flightInfo.Contigency.ToString();
                tbMTOW_L3.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L3.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L3.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L3.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L3.Text = flightInfo.Landing_Weight.ToString();
            }
        }

        /// <summary>
        /// Load all of leg 4 information from database.
        /// </summary>
        private void LoadLeg4Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 4))
            {
                tbPax_L4.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L4.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L4.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L4.Text = flightInfo.Equipment.ToString();
                tbAWI_L4.Text = flightInfo.AWI.ToString();
                tbFuel_L4.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L4.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L4.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L4.Text = flightInfo.Contigency.ToString();
                tbMTOW_L4.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L4.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L4.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L4.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L4.Text = flightInfo.Landing_Weight.ToString();
            }
        }

        /// <summary>
        /// Load all of leg 5 information from database.
        /// </summary>
        private void LoadLeg5Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 5))
            {
                tbPax_L5.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L5.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L5.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L5.Text = flightInfo.Equipment.ToString();
                tbAWI_L5.Text = flightInfo.AWI.ToString();
                tbFuel_L5.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L5.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L5.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L5.Text = flightInfo.Contigency.ToString();
                tbMTOW_L5.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L5.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L5.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L5.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L5.Text = flightInfo.Landing_Weight.ToString();
            }
        }

        /// <summary>
        /// Load all of leg 6 information from database.
        /// </summary>
        private void LoadLeg6Information()
        {
            LoadDataALC load = new LoadDataALC();
            foreach (var flightInfo in load.LoadLegInformation(cbFlightNumber, dateTimeLoadPlanner.Value.Date, 6))
            {
                tbPax_L6.Text = flightInfo.Passenger_Weight.ToString();
                tbBags_L6.Text = flightInfo.Bag_Weight.ToString();
                tbCargo_L6.Text = flightInfo.Cargo_Weight.ToString();
                tbEquip_L6.Text = flightInfo.Equipment.ToString();
                tbAWI_L6.Text = flightInfo.AWI.ToString();
                tbFuel_L6.Text = flightInfo.Fuel.ToString();
                tbFuelBurn_L6.Text = flightInfo.Fuel_Burn.ToString();
                tbTaxiBurn_L6.Text = flightInfo.Taxi_Burn.ToString();
                tbCont_L6.Text = flightInfo.Contigency.ToString();
                tbMTOW_L6.Text = flightInfo.TakeOff_Weight.ToString();
                tbPaxNo_L6.Text = flightInfo.Passenger_Number.ToString();
                tbSeatpacks_L6.Text = flightInfo.Seatpacks.ToString();
                tbSeats_L6.Text = flightInfo.Aircraft_Configuration.ToString();
                tbMLW_L6.Text = flightInfo.Landing_Weight.ToString();
            }
        }

        /// <summary>
        /// Load the number of information, depending on the number of legs. 
        /// </summary>
        private void LegLoader()
        {
            switch (NumberOfLegs)
            {
                case 1:
                    LoadLeg1Information();
                    break;
                case 2:
                    LoadLeg1Information();
                    LoadLeg2Information();
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L2, 2);
                    break;
                case 3:
                    LoadLeg1Information();
                    LoadLeg2Information();
                    LoadLeg3Information();

                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L2, 2);;
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L3, 3);
                    break;
                case 4:
                    LoadLeg1Information();
                    LoadLeg2Information();
                    LoadLeg3Information();
                    LoadLeg4Information();

                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L2, 2);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L3, 3);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L4, 4);
                    break;
                case 5:
                    LoadLeg1Information();
                    LoadLeg2Information();
                    LoadLeg3Information();
                    LoadLeg4Information();
                    LoadLeg5Information();

                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L2, 2);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L3, 3);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L4, 4);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L5, 5);

                    break;
                case 6:
                    LoadLeg1Information();
                    LoadLeg2Information();
                    LoadLeg3Information();
                    LoadLeg4Information();
                    LoadLeg5Information();
                    LoadLeg6Information();

                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L2, 2);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L3, 3);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L4, 4);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L5, 5);
                    LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes_L6, 6);
                    break;
            }
        }


        /// <summary>
        /// Save common flight details from loadplanner, for pushing to Ramp and Cargo board. 
        /// </summary>
        /// <returns></returns>
        private LoadPlannerBoardUpdates StoreCommonLoaderPlannerUpdaterDetails()
        {
            return new LoadPlannerBoardUpdates
            {
                Flight_Number = cbFlightNumber.Text,
                Date_ID = dateTimeLoadPlanner.Value.Date,
                Main_Routing = Main_Routing,
                Departure = Departure,
                Aircraft = cbAircraft.Text,
                Seatpacks = HelperMethods.GetTextAsInteger(tbSeatpacks_L1),
            };
        }

        /// <summary>
        /// Store common + unique details from loadplanner to ramp board. 
        /// </summary>
        /// <returns></returns>
        public LoadPlannerBoardUpdates StoreLoadPlannerUpdaterRampDetails()
        {
            var flightDetails = StoreCommonLoaderPlannerUpdaterDetails();
            {
                 StoreCommonLoaderPlannerUpdaterDetails();
                 flightDetails.ALCRemark = tbNotes.Text;
                 flightDetails.Aircraft_Location = cbAC_Location.Text;                        
            };

            return flightDetails;
        }

        /// <summary>
        /// Store common + unique details from loadplanner to cargo board. 
        /// </summary>
        /// <returns></returns>
        public LoadPlannerBoardUpdates StoreLoadPlannerUpdaterCargoDetails()
        {
            var flightDetails = StoreCommonLoaderPlannerUpdaterDetails();
            {
                StoreCommonLoaderPlannerUpdaterDetails();
                flightDetails.Cargo_Notes = tbNotes.Text;
                flightDetails.Weight_Given = HelperMethods.GetTextAsInteger(tbCargo_L1);
            };

            return flightDetails;
        }

        /// <summary>
        /// Calculate Return Fuel 
        /// </summary>
        private void ReturnFuel()
        {
            AircraftFuelCalculation calculateReturnFuel = new AircraftFuelCalculation
            {
                TaxiBurn_L1 = tbTaxiBurn_L1,
                TaxiBurn_L2 = tbTaxiBurn_L2,
                TaxiBurn_L3 = tbTaxiBurn_L3,
                TaxiBurn_L4 = tbTaxiBurn_L4,
                TaxiBurn_L5 = tbTaxiBurn_L5,
                Contigency_L1 = tbCont_L1,
                Contigency_L2 = tbCont_L2,
                Contigency_L3 = tbCont_L3,
                Contigency_L4 = tbCont_L4,
                Contigency_L5 = tbCont_L5,
                FuelBurn_L1 = tbFuelBurn_L1,
                FuelBurn_L2 = tbFuelBurn_L2,
                FuelBurn_L3 = tbFuelBurn_L3,
                FuelBurn_L4 = tbFuelBurn_L4,
                FuelBurn_L5 = tbFuelBurn_L5,
                Fuel_L1 = tbFuel_L1,
                Fuel_L2 = tbFuel_L2,
                Fuel_L3 = tbFuel_L3,
                Fuel_L4 = tbFuel_L4,
                Fuel_L5 = tbFuel_L5,
                Fuel_L6 = tbFuel_L6,
            };
            calculateReturnFuel.ReturnFuel(NumberOfLegs);
        }

        private bool OnlyIntValues(KeyPressEventArgs e)
        {
            return e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void LoadPlanner_Load(object sender, EventArgs e)
        {
            cbBagCal_L1.SelectedIndex = 0;
            cbBagCal_L2.SelectedIndex = 0;
            cbBagCal_L3.SelectedIndex = 0;
            cbBagCal_L4.SelectedIndex = 0;
            cbBagCal_L5.SelectedIndex = 0;
            cbBagCal_L6.SelectedIndex = 0;

            DateTimeFormater.DateTimeDisplay(dateTimeLoadPlanner);

            SchedulerLoaderChecks.SchedulerLoaderCheckALC(dateTimeLoadPlanner);

            // Load -- Flight Light, Aircraft Type, Aircraft, Crew, Aircraft Weight, Routing for each leg,
            // Number of Legs, Show proper amount of legs, Zero Fuel Weight, Taxi Burn, Equipment
            // Aircraft Configuration, Previous Aircraft, Previous Aircraft Type, Previous Crew
            // Previous aircraft weigtht, Store main routing. 
            LoadDataALC loadInformation = new LoadDataALC(dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadFlightNumber(cbFlightNumber);
            loadInformation.LoadAircraftType(cbAircraftType);
            loadInformation.LoadAircraft(cbAircraft, cbAircraftType);
            loadInformation.LoadCrew(cbCrew, cbAircraftType);
            loadInformation.LoadAircraftWeight(cbCrew, cbAircraftType, tbAircraftWeight, cbAircraft);
            loadInformation.LoadLegNumber(cbFlightNumber);
            loadInformation.LoadLegRoutings(cbFlightNumber, tbRouting, tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
            loadInformation.ShowNumberOfTabs(tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
            loadInformation.LoadZeroFuelWeight(cbAircraft, ReturnListOfTypes(tbZFW_L1, tbZFW_L2, tbZFW_L3, tbZFW_L4, tbZFW_L5, tbZFW_L6));
            loadInformation.LoadTaxiBurn(cbAircraft, ReturnListOfTypes(tbTaxiBurn_L1, tbTaxiBurn_L2, tbTaxiBurn_L3, tbTaxiBurn_L4, tbTaxiBurn_L5, tbTaxiBurn_L6));
            loadInformation.LoadEquipment(cbAircraft, ReturnListOfTypes(tbEquip_L1, tbEquip_L2, tbEquip_L3, tbEquip_L4, tbEquip_L5, tbEquip_L6));
            loadInformation.LoadAircraftConfiguration(cbAircraft, ReturnListOfTypes(tbSeats_L1, tbSeats_L2, tbSeats_L3, tbSeats_L4, tbSeats_L5, tbSeats_L6));
            loadInformation.LoadPreviousAircraftType(cbFlightNumber, NumberOfLegs, cbAircraftType);
            loadInformation.LoadPreviousAircraft(cbFlightNumber, NumberOfLegs, cbAircraft);
            loadInformation.LoadPreviousCrew(cbFlightNumber, NumberOfLegs, cbCrew);
            loadInformation.LoadPreviousOEW(cbFlightNumber, NumberOfLegs, tbAircraftWeight);
            loadInformation.LoadRoutingAndDeparture(cbFlightNumber, dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadPreviousAircraftLocation(cbFlightNumber, cbAC_Location);

            // Disable Functions
            DisableFunctionLoadPlanner.DisableSeatpacks(cbAircraftType, ReturnListOfTypes(tbSeatpacks_L1, tbSeatpacks_L2, tbSeatpacks_L3, tbSeatpacks_L4,
                tbSeatpacks_L5, tbSeatpacks_L6), ReturnListOfTypes(panelSeatpacks_L1, panelSeatpacks_L2, panelSeatpacks_L3, panelSeatpacks_L4,
                panelSeatpacks_L5, panelSeatpacks_L6));
            DisableFunctionLoadPlanner.DisableAWI(cbAircraftType, ReturnListOfTypes(tbAWI_L1, tbAWI_L2, tbAWI_L3, tbAWI_L4, tbAWI_L5, tbAWI_L6),
                ReturnListOfTypes(panelAWI_L1, panelAWI_L2, panelAWI_L3, panelAWI_L4, panelAWI_L5, panelAWI_L6));

            LegLoader();
            LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, 1);

            LoadPlanCalculations.BagWeightValidator(ReturnListOfTypes(tbPaxNo_L1, tbPaxNo_L2, tbPaxNo_L3, tbPaxNo_L4, tbPaxNo_L5, tbPaxNo_L6), 
                ReturnListOfTypes(cbBagCal_L1, cbBagCal_L2, cbBagCal_L3, cbBagCal_L4, cbBagCal_L5, cbBagCal_L6));
        }

        private void dateTimeLP_ValueChanged(object sender, EventArgs e)
        {
            SchedulerLoaderChecks.SchedulerLoaderCheckALC(dateTimeLoadPlanner);

            // Load -- Flight List, Number of Legs, Show proper amount of legs. 
            LoadDataALC loadInformation = new LoadDataALC(dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadFlightNumber(cbFlightNumber);
            loadInformation.LoadLegNumber(cbFlightNumber);
            loadInformation.ShowNumberOfTabs(tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
        }

        private void cbAC_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load -- Aircraft List, Crew, Aircraft Weight, Taxi Burn, Equipment
            LoadDataALC loadInformation = new LoadDataALC();
            loadInformation.LoadAircraft(cbAircraft, cbAircraftType);
            loadInformation.LoadCrew(cbCrew, cbAircraftType);
            loadInformation.LoadAircraftWeight(cbCrew, cbAircraftType, tbAircraftWeight, cbAircraft);
            loadInformation.LoadTaxiBurn(cbAircraft, ReturnListOfTypes(tbTaxiBurn_L1, tbTaxiBurn_L2, tbTaxiBurn_L3, tbTaxiBurn_L4, tbTaxiBurn_L5, tbTaxiBurn_L6));
            loadInformation.LoadEquipment(cbAircraft, ReturnListOfTypes(tbEquip_L1, tbEquip_L2, tbEquip_L3, tbEquip_L4, tbEquip_L5, tbEquip_L6));

            // Disable Functions
            DisableFunctionLoadPlanner.DisableSeatpacks(cbAircraftType, ReturnListOfTypes(tbSeatpacks_L1, tbSeatpacks_L2, tbSeatpacks_L3, tbSeatpacks_L4,
                tbSeatpacks_L5, tbSeatpacks_L6), ReturnListOfTypes(panelSeatpacks_L1, panelSeatpacks_L2, panelSeatpacks_L3, panelSeatpacks_L4,
                panelSeatpacks_L5, panelSeatpacks_L6));

            DisableFunctionLoadPlanner.DisableAWI(cbAircraftType, ReturnListOfTypes(tbAWI_L1, tbAWI_L2, tbAWI_L3, tbAWI_L4, tbAWI_L5, tbAWI_L6),
                ReturnListOfTypes(panelAWI_L1, panelAWI_L2, panelAWI_L3, panelAWI_L4, panelAWI_L5, panelAWI_L6));
        }

        private void cbCrew_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Aircraft Weight
            LoadDataALC loadWeight = new LoadDataALC();
            loadWeight.LoadAircraftWeight(cbCrew, cbAircraftType, tbAircraftWeight, cbAircraft);
        }

        private void tabControlLoadPlanner_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Routing for each leg, previous aircraft, previous aircraft type,
            // previous crew, previous aircraft weight
            LoadDataALC loadInformation = new LoadDataALC(dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadLegRoutings(cbFlightNumber, tbRouting, tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
        }

        private void tbRouting_TextChanged(object sender, EventArgs e)
        {
            if(tbRouting.Text != "Insert Routing")
            {
                tbRouting.ForeColor = Color.Black;
                tbRouting.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void cbFlightNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Load -- Routing for each leg, Number of Legs, Show proper amount of legs,
            //// Previous aircraft, Aircraft type, Previous Crew, Previous Aircraft Weight, Store main routing. 
            /// Load Notes from rampboard. 
            LoadDataALC loadInformation = new LoadDataALC(dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadLegNumber(cbFlightNumber);
            loadInformation.LoadLegRoutings(cbFlightNumber, tbRouting, tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
            loadInformation.ShowNumberOfTabs(tabControlLoadPlanner, ReturnListOfTypes(tabLeg1, tabLeg2, tabLeg3, tabLeg4, tabLeg5, tabLeg6));
            loadInformation.LoadPreviousAircraftType(cbFlightNumber, NumberOfLegs, cbAircraftType);
            loadInformation.LoadPreviousAircraft(cbFlightNumber, NumberOfLegs, cbAircraft);
            loadInformation.LoadPreviousCrew(cbFlightNumber, NumberOfLegs, cbCrew);
            loadInformation.LoadPreviousOEW(cbFlightNumber, NumberOfLegs, tbAircraftWeight);
            loadInformation.LoadRoutingAndDeparture(cbFlightNumber, dateTimeLoadPlanner.Value.Date);
            loadInformation.LoadPreviousAircraftLocation(cbFlightNumber, cbAC_Location);

            LegLoader();

            if(radioALC.Checked)
            {
                LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, 1);
            }
            else if(radioCargo.Checked)
            {
                LoadDataALC.LoadCargoNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, radioCargo);
            }
            else
            {
                LoadDataALC.LoadRampNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, radioRamp);
            }

            LoadPlanCalculations.BagWeightValidator(ReturnListOfTypes(tbPaxNo_L1, tbPaxNo_L2, tbPaxNo_L3, tbPaxNo_L4, tbPaxNo_L5, tbPaxNo_L6),
               ReturnListOfTypes(cbBagCal_L1, cbBagCal_L2, cbBagCal_L3, cbBagCal_L4, cbBagCal_L5, cbBagCal_L6));
        }

        private void cbAircraft_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load -- Aircarft Zero Fuel Weight, Equipment, Aircraft Configuration
            LoadDataALC loadInformation = new LoadDataALC();
            loadInformation.LoadAircraftWeight(cbCrew, cbAircraftType, tbAircraftWeight, cbAircraft);
            loadInformation.LoadZeroFuelWeight(cbAircraft, ReturnListOfTypes(tbZFW_L1, tbZFW_L2, tbZFW_L3, tbZFW_L4, tbZFW_L5, tbZFW_L6));
            loadInformation.LoadEquipment(cbAircraft, ReturnListOfTypes(tbEquip_L1, tbEquip_L2, tbEquip_L3, tbEquip_L4, tbEquip_L5, tbEquip_L6));
            loadInformation.LoadAircraftConfiguration(cbAircraft, ReturnListOfTypes(tbSeats_L1, tbSeats_L2, tbSeats_L3, tbSeats_L4, tbSeats_L5, tbSeats_L6));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLegs();
            SaveDataALC.SaveAircraftWeight(cbAircraft, cbCrew, tbAircraftWeight);
            SaveDataALC.SaveAircraftConfiguration(cbAircraft, tbSeats_L1);
        }

        private void radioCargo_CheckedChanged(object sender, EventArgs e)
        {
            // Enable buttons, depending on Radio Button selection.
            btnUpdateRampBoard.Enabled = false;
            btnUpdateCargoBoard.Enabled = true;
            LoadDataALC.LoadCargoNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, radioCargo);
        }

        private void radioRamp_CheckedChanged(object sender, EventArgs e)
        {
            // Enable buttons, depending on Radio Button selection.
            btnUpdateCargoBoard.Enabled = false;
            btnUpdateRampBoard.Enabled = true;
            LoadDataALC.LoadRampNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, radioRamp);
        }

        private void radioALC_CheckedChanged(object sender, EventArgs e)
        {
            // Enable buttons, depending on Radio Button selection.
            btnUpdateCargoBoard.Enabled = false;
            btnUpdateRampBoard.Enabled = false;
            LoadDataALC.LoadALCNotes(cbFlightNumber, dateTimeLoadPlanner.Value.Date, tbNotes, 1);
        }

        private void tbBags_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L1, tbCargo_L1, tbTotalWT_L1);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void tbCargo_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L1, tbCargo_L1, tbTotalWT_L1);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void tbBags_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L2, tbCargo_L2, tbTotalWT_L2);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void tbCargo_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L2, tbCargo_L2, tbTotalWT_L2);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void tbBags_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L3, tbCargo_L3, tbTotalWT_L3);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void tbCargo_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L3, tbCargo_L3, tbTotalWT_L3);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void tbBags_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L4, tbCargo_L4, tbTotalWT_L4);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
        }

        private void tbCargo_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L4, tbCargo_L4, tbTotalWT_L4);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
        }

        private void tbBags_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L5, tbCargo_L5, tbTotalWT_L5);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void tbCargo_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L5, tbCargo_L5, tbTotalWT_L5);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void tbBags_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L6, tbCargo_L6, tbTotalWT_L6);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbCargo_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.TotalWeight(tbBags_L6, tbCargo_L6, tbTotalWT_L6);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbPax_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
        }

        private void tbEquip_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void tbAWI_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void tbAircraftWeight_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);

            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbFuel_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbFuel_L1, tbGrossWT_L1);
        }

        private void tbPax_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
        }

        private void tbEquip_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void tbAWI_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void tbFuel_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbFuel_L2, tbGrossWT_L2);
        }

        private void tbPax_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
        }

        private void tbEquip_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void tbAWI_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void tbFuel_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbFuel_L3, tbGrossWT_L3);
        }

        private void tbPax_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
        }

        private void tbEquip_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
        }

        private void tbFuel_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbFuel_L4, tbGrossWT_L4);
        }

        private void tbPax_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
        }

        private void tbEquip_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void tbAWI_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void tbFuel_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbFuel_L5, tbGrossWT_L5);
        }

        private void tbPax_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
        }

        private void tbEquip_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbAWI_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbFuel_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.GrossTakeOffTotal(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbFuel_L6, tbGrossWT_L6);
        }

        private void tbPaxNo_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL1, tbBags_L1, tbPaxNo_L1, cbBagCal_L1);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void cbBagCal_L1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL1, tbBags_L1, tbPaxNo_L1, cbBagCal_L1);
        }

        private void tbPaxNo_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL2, tbBags_L2, tbPaxNo_L2, cbBagCal_L2);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void cbBagCal_L2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL2, tbBags_L2, tbPaxNo_L2, cbBagCal_L2);
        }

        private void tbPaxNo_L3_TextChanged_1(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL3, tbBags_L3, tbPaxNo_L3, cbBagCal_L3);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void cbBagCal_L3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL3, tbBags_L3, tbPaxNo_L3, cbBagCal_L3);
        }

        private void tbPaxNo_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL4, tbBags_L4, tbPaxNo_L4, cbBagCal_L4);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
        }

        private void cbBagCal_L4_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL4, tbBags_L4, tbPaxNo_L4, cbBagCal_L4);
        }

        private void tbPaxNo_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL5, tbBags_L5, tbPaxNo_L5, cbBagCal_L5);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void cbBagCal_L5_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL5, tbBags_L5, tbPaxNo_L5, cbBagCal_L5);
        }

        private void tbPaxNo_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL6, tbBags_L6, tbPaxNo_L6, cbBagCal_L6);
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void cbBagCal_L6_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateBagWeight(ckBagL6, tbBags_L6, tbPaxNo_L6, cbBagCal_L6);
        }

        private void tbGrossWT_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L1, tbFuelBurn_L1, tbTaxiBurn_L1, tbCont_L1, tbLandingWT_L1);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L1, tbGrossWT_L1, tbMTOW_Dif_L1);
        }

        private void tbFuelBurn_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L1, tbFuelBurn_L1, tbTaxiBurn_L1, tbCont_L1, tbLandingWT_L1);
        }

        private void tbTaxiBurn_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L1, tbFuelBurn_L1, tbTaxiBurn_L1, tbCont_L1, tbLandingWT_L1);
        }

        private void tbCont_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L1, tbFuelBurn_L1, tbTaxiBurn_L1, tbCont_L1, tbLandingWT_L1);
        }

        private void tbMTOW_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L1, tbGrossWT_L1, tbMTOW_Dif_L1);
        }

        private void tbMLW_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L1, tbLandingWT_L1, tbLandingDif_L1);
        }

        private void tbLandingWT_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L1, tbLandingWT_L1, tbLandingDif_L1);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L1, panelLandingWTLeg1);
        }

        private void tbMTOW_Dif_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L1, panelMTOW_Dif_L1);
        }

        private void tbLandingDif_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L1, panelLanding_Dif_L1);
        }

        private void tbZFWDif_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbFuelBurn_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L2, tbFuelBurn_L2, tbTaxiBurn_L2, tbCont_L2, tbLandingWT_L2);
        }

        private void tbTaxiBurn_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L2, tbFuelBurn_L2, tbTaxiBurn_L2, tbCont_L2, tbLandingWT_L2);
        }

        private void tbCont_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L2, tbFuelBurn_L2, tbTaxiBurn_L2, tbCont_L2, tbLandingWT_L2);
        }

        private void tbMTOW_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L2, tbGrossWT_L2, tbMTOW_Dif_L2);
        }

        private void tbMTOW_Dif_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L2, panelMTOW_Dif_L2);
        }

        private void tbMLW_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L2, tbLandingWT_L2, tbLandingDif_L2);
        }

        private void tbLandingWT_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L2, tbLandingWT_L2, tbLandingDif_L2);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L2, panelLandingWTLeg2);
        }

        private void tbLandingDif_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L2, panelLanding_Dif_L2);
        }

        private void tbZFWDif_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbFuelBurn_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L3, tbFuelBurn_L3, tbTaxiBurn_L3, tbCont_L3, tbLandingWT_L3);
        }

        private void tbTaxiBurn_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L3, tbFuelBurn_L3, tbTaxiBurn_L3, tbCont_L3, tbLandingWT_L3);
        }

        private void tbCont_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L3, tbFuelBurn_L3, tbTaxiBurn_L3, tbCont_L3, tbLandingWT_L3);
        }

        private void tbGrossWT_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L3, tbFuelBurn_L3, tbTaxiBurn_L3, tbCont_L3, tbLandingWT_L3);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L3, tbGrossWT_L3, tbMTOW_Dif_L3);
        }

        private void tbMTOW_Dif_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L3, panelMTOW_Dif_L3);
        }

        private void tbMLW_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L3, tbLandingWT_L3, tbLandingDif_L3);
        }

        private void tbLandingWT_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L3, tbLandingWT_L3, tbLandingDif_L3);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L3, panelLandingWTLeg3);
        }

        private void tbLandingDif_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L3, panelLanding_Dif_L3);
        }

        private void tbZFWDif_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbFuelBurn_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L4, tbFuelBurn_L4, tbTaxiBurn_L4, tbCont_L4, tbLandingWT_L4);
        }

        private void tbTaxiBurn_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L4, tbFuelBurn_L4, tbTaxiBurn_L4, tbCont_L4, tbLandingWT_L4);
        }

        private void tbCont_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L4, tbFuelBurn_L4, tbTaxiBurn_L4, tbCont_L4, tbLandingWT_L4);
        }

        private void tbMTOW_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L4, tbGrossWT_L4, tbMTOW_Dif_L4);
        }

        private void tbGrossWT_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L4, tbFuelBurn_L4, tbTaxiBurn_L4, tbCont_L4, tbLandingWT_L4);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L4, tbGrossWT_L4, tbMTOW_Dif_L4);
        }

        private void tbMTOW_Dif_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L4, panelMTOW_Dif_L4);
        }

        private void tbMLW_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L4, tbLandingWT_L4, tbLandingDif_L4);
        }

        private void tbZFWDif_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbFuelBurn_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L5, tbFuelBurn_L5, tbTaxiBurn_L5, tbCont_L5, tbLandingWT_L5);
        }

        private void tbTaxiBurn_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L5, tbFuelBurn_L5, tbTaxiBurn_L5, tbCont_L5, tbLandingWT_L5);
        }

        private void tbCont_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L5, tbFuelBurn_L5, tbTaxiBurn_L5, tbCont_L5, tbLandingWT_L5);
        }

        private void tbMTOW_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L5, tbGrossWT_L5, tbMTOW_Dif_L5);
        }

        private void tbGrossWT_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L5, tbFuelBurn_L5, tbTaxiBurn_L5, tbCont_L5, tbLandingWT_L5);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L5, tbGrossWT_L5, tbMTOW_Dif_L5);
        }

        private void tbMTOW_Dif_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L5, panelMTOW_Dif_L5);
        }

        private void tbMLW_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L5, tbLandingWT_L5, tbLandingDif_L5);
        }

        private void tbLandingWT_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L5, tbLandingWT_L5, tbLandingDif_L5);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L5, panelLandingWTLeg5);
        }

        private void tbLandingDif_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L5, panelLanding_Dif_L5);
        }

        private void tbZFWDif_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbZFW_L5_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L5, tbBags_L5, tbCargo_L5, tbEquip_L5, tbAWI_L5, tbZFW_L5, tbZFWDif_L5);
        }

        private void tbZFW_L1_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L1, tbBags_L1, tbCargo_L1, tbEquip_L1, tbAWI_L1, tbZFW_L1, tbZFWDif_L1);
        }

        private void tbZFW_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L2, tbBags_L2, tbCargo_L2, tbEquip_L2, tbAWI_L2, tbZFW_L2, tbZFWDif_L2);
        }

        private void tbZFW_L3_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L3, tbBags_L3, tbCargo_L3, tbEquip_L3, tbAWI_L3, tbZFW_L3, tbZFWDif_L3);
        }

        private void tbZFW_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L4, tbBags_L4, tbCargo_L4, tbEquip_L4, tbAWI_L4, tbZFW_L4, tbZFWDif_L4);
        }

        private void tbFuelBurn_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L6, tbFuelBurn_L6, tbTaxiBurn_L6, tbCont_L6, tbLandingWT_L6);
        }

        private void tbTaxiBurn_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L6, tbFuelBurn_L6, tbTaxiBurn_L6, tbCont_L6, tbLandingWT_L6);
        }

        private void tbCont_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L6, tbFuelBurn_L6, tbTaxiBurn_L6, tbCont_L6, tbLandingWT_L6);
        }

        private void tbMTOW_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L6, tbGrossWT_L6, tbMTOW_Dif_L6);
        }

        private void tbGrossWT_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L6, tbFuelBurn_L6, tbTaxiBurn_L6, tbCont_L6, tbLandingWT_L6);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L6, tbGrossWT_L6, tbMTOW_Dif_L6);
        }

        private void tbMTOW_Dif_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbMTOW_Dif_L6, panelMTOW_Dif_L6);
        }

        private void tbMLW_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L6, tbLandingWT_L6, tbLandingDif_L6);
        }

        private void tbLandingWT_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L6, tbLandingWT_L6, tbLandingDif_L6);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L6, panelLandingWTLeg6);
        }

        private void tbLandingDif_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L6, panelLanding_Dif_L6);
        }

        private void tbZFW_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateZeroFuelDifference(tbAircraftWeight, tbPax_L6, tbBags_L6, tbCargo_L6, tbEquip_L6, tbAWI_L6, tbZFW_L6, tbZFWDif_L6);
        }

        private void tbZFWDif_L6_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbZFWDif_L1, panelZFW_Dif_L1);
        }

        private void tbGrossWT_L2_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.CalculateLandingWeight(tbGrossWT_L2, tbFuelBurn_L2, tbTaxiBurn_L2, tbCont_L2, tbLandingWT_L2);
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L2, tbGrossWT_L2, tbMTOW_Dif_L2);
        }

        private void tbLandingWT_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlanCalculations.LandingWeightDifference(tbMLW_L4, tbLandingWT_L4, tbLandingDif_L4);
            LoadPlannerDesign.OverweightColor(tbLandingWT_L4, panelLandingWTLeg4);
        }

        private void tbLandingDif_L4_TextChanged(object sender, EventArgs e)
        {
            LoadPlannerDesign.OverweightColor(tbLandingDif_L1, panelLanding_Dif_L1);
        }

        private void tbMTOW_L3_TextChanged_1(object sender, EventArgs e)
        {
            LoadPlanCalculations.MaxTakeOffDifference(tbMTOW_L3, tbGrossWT_L3, tbMTOW_Dif_L3);
        }

        private void menuReturnFuel_Click(object sender, EventArgs e)
        {
            ReturnFuel();
        }

        private void btnUpdateRampBoard_Click(object sender, EventArgs e)
        {
            LoadPlannerBoardUpdates.RampBoardPusher(StoreLoadPlannerUpdaterRampDetails(), cbFlightNumber.Text, dateTimeLoadPlanner.Value.Date);
        }

        private void btnUpdateCargoBoard_Click(object sender, EventArgs e)
        {
            LoadPlannerBoardUpdates.CargoBoardPusher(StoreLoadPlannerUpdaterCargoDetails(), cbFlightNumber.Text, dateTimeLoadPlanner.Value.Date);
        }

        private void LoadPlanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                ReturnFuel();
            }
        }

        private void menuManageSchedule_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<SchedulerALC>().FirstOrDefault();
            if(!FormOpener.CheckFormOpen(form))
            {
                DateTimeFormater.DateDisplay = dateTimeLoadPlanner.Value.Date;
                new SchedulerALC().Show();
            }
        }

        private void subMenuflightPlan_Click(object sender, EventArgs e)
        {
            FlightPlanLoader loadFlightPlan = new FlightPlanLoader();
            loadFlightPlan.NumberOfLegs = NumberOfLegs;
            loadFlightPlan.LoadPlannerFlightNumber = cbFlightNumber.Text;
            loadFlightPlan.ShowDialog();
            if (loadFlightPlan.FuelBurn.Any())
            {
                if (NumberOfLegs == 2)
                {
                    tbFuelBurn_L1.Text = loadFlightPlan.FuelBurn[0];
                    tbFuelBurn_L2.Text = loadFlightPlan.FuelBurn[1];

                    tbCont_L1.Text = loadFlightPlan.Contingency[0];
                    tbCont_L2.Text = loadFlightPlan.Contingency[1];

                    tbFuel_L1.Text = loadFlightPlan.MinimumFuel[0];
                    tbFuel_L2.Text = loadFlightPlan.MinimumFuel[1];

                    tbTaxiBurn_L1.Text = loadFlightPlan.TaxiBurn[0];
                    tbTaxiBurn_L2.Text = loadFlightPlan.TaxiBurn[1];

                    tbMTOW_L1.Text = loadFlightPlan.MTOW[0];
                    tbMTOW_L2.Text = loadFlightPlan.MTOW[1];

                    tbMLW_L1.Text = loadFlightPlan.MLW[0];
                    tbMLW_L2.Text = loadFlightPlan.MLW[1];
                }
                else if (NumberOfLegs == 3)
                {
                    tbFuelBurn_L1.Text = loadFlightPlan.FuelBurn[0];
                    tbFuelBurn_L2.Text = loadFlightPlan.FuelBurn[1];
                    tbFuelBurn_L3.Text = loadFlightPlan.FuelBurn[2];

                    tbCont_L1.Text = loadFlightPlan.Contingency[0];
                    tbCont_L2.Text = loadFlightPlan.Contingency[1];
                    tbCont_L3.Text = loadFlightPlan.Contingency[2];

                    tbFuel_L1.Text = loadFlightPlan.MinimumFuel[0];
                    tbFuel_L2.Text = loadFlightPlan.MinimumFuel[1];
                    tbFuel_L3.Text = loadFlightPlan.MinimumFuel[2];

                    tbTaxiBurn_L1.Text = loadFlightPlan.TaxiBurn[0];
                    tbTaxiBurn_L2.Text = loadFlightPlan.TaxiBurn[1];
                    tbTaxiBurn_L3.Text = loadFlightPlan.TaxiBurn[2];

                    tbMTOW_L1.Text = loadFlightPlan.MTOW[0];
                    tbMTOW_L2.Text = loadFlightPlan.MTOW[1];
                    tbMTOW_L3.Text = loadFlightPlan.MTOW[2];

                    tbMLW_L1.Text = loadFlightPlan.MLW[0];
                    tbMLW_L2.Text = loadFlightPlan.MLW[1];
                    tbMLW_L3.Text = loadFlightPlan.MLW[2];
                }
                else if (NumberOfLegs == 4)
                {
                    tbFuelBurn_L1.Text = loadFlightPlan.FuelBurn[0];
                    tbFuelBurn_L2.Text = loadFlightPlan.FuelBurn[1];
                    tbFuelBurn_L3.Text = loadFlightPlan.FuelBurn[2];
                    tbFuelBurn_L4.Text = loadFlightPlan.FuelBurn[3];

                    tbCont_L1.Text = loadFlightPlan.Contingency[0];
                    tbCont_L2.Text = loadFlightPlan.Contingency[1];
                    tbCont_L3.Text = loadFlightPlan.Contingency[2];
                    tbCont_L4.Text = loadFlightPlan.Contingency[3];


                    tbFuel_L1.Text = loadFlightPlan.MinimumFuel[0];
                    tbFuel_L2.Text = loadFlightPlan.MinimumFuel[1];
                    tbFuel_L3.Text = loadFlightPlan.MinimumFuel[2];
                    tbFuel_L4.Text = loadFlightPlan.MinimumFuel[3];

                    tbTaxiBurn_L1.Text = loadFlightPlan.TaxiBurn[0];
                    tbTaxiBurn_L2.Text = loadFlightPlan.TaxiBurn[1];
                    tbTaxiBurn_L3.Text = loadFlightPlan.TaxiBurn[2];
                    tbTaxiBurn_L4.Text = loadFlightPlan.TaxiBurn[3];

                    tbMTOW_L1.Text = loadFlightPlan.MTOW[0];
                    tbMTOW_L2.Text = loadFlightPlan.MTOW[1];
                    tbMTOW_L3.Text = loadFlightPlan.MTOW[2];
                    tbMTOW_L4.Text = loadFlightPlan.MTOW[3];

                    tbMLW_L1.Text = loadFlightPlan.MLW[0];
                    tbMLW_L2.Text = loadFlightPlan.MLW[1];
                    tbMLW_L3.Text = loadFlightPlan.MLW[2];
                    tbMLW_L4.Text = loadFlightPlan.MLW[3];
                }
                else if (NumberOfLegs == 5)
                {
                    tbFuelBurn_L1.Text = loadFlightPlan.FuelBurn[0];
                    tbFuelBurn_L2.Text = loadFlightPlan.FuelBurn[1];
                    tbFuelBurn_L3.Text = loadFlightPlan.FuelBurn[2];
                    tbFuelBurn_L4.Text = loadFlightPlan.FuelBurn[3];
                    tbFuelBurn_L5.Text = loadFlightPlan.FuelBurn[4];

                    tbCont_L1.Text = loadFlightPlan.Contingency[0];
                    tbCont_L2.Text = loadFlightPlan.Contingency[1];
                    tbCont_L3.Text = loadFlightPlan.Contingency[2];
                    tbCont_L4.Text = loadFlightPlan.Contingency[3];
                    tbCont_L5.Text = loadFlightPlan.Contingency[4];


                    tbFuel_L1.Text = loadFlightPlan.MinimumFuel[0];
                    tbFuel_L2.Text = loadFlightPlan.MinimumFuel[1];
                    tbFuel_L3.Text = loadFlightPlan.MinimumFuel[2];
                    tbFuel_L4.Text = loadFlightPlan.MinimumFuel[3];
                    tbFuel_L5.Text = loadFlightPlan.MinimumFuel[4];

                    tbTaxiBurn_L1.Text = loadFlightPlan.TaxiBurn[0];
                    tbTaxiBurn_L2.Text = loadFlightPlan.TaxiBurn[1];
                    tbTaxiBurn_L3.Text = loadFlightPlan.TaxiBurn[2];
                    tbTaxiBurn_L4.Text = loadFlightPlan.TaxiBurn[3];
                    tbTaxiBurn_L5.Text = loadFlightPlan.TaxiBurn[4];

                    tbMTOW_L1.Text = loadFlightPlan.MTOW[0];
                    tbMTOW_L2.Text = loadFlightPlan.MTOW[1];
                    tbMTOW_L3.Text = loadFlightPlan.MTOW[2];
                    tbMTOW_L4.Text = loadFlightPlan.MTOW[3];
                    tbMTOW_L5.Text = loadFlightPlan.MTOW[4];

                    tbMLW_L1.Text = loadFlightPlan.MLW[0];
                    tbMLW_L2.Text = loadFlightPlan.MLW[1];
                    tbMLW_L3.Text = loadFlightPlan.MLW[2];
                    tbMLW_L4.Text = loadFlightPlan.MLW[3];
                    tbMLW_L5.Text = loadFlightPlan.MLW[4];
                }
                else if (NumberOfLegs == 6)
                {
                    tbFuelBurn_L1.Text = loadFlightPlan.FuelBurn[0];
                    tbFuelBurn_L2.Text = loadFlightPlan.FuelBurn[1];
                    tbFuelBurn_L3.Text = loadFlightPlan.FuelBurn[2];
                    tbFuelBurn_L4.Text = loadFlightPlan.FuelBurn[3];
                    tbFuelBurn_L5.Text = loadFlightPlan.FuelBurn[4];
                    tbFuelBurn_L6.Text = loadFlightPlan.FuelBurn[5];

                    tbCont_L1.Text = loadFlightPlan.Contingency[0];
                    tbCont_L2.Text = loadFlightPlan.Contingency[1];
                    tbCont_L3.Text = loadFlightPlan.Contingency[2];
                    tbCont_L4.Text = loadFlightPlan.Contingency[3];
                    tbCont_L5.Text = loadFlightPlan.Contingency[4];
                    tbCont_L6.Text = loadFlightPlan.Contingency[5];


                    tbFuel_L1.Text = loadFlightPlan.MinimumFuel[0];
                    tbFuel_L2.Text = loadFlightPlan.MinimumFuel[1];
                    tbFuel_L3.Text = loadFlightPlan.MinimumFuel[2];
                    tbFuel_L4.Text = loadFlightPlan.MinimumFuel[3];
                    tbFuel_L5.Text = loadFlightPlan.MinimumFuel[4];
                    tbFuel_L6.Text = loadFlightPlan.MinimumFuel[5];

                    tbTaxiBurn_L1.Text = loadFlightPlan.TaxiBurn[0];
                    tbTaxiBurn_L2.Text = loadFlightPlan.TaxiBurn[1];
                    tbTaxiBurn_L3.Text = loadFlightPlan.TaxiBurn[2];
                    tbTaxiBurn_L4.Text = loadFlightPlan.TaxiBurn[3];
                    tbTaxiBurn_L5.Text = loadFlightPlan.TaxiBurn[4];
                    tbTaxiBurn_L6.Text = loadFlightPlan.TaxiBurn[5];

                    tbMTOW_L1.Text = loadFlightPlan.MTOW[0];
                    tbMTOW_L2.Text = loadFlightPlan.MTOW[1];
                    tbMTOW_L3.Text = loadFlightPlan.MTOW[2];
                    tbMTOW_L4.Text = loadFlightPlan.MTOW[3];
                    tbMTOW_L5.Text = loadFlightPlan.MTOW[4];
                    tbMTOW_L6.Text = loadFlightPlan.MTOW[5];

                    tbMLW_L1.Text = loadFlightPlan.MLW[0];
                    tbMLW_L2.Text = loadFlightPlan.MLW[1];
                    tbMLW_L3.Text = loadFlightPlan.MLW[2];
                    tbMLW_L4.Text = loadFlightPlan.MLW[3];
                    tbMLW_L5.Text = loadFlightPlan.MLW[4];
                    tbMLW_L6.Text = loadFlightPlan.MLW[5];
                }
                else
                {
                    MessageBox.Show("Please check number of legs. To use this tool the number of legs needs to be between 2-6", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show($"Flight {loadFlightPlan.FlightNumber} Flight Plan Loaded Sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadPlanner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbPax_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAircraftWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPax_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPax_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPax_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPax_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPax_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbBags_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCargo_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbEquip_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbAWI_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuel_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbFuelBurn_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTaxiBurn_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbCont_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMTOW_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbMLW_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbPaxNo_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbSeatpacks_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void tbTotalWT_L6_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyIntValues(e);
        }

        private void openRampBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<RampBoard>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                RampBoard rampBoard = new RampBoard();
                var screen3 = Screen.FromPoint(Cursor.Position);
                rampBoard.StartPosition = FormStartPosition.Manual;
                rampBoard.Left = screen3.Bounds.Left + screen3.Bounds.Width / 2 - rampBoard.Width / 2;
                rampBoard.Top = screen3.Bounds.Top + screen3.Bounds.Height / 2 - rampBoard.Height / 2;

                rampBoard.FullName = FullName;
                rampBoard.UserID = UserID;
                rampBoard.RoleID = RoleID;
                Permissions loadPermissions = new Permissions();
                loadPermissions.ListOfMenus.Add(rampBoard.menuStripDelays, typeof(ToolStripMenuItem));
                loadPermissions.ListOfMenus.Add(rampBoard.subMenuMasterSchedule, typeof(ToolStripMenuItem));
                loadPermissions.MenuStripPermission();
                rampBoard.Show();
            }
        }

        private void openCargoBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<CargoBoard>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                CargoBoard cargoBoard = new CargoBoard();
                var screen2 = Screen.FromPoint(Cursor.Position);
                cargoBoard.StartPosition = FormStartPosition.Manual;
                cargoBoard.Left = screen2.Bounds.Left + screen2.Bounds.Width / 2 - cargoBoard.Width / 2;
                cargoBoard.Top = screen2.Bounds.Top + screen2.Bounds.Height / 2 - cargoBoard.Height / 2;

                cargoBoard.FullName = FullName;
                cargoBoard.UserID = UserID;
                cargoBoard.RoleID = RoleID;
                cargoBoard.Show();
            }
        }

        private void menuChangeLog_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Changelog>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                Changelog changeLog = new Changelog();

                var screen = Screen.FromPoint(Cursor.Position);
                changeLog.StartPosition = FormStartPosition.Manual;
                changeLog.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - changeLog.Width / 2;
                changeLog.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - changeLog.Height / 2;
                changeLog.Show();
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<About>().FirstOrDefault();
            if (!FormOpener.CheckFormOpen(form))
            {
                About about = new About();

                var screen = Screen.FromPoint(Cursor.Position);
                about.StartPosition = FormStartPosition.Manual;
                about.Left = screen.Bounds.Left + screen.Bounds.Width / 2 - about.Width / 2;
                about.Top = screen.Bounds.Top + screen.Bounds.Height / 2 - about.Height / 2;
                about.Show();
            }
        }
    }
}
