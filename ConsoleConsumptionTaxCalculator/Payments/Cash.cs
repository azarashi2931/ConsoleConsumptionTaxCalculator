namespace Azarashi.ConsoleConsumptionTaxCalculator.Payments
{
    class Cash : IPaymentOption
    {
        public bool IsReduction()
        {
            return false;
        }
    }
}
