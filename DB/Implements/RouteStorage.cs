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
    }
}
