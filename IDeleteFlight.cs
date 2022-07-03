using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Threshold
{
    public interface IDeleteFlight
    {
         DateTime Date { get; set; }
         string FlightNumber { get; set; }

         bool DeletingFight(string flightNumber, DateTime date);
    }
}
