using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Threshold
{
    public abstract class DeleteFlight
    {
        /// <summary>
        /// Abstract method, to delete flights. 
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <param name="date"></param>
        public abstract void DeletingFight(string flightNumber, DateTime date);
    }
}
