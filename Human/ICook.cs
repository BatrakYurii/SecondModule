using SecondModule.Dishes;
using SecondModule.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule.Human
{
    public interface ICook
    {
        public Dish CookDish(string name, Product[] products);

        public void DecorateDish(Dish dish);
    }
}
