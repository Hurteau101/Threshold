using System.Windows.Forms;

namespace Perimeter_Threshold
{
    class FormOpener
    {
        public Form form { get; set; }

        /// <summary>
        /// Check if form is open. If it's not, return false to allow form to be open.
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static bool CheckFormOpen(Form form)
        {
            if (form != null)
            {
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }

                form.Activate();
                return true;
            }

            return false; 
        }
    }
}
