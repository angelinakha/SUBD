﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Tables
{
    public class Route
    {
        public int Id { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime DepartureTime { get; set; }

    }
}
