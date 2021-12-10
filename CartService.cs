using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class CartService
    {
        private static readonly CartService _instance = new CartService();
        private readonly Product[] _productsInCart;

        static CartService()
        {
        }

        private CartService()
        {
            var c = new ServiceConfig();
            _productsInCart = new Product[c.CartConfig.SizeOfCart];
        }

        public Product[] ProductsInCart => _productsInCart;

        public static CartService Instance
        {
            get { return _instance; }
        }

        public Product[] Add()
        {
            var c = new ServiceConfig();
            var p = new Product[c.CartConfig.SizeOfCart];
            for (var i = 0; i < c.CartConfig.SizeOfCart; i++)
            {
                _productsInCart[i] = ProviderProduct.ArrayOfproducts[i];
            }

            return _productsInCart;
        }

        public Product[] Clear()
        {
            for (var i = 0; i < _productsInCart.Length; i++)
            {
                _productsInCart[i] = null;
            }

            return _productsInCart;
        }
    }
}
