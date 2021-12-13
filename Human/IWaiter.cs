using SecondModule.Dishes;
using SecondModule.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule.Human
{
    public interface IWaiter
    {
        public Product[] GetSortedProductsFromDish(Dish dish, SortingType sortingType);

        public void ServeDish(Dish dish);
    }
}
