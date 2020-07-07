/// <summary>
/// Product Iron
/// </summary>

namespace User.Implement
{
    using Pattern.FactoryMethod;
    using UnityEngine;

    internal sealed class ProductIron : IProduct
    {
        public string ProductName { get; internal set; }

        public string[] Content { get; internal set; }

        public int Price { get; internal set; }

        public bool IsOnSale { get; internal set; }

        public float Discount { get; internal set; }

        public void Eat()
        {
            Debug.LogError($"You can't eat {ProductName}, it was made with iron!");
        }
    }
}
