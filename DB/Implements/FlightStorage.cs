using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Tables;

namespace DB.Implements
{
    public class FlightStorage
    {
        public List<Flight> GetFullList()
        {
            using var context = new Database();
            return context.Flights
            .ToList();
        }
        public List<Flight> GetFiltredList(string str)
        {
            using var context = new Database();
            return context.Flights.Where(r => r.Id.Contains(str))
            .ToList();
        }
        public Flight GetElement(string id)
        {
            using var context = new Database();
            var element = context.Flights
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
    }
}
