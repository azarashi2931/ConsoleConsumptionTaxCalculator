using Azarashi.ConsoleConsumptionTaxCalculator;

namespace Azarashi.ConsoleConsumptionTaxCalculator.Products
{
    class Food : IProductType
    {
        public float GetBaseTaxRate()
        {
            return TaxRateConstants.ReducedTaxRate;
        }
    }
}
