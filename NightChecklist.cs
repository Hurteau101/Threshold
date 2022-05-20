using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_Threshold
{
    public partial class NightChecklist : Form
    {
        public NightChecklist()
        {
            InitializeComponent();
        }

        private void NightChecklist_Load(object sender, EventArgs e)
        {
            // Format the DateTime. Also automatically set date to whatever date was on Ramp Board. 
            DateTimeFormater.AutoSetDate(dateCheckList);
            DateTimeFormater.DateTimeDisplay(dateCheckList);
            LoadDataNightList();
        }
        
        private void LoadDataNightList()
        {
            // Load Night Checklist. 
            NightTasks loadNightList = new NightTasks(dateCheckList.Value.Date, rchTbSeatpacks.Text, rchTbTasks.Text);
            loadNightList.LoadNightSeatpacks();
            
            // Load the night seatpacks and night task. If the method returns false, there is no data, so clear the textbox as well as the updated time. 
            if(loadNightList.LoadNightTask())
            {
                rchTbTasks.Text = loadNightList.NightTask;
            }
            else
            {
                rchTbTasks.Text = String.Empty;
            }
            if(loadNightList.LoadNightSeatpacks())
            {
                rchTbSeatpacks.Text = loadNightList.Seatpacks;
            }
            else
            {
                rchTbSeatpacks.Text = String.Empty;
            }
            if(loadNightList.LoadUpdateTime())
            {
                lblUpdatedTime.Text = $"Last Updated Time: {loadNightList.Time}";
                lblUpdatedTime.Visible = true;
            }
            else
            {
                lblUpdatedTime.Text= String.Empty;
                lblUpdatedTime.Visible = false; 
            }
        }

        private void dateCheckList_ValueChanged(object sender, EventArgs e)
        {
            LoadDataNightList();
            NightTasks.DateCheckValid(dateCheckList.Value.Date, rchTbTasks, rchTbSeatpacks, btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NightTasks loadNightList = new NightTasks(dateCheckList.Value.Date, rchTbSeatpacks.Text, rchTbTasks.Text);
            loadNightList.SaveChanges();
            loadNightList.LoadUpdateTime();
            lblUpdatedTime.Text = $"Last Updated Time: {loadNightList.Time}";
        }
    }
}
