namespace Azarashi.ConsoleConsumptionTaxCalculator.Stores
{
    class ConvenienceStore : IStoreType
    {
        public float GetReductionRate()
        {
            return 0.02f;
        }
    }
}
