using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class FlightPlanLoader : Form
    {
        public int NumberOfLegs { get; set; }
        public List<string> FuelBurn = new List<string>();
        public List<string> Contingency = new List<string>();
        public List<string> MinimumFuel = new List<string>();
        public List<string> TaxiBurn = new List<string>();
        public List<string> MTOW = new List<string>();
        public List<string> MLW = new List<string>();
        public string OEW { get; set; }
        public string FlightNumber { get; set; }
        public string LoadPlannerFlightNumber { get; set; }
        public FlightPlanLoader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Extract PDF. Path will be whats in Textbox, as its drag and drop. Check to make sure its a valid 
        /// 705 flight plan. If its not, return false and provide error message. If its blank, return true and given
        /// no value. If its valid, return true and pass values to other form. 
        /// </summary>
        /// <returns></returns>
        private bool PDFExtracter()
        {
            // Store textbox as path. 
            string path = tbFlightPlan.Text;

            // Make sure path isn't null. 
            if (!string.IsNullOrEmpty(path))
            {
                PdfReader pdfReader = new PdfReader(path);
                PdfDocument pdfDoc = new PdfDocument(pdfReader);

                // Loop through 9 pages of the PDF Flight Plan. 
                for (int page = 1; page <= 9; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageContent = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);

                    // Store extracted text from PDF into loadplan string. 
                    string loadplan = pageContent;

                    try
                    {
                        // Look for index of REGISTRATION and move 15 spaces from there. This will get flight number. 
                        string storeFlightNumberText = loadplan.Substring(loadplan.IndexOf("REGISTRATION") + 15);
                        var storeFlightNumber = storeFlightNumberText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                        // Add JV to found flight number. 
                        FlightNumber = "JV" + storeFlightNumber[1];

                        // Check if flight number is equal to the flight number on loadplanner. 
                        if (LoadPlannerFlightNumber == FlightNumber)
                        {
                            // Check if loop is on page 1. 
                            if (page == 1)
                            {
                                // Find location of all searched indexes. These will get the specificed number of what we are looking for on PDF Flight plan. 
                                // Same process as above for finding Flight Number. 

                                string findDestinationText = loadplan.Substring(loadplan.IndexOf("DESTINATION"));
                                var storeFuelBurn = findDestinationText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                string findContigencyText = loadplan.Substring(loadplan.IndexOf("ADDITIONAL"));
                                var storeContigency = findContigencyText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                string findMinimumFuelText = loadplan.Substring(loadplan.IndexOf("REQ'D") + 9);
                                var storeMinimumFuel = findMinimumFuelText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                string findTaxiBurnText = loadplan.Substring(loadplan.IndexOf("TAXI"));
                                var storeTaxiBurn = findTaxiBurnText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                string FinddMTOW_Text = loadplan.Substring(loadplan.IndexOf("MTOW"));
                                var storeMTOW = FinddMTOW_Text.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                string findMLW_Text = loadplan.Substring(loadplan.IndexOf("LANDING"));
                                var storeLandingWeight = findMLW_Text.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                // Loop through the number of legs thats on LoadPlanner and store extracted data for each leg. 
                                for (int i = 1; i <= NumberOfLegs; i++)
                                {
                                    FuelBurn.Add(storeFuelBurn[i]);
                                    Contingency.Add(storeContigency[i]);
                                    MinimumFuel.Add(storeMinimumFuel[i]);
                                    TaxiBurn.Add(storeTaxiBurn[i]);
                                    MTOW.Add(storeMTOW[i]);
                                    MLW.Add(storeLandingWeight[i]);
                                }

                                // Check if loop is on page 1. 
                                if (page == 9)
                                {
                                    // Same process as above for finding Flight Number. 
                                    string findOEWText = loadplan.Substring(loadplan.IndexOf("AOEW"));
                                    var storeOEW = findOEWText.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);

                                    OEW = storeOEW[1];
                                }

                                return true;
                            }
                        }
                        else if (LoadPlannerFlightNumber != FlightNumber)
                        {
                            MessageBox.Show("Flight Plan doesn't match Loadplanner Flight Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Flight Plan. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return true;
            }
            return true;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            // Open Flight Explorer to search for Flight Plan. 
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                if (DialogResult.OK == openFile.ShowDialog())
                {
                    tbFlightPlan.Text = openFile.FileName;
                }
            }
        }

        private void tbFlightPlan_DragDrop(object sender, DragEventArgs e)
        {
            // Store file in array. Then store the first file in textbox for path of file. 
            string[] file = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (file != null && file.Any())
            {
                tbFlightPlan.Text = file.First();
            }
        }

        private void tbFlightPlan_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void FlightPlanLoader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PDFExtracter())
            {
                tbFlightPlan.Clear();
                e.Cancel = true;
            }
            else
            {

            }
        }
    }
}
