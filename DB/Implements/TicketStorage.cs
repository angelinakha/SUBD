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
    }
}
