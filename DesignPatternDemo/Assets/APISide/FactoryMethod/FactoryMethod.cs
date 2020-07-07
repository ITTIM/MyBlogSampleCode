///---------------------------------
/// FactoryMethod
///---------------------------------

namespace Pattern.FactoryMethod
{
    using UnityEngine;

    public abstract class FactoryMethod
    {
        public static void SetInventoryCount<T>(int count)
            where T : IProduct
        {
        }

        public static int GetInventoryCount<T>()
            where T : IProduct
        {
            return 0;
        }

        public abstract IProduct CreateProduct(int productID);
    }
}
