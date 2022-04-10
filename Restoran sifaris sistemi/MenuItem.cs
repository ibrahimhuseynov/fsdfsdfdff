using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_sifaris_sistemi
{
    internal class MenuItem
    {
        public string No { get; set; }  
        public string Name { get; set; }    
        public double Price { get; set; }   
        public void  CheakNo(int no, Types type1)
        {
            if (no > 100)
            {
                switch (type1)
                {
                    case Types.sup:
                        Console.WriteLine("SU"+No);
                        break;
                    case Types.anayemek:
                        Console.WriteLine("SU" + No);
                        break;
                    case Types.icki:
                        Console.WriteLine("SU" + No);
                        break;
                    case Types.desert:
                        Console.WriteLine("SU" + No);
                        break;
                    default:
                        Console.WriteLine("bele bir mehsul yoxdur");
                        break;
                }
            }
        }
        public void CheaName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (name == Name)
                {
                    throw new Exceptons("bu name artiq movcududur");
                }
                else
                {
                    Console.WriteLine(name);
                }
            }
             else throw new Exceptons("name null ola bilmez");
        }
    }
}
