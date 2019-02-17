using Azarashi.ConsoleConsumptionTaxCalculator.Payments;

namespace Azarashi.ConsoleConsumptionTaxCalculator
{
    class PaymentOptionFactory : ICreateByName<IPaymentOption>
    {
        static PaymentOptionFactory instance;
        public static PaymentOptionFactory GetInstance()
        {
            if (instance == null) instance = new PaymentOptionFactory();
            return instance;
        }

        private PaymentOptionFactory() { }

        public IPaymentOption CreateByName(string name)
        {
            switch (name)
            {
            case nameof(Cash):
                return new Cash();
            case nameof(Card):
                return new Card();
            default:
                return null;
            }
        }
    }
}
