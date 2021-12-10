namespace SecondModule
{
    public class ServiceConfig
    {
        private CartConfig _cartConfig;
        public ServiceConfig()
        {
            Init();
        }

        public CartConfig CartConfig => _cartConfig;
        private void Init()
        {
            _cartConfig = new CartConfig { SizeOfCart = 10 };
        }
    }
}