using Azarashi.ConsoleConsumptionTaxCalculator;

namespace Azarashi.ConsoleConsumptionTaxCalculator
{
    class ConsumptionTaxCalculator : ICalculatacle<float>
    {
        readonly IPaymentOption paymentOption;
        readonly IProductType productType;
        readonly IStoreType storeType;

        public ConsumptionTaxCalculator(IPaymentOption paymentOption, IProductType productType, IStoreType storeType)
        {
            this.paymentOption = paymentOption;
            this.productType = productType;
            this.storeType = storeType;
        }

        public float Calculate()
        {
            float tax = productType.GetBaseTaxRate();

            if (paymentOption.IsReduction())
                tax -= storeType.GetReductionRate();

            return tax;
        }
    }
}
