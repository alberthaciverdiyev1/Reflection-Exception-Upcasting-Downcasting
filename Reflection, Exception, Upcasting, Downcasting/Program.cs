using Reflection__Exception__Upcasting__Downcasting.Models;

namespace Reflection__Exception__Upcasting__Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[3];
            Apple apple1 = new Apple();
            Orange orange1 = new Orange();
            Pineapple pineapple1 = new Pineapple();

            apple1.Price = 1.12d;
            apple1.Sort = "Samarinka";
            apple1.VitaminA = 2;
            apple1.VitaminB = 0;

            orange1.Price = 2.25d;
            orange1.Sort = "Narinci Orange";
            orange1.VitaminC = 100;

            pineapple1.Price = 5.67d;
            pineapple1.Sort = "Bravodaki";
            pineapple1.VitaminD = 7;
            pineapple1.VitaminE = 3;

            Basket[0] = apple1;
            Basket[1] = orange1;
            Basket[2] = orange1;


            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine("Type: " + type.Name);
                foreach (var field in type.GetProperties())
                {
                    Console.WriteLine(field.Name + ": " + field.GetValue(fruit));
                   
                } fruit.Taste();

                Console.WriteLine("_________________________");
                Console.WriteLine(" ");
            }

        }
    }
}
