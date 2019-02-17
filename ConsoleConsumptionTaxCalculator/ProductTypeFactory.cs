using System;
using Azarashi.ConsoleConsumptionTaxCalculator.Products;

namespace Azarashi.ConsoleConsumptionTaxCalculator
{
    class ProductTypeFactory : ICreateByName<IProductType>
    {
        static ProductTypeFactory instance;
        public static ProductTypeFactory GetInstance()
        {
            if (instance == null) instance = new ProductTypeFactory();
            return instance;
        }

        private ProductTypeFactory() { }

        public IProductType CreateByName(string name)
        {
            switch(name)
            {
            case nameof(Food):
                return new Food();
            case nameof(QuasiDrug):
                return new QuasiDrug();
            default:
                return null;
            }
        }
    }
}
