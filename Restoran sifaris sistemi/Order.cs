using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_sifaris_sistemi
{
    internal class Order
    {
        public int No { get; set; } 
        public List<Order> OrderItems=new List<Order>();
        public string orders { get; set; }
        public double TotalAmount { get; set; } 
        public DateTime Date { get; set; }
        int count = 0;
        public Order()
        {
            count++;
            No = count;
        }
    }
}
