/// <summary>
/// IronFactory
/// </summary>

namespace User.Implement
{
    using System.Collections.Generic;
    using Pattern.FactoryMethod;
    using System;

    public sealed class IronFactory : FactoryMethod
    {
        private const int defaultID = 1;
        private Dictionary<int, Func<IProduct>> table = new Dictionary<int, Func<IProduct>>()
        {
            { defaultID, MakeNormalIron },
            { 111, MakeBetterIron },
            { 999, MakeSuperIron },
        };

        public override IProduct CreateProduct(int productID)
        {
            if (table.ContainsKey(productID)) return table[productID].Invoke();

            return table[defaultID].Invoke();
        }

        private static IProduct MakeSuperIron()
        {
            return new ProductIron()
            {
                ProductName = @"Super Iron",
                Price = 1000,
                Content = new string[] { "Iron 99.99%", "Impurities 0.01%" },
                IsOnSale = false,
                Discount = 1f
            };
        }

        private static IProduct MakeBetterIron()
        {
            return new ProductIron()
            {
                ProductName = @"Normal Iron",
                Price = 234,
                Content = new string[] { "Iron 90%", "Impurities 10%" },
                IsOnSale = false,
                Discount = 0.8f
            };
        }

        private static IProduct MakeNormalIron()
        {
            return new ProductIron()
            {
                ProductName = @"Normal Iron",
                Price = 123,
                Content = new string[] { "Iron 80%", "Impurities 20%" },
                IsOnSale = false,
                Discount = 0.5f
            };
        }
    }
}
