using System;

namespace Azarashi.ConsoleConsumptionTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0 && args[0] == "-h")
            {
                return;
            }

            IPaymentOption paymentOption = GetInstanceByCommand("支払い方法を入力", PaymentOptionFactory.GetInstance());
            IProductType productType = GetInstanceByCommand("小品種別を入力", ProductTypeFactory.GetInstance());
            IStoreType storeType = GetInstanceByCommand("店舗種別を入力", StoreTypeFactory.GetInstance());

            ICalculatacle<float> calculator = new ConsumptionTaxCalculator(paymentOption,productType,storeType);
            float result = calculator.Calculate();
            Console.WriteLine(result);

            Console.Write("Press Enter Key.");
            Console.ReadLine();
        }

        /// <summary>
        /// 対話型UI
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <param name="factory"></param>
        /// <returns></returns>
        static T GetInstanceByCommand<T>(string message, ICreateByName<T> factory) where T : class
        {
            T instance = null;
            while (instance == null)
            {
                Console.WriteLine(message);
                string instanceName = Console.ReadLine();
                instance = factory.CreateByName(instanceName);
            }

            return instance;
        }
    }
}
