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
    }
}
