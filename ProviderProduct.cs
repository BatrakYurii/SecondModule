namespace SecondModule
{
    public class ProviderProduct
    {
        private static Product[] _arrayOfProducts;
        private static int _sizeOfArr = 12;
        static ProviderProduct()
        {
            _arrayOfProducts = new Product[_sizeOfArr];
        }

        public static Product[] ArrayOfproducts => _arrayOfProducts;

        public Product[] Init()
        {
            _arrayOfProducts[0] = new Product { Name = ProductName.AirPods_Pro.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.AirPods_Pro) };
            _arrayOfProducts[1] = new Product { Name = ProductName.Honor_SV2.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Honor_SV2) };
            _arrayOfProducts[2] = new Product { Name = ProductName.Iphone12.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Iphone12) };
            _arrayOfProducts[3] = new Product { Name = ProductName.IPhone12_Pro_Max.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.IPhone12_Pro_Max) };
            _arrayOfProducts[4] = new Product { Name = ProductName.IPhone7_Plus.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.IPhone7_Plus) };
            _arrayOfProducts[5] = new Product { Name = ProductName.Samsung_Galaxy_A3.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Samsung_Galaxy_A3) };
            _arrayOfProducts[6] = new Product { Name = ProductName.Xiaomi_Mi_A3.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Xiaomi_Mi_A3) };
            _arrayOfProducts[7] = new Product { Name = ProductName.IPod.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.IPod) };
            _arrayOfProducts[8] = new Product { Name = ProductName.IMac.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.IMac) };
            _arrayOfProducts[9] = new Product { Name = ProductName.Xiaomi_Redmi_Note5.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Xiaomi_Redmi_Note5) };
            _arrayOfProducts[10] = new Product { Name = ProductName.Iphone7.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.Iphone7) };
            _arrayOfProducts[11] = new Product { Name = ProductName.IPhoneXr.ToString(), CostOf = PriceService.PriceToUAH((int)ProductName.IPhoneXr) };

            return _arrayOfProducts;
        }
    }
}