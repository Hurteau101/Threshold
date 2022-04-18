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
            DateTimeFormater.AutoSetDate(dateCheckList);
            LoadDataNightList();
        }

        private void LoadDataNightList()
        {
            // Load Night Checklist. 
            NightTasks loadNightList = new NightTasks();
            loadNightList.LoadNightTask(dateCheckList.Value.Date, rchTbTasks);
            loadNightList.LoadNightSeatpacks(dateCheckList.Value.Date, rchTbSeatpacks);
        }

        private void dateCheckList_ValueChanged(object sender, EventArgs e)
        {
            LoadDataNightList();
            NightTasks.DateCheckValid(dateCheckList.Value.Date, rchTbTasks, rchTbSeatpacks, btnSave);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NightTasks.SaveChanges(dateCheckList.Value.Date, rchTbSeatpacks, rchTbTasks);
        }
    }
}
