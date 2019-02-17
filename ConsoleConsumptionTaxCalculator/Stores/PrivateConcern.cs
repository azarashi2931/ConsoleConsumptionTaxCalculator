namespace Azarashi.ConsoleConsumptionTaxCalculator.Stores
{
    class PrivateConcern : IStoreType
    {
        public float GetReductionRate()
        {
            return 0.05f;
        }
    }
}
