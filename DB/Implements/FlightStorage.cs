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
        public void Insert(Flight model)
        {
            using var context = new Database();
            context.Flights.Add(model);
            context.SaveChanges();
        }
        public void Delete(Flight model)
        {
            using var context = new Database();
            Flight element = context.Flights.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Flights.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void Update(Flight model)
        {
            using var context = new Database();
            var element = context.Flights.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.FlightDate = model.FlightDate;
            element.DestinationTime = model.DestinationTime;
            element.Pilot = model.Pilot;
            element.Route = model.Route;
            element.Airplane = model.Airplane;
            element.Ticket = model.Ticket;
            element.OccupPlaces = model.OccupPlaces;
            context.SaveChanges();
        }
    }
}
