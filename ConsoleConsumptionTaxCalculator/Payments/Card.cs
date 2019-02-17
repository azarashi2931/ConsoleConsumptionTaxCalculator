namespace Azarashi.ConsoleConsumptionTaxCalculator.Payments
{
    class Card : IPaymentOption
    {
        public bool IsReduction()
        {
            return true;
        }
    }
}
