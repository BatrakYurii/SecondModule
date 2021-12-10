using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class Starter
    {
        public void Run()
        {
            var p = new ProviderProduct();
            p.Init();
            var cartService = CartService.Instance;
            cartService.Add();
            var o = new OrderService();
            o.CreateOrder(null, "qerty12345");
            o.Showorder();
        }
    }
}
