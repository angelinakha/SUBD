using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Tables
{
    public class Flight
    {
        public string Id { get; set; }
		public DateTime FlightDate { get; set; }
		public DateTime DestinationTime { get; set; }
		public int IdPilot { get; set; }
		public int IdRoute{ get; set; }
		public int IdAirplane { get; set; }
		public int RouteId { get; set; }
		public int OccupPlaces { get; set; }

    }
}
