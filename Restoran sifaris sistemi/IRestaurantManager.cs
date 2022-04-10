using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_sifaris_sistemi
{
    internal class IRestaurantManager
    {
       public int MenuItems { get; set; }
        public string orders { get; set; }  
        public List<Order> orders1 = new List<Order>();
        public void AddOrder()
        {
            orders1.Add(new Order());
        }

        public void RemoveOrder(string order)
        {
            if (string.IsNullOrWhiteSpace(order))
                throw new Exception("xeta");
            var result = orders1.Find(x => x.orders ==order);
            if (result == null)
            {
                throw new Exception("xeta bas verdi");
            }
             orders.Remove(result);
        }
        List<DateTime> datetimes = new List<DateTime>();
        public List<Order> orders2 = new List<Order>();
        public List<Order> OrderItems = new List<Order>();
        public void GetOrdersByDatesInterval( DateTime time)
        {
            while (time==DateTime.Now)
            {
                OrderItems.Add(new Order());    
            }
            
        }
        public void GetOrderByDate(DateTime time1)
        {
            while (time1 == DateTime.Today)
            {
                OrderItems.Add(new Order());
            }
        }

    }
}
