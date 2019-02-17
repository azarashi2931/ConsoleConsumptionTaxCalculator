namespace Azarashi.ConsoleConsumptionTaxCalculator.Stores
{
    class Pharmacy : IStoreType
    {
        public float GetReductionRate()
        {
            return 0.05f;
        }
    }
}
