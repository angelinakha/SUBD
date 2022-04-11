using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Tables;

namespace DB.Implements
{
    public class PilotStorage
    {
        public List<Pilot> GetFullList()
        {
            using var context = new Database();
            return context.Pilots
            .ToList();
        }
        public List<Pilot> GetFiltredList(string str)
        {
            using var context = new Database();
            return context.Pilots.Where(r => r.NamePilot.Contains(str))
            .ToList();
        }
        public Pilot GetElement(int id)
        {
            using var context = new Database();
            var element = context.Pilots
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Pilot model)
        {
            using var context = new Database();
            context.Pilots.Add(model);
            context.SaveChanges();
        }
        public void Delete(Pilot model)
        {
            using var context = new Database();
            Pilot element = context.Pilots.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Pilots.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void Update(Pilot model)
        {
            using var context = new Database();
            var element = context.Pilots.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.NamePilot = model.NamePilot;
            context.SaveChanges();
        }
    }
}
