using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class OrderService
    {
        private Order _orderInfo;
        private CartService _cartService;
        private string _info;
        public void CreateOrder(string phone = null, string email = null)
        {
            var rnd = new Random();
            _orderInfo = new Order { NumberOfOrder = rnd.Next(10000, 20000), Email = email, PhoneNumber = phone };
            _cartService = CartService.Instance;

            if (phone != null)
            {
                _info = $"Заказ номер {_orderInfo.NumberOfOrder} сформирован, детали заказа были отправлены по номеру {_orderInfo.PhoneNumber}";
            }
            else if (email != null)
            {
                _info = $"Заказ номер {_orderInfo.NumberOfOrder} сформирован, детали заказа были отправлены на почтовый адрес {_orderInfo.Email}";
            }
            else
            {
                _info = $"Заказ номер {_orderInfo.NumberOfOrder} не может быть сформирован, пожалуйста, укажите контактные данные";
            }
        }

        public void Showorder()
        {
            Console.WriteLine(ProductsToListOfString(_info, _cartService));
        }

        private string ProductsToListOfString(string info, CartService cartService)
        {
            var strb = new StringBuilder();
            strb.AppendLine(info);
            strb.AppendLine();
            strb.AppendLine("Состав заказа:");
            for (var i = 0; i < cartService.ProductsInCart.Length; i++)
            {
                strb.AppendLine($"{cartService.ProductsInCart[i].Name} - {cartService.ProductsInCart[i].CostOf.Cost} {cartService.ProductsInCart[i].CostOf.Currency}");
            }

            return strb.ToString();
        }
    }
}
