using System;
using Azarashi.ConsoleConsumptionTaxCalculator.Stores;

namespace Azarashi.ConsoleConsumptionTaxCalculator
{
    class StoreTypeFactory : ICreateByName<IStoreType>
    {
        static StoreTypeFactory instance;
        public static StoreTypeFactory GetInstance()
        {
            if (instance == null) instance = new StoreTypeFactory();
            return instance;
        }

        private StoreTypeFactory() { }
        
        public IStoreType CreateByName(string name)
        {
            switch (name)
            {
            case nameof(ConvenienceStore):
                return new ConvenienceStore();
            case nameof(Pharmacy):
                return new Pharmacy();
            case nameof(PrivateConcern):
                return new PrivateConcern();
            case nameof(SuperMarket):
                return new SuperMarket();
            default:
                return null;
            }
        }
    }
}