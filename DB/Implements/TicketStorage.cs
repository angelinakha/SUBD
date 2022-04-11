using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Tables;

namespace DB.Implements
{
    public class TicketStorage
    {
        public List<Ticket> GetFullList()
        {
            using var context = new Database();
            return context.Tickets
            .ToList();
        }
        public List<Ticket> GetFiltredList(string str)
        {
            using var context = new Database();
            return context.Tickets.Where(r => r.FlightNumber.Contains(str))
            .ToList();
        }
        public Ticket GetElement(int id)
        {
            using var context = new Database();
            var element = context.Tickets
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Ticket model)
        {
            using var context = new Database();
            context.Tickets.Add(model);
            context.SaveChanges();
        }
        public void Delete(Ticket model)
        {
            using var context = new Database();
            Ticket element = context.Tickets.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Tickets.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void Update(Ticket model)
        {
            using var context = new Database();
            var element = context.Tickets.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.TicketPrice = model.TicketPrice;
            element.FlightNumber = model.FlightNumber;
            element.FlightDate = model.FlightDate;
            context.SaveChanges();
        }
    }
}
