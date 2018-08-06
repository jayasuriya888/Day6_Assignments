using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assignment_02_23_07_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDetail e1 = new PizzaDetail { PizzaName ="AAA Pizza", PizzaType = "NonVeg", PizzaToppings = "Onion", PizzaSize = 'L', PizzaPrice = 900 };
            PizzaDetail e2 = new PizzaDetail { PizzaName = "Chicken Pizza", PizzaType = "NonVeg", PizzaToppings = "Chicken", PizzaSize = 'M', PizzaPrice = 800 };
            CodeDBEntities db = new CodeDBEntities();
            db.PizzaDetails.Add(e1);
            db.PizzaDetails.Add(e2);
            var reult = db.SaveChanges();
            if (reult > 0)
                Console.WriteLine("Data Inserted.");
        }
    }
}
