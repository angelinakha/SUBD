using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Tables;

namespace DB.Implements
{
    public class RouteStorage
    {
        public List<Route> GetFullList()
        {
            using var context = new Database();
            return context.Routes
            .ToList();
        }
        public List<Route> GetFiltredList(string str)
        {
            using var context = new Database();
            return context.Routes.Where(r => r.DeparturePoint.Contains(str))
            .ToList();
        }
        public Route GetElement(int id)
        {
            using var context = new Database();
            var element = context.Routes
            .FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            return element;
        }
        public void Insert(Route model)
        {
            using var context = new Database();
            context.Routes.Add(model);
            context.SaveChanges();
        }
        public void Delete(Route model)
        {
            using var context = new Database();
            Route element = context.Routes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Routes.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public void Update(Route model)
        {
            using var context = new Database();
            var element = context.Routes.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.DeparturePoint = model.DeparturePoint;
            element.Destination = model.Destination;
            element.FlightDate = model.FlightDate;
            context.SaveChanges();
        }
    }
}
