using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection__Exception__Upcasting__Downcasting.Models
{
  public class Orange : Fruit
    {

        public int VitaminC { get; set; }
        public override void Taste()
        {
            Console.WriteLine("Shirin");
        }
    }
}
