using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Tables
{
    public class Ticket
    {
        public int Id { get; set; }
        public decimal TicketPrice { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }

    }
}
