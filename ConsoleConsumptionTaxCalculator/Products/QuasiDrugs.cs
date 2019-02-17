namespace Azarashi.ConsoleConsumptionTaxCalculator.Products
{
    class QuasiDrug : IProductType
    {
        public float GetBaseTaxRate()
        {
            return TaxRateConstants.DefaultTaxRate;
        }
    }
}
