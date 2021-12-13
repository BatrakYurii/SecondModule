using SecondModule.Dishes;
using SecondModule.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule.Human
{
    public class Cook : Human, ICook
    {
        public Cook(string name)
            : base(name)
        {
        }

        public Dish CookDish(string name, Product[] products)
        {
            return new Dish(name, products);
        }

        public void DecorateDish(Dish dish)
        {
            Console.WriteLine($"Повар {Name} украсил блюдо {dish.Name}.");
        }
    }
}
