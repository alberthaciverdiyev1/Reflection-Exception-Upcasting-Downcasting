using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection__Exception__Upcasting__Downcasting.Models
{
   public class Pineapple : Fruit
    {


        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Tursh");
        }
    }
}
