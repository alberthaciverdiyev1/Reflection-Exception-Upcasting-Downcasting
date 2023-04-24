using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection__Exception__Upcasting__Downcasting.Models
{
    public abstract class Fruit
    {
        public double Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();

    }
}
