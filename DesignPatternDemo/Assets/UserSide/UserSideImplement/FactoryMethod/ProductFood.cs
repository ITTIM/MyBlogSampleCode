/// <summary>
/// Product Food
/// </summary>

namespace User.Implement
{
    using UnityEngine;
    using Pattern.FactoryMethod;

    internal sealed class ProductFood : IProduct
    {
        public string ProductName { get; internal set; }

        public string[] Content { get; internal set; }

        public int Price { get; internal set; }

        public bool IsOnSale { get; internal set; }

        public float Discount { get; internal set; }

        public void Eat()
        {
            Debug.Log($"Eat {ProductName} now, [{string.Join(@", ", Content)}]");
        }
    }
}
