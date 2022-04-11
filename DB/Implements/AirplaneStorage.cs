using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Tables;

namespace DB.Implements
{
    public class AirplaneStorage
    {
        public List<Airplane> GetFullList()
        {
            using var context = new Database();
            return context.Airplanes
            .ToList();
        }
        public List<Airplane> GetFiltredList(string str)
        {
            using var context = new Database();
            return context.Airplanes.Where(r => r.Aircraftname.Contains(str))
            .ToList();
        }
        public Airplane GetElement(int id)
        {
            using var context = new Database();
            var element = context.Airplanes
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Airplane model)
        {
            using var context = new Database();
            context.Airplanes.Add(model);
            context.SaveChanges();
        }
        public void Delete(Airplane model)
        {
            using var context = new Database();
            Airplane element = context.Airplanes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Airplanes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void Update(Airplane model)
        {
            using var context = new Database();
            var element = context.Airplanes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Aircraftname = model.Aircraftname;
            element.MaxNumberOfSeats = model.MaxNumberOfSeats;
            context.SaveChanges();
        }
    }
}
