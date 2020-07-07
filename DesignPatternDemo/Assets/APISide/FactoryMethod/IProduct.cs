///---------------------------------
/// IProduct
///---------------------------------

namespace Pattern.FactoryMethod
{
    public interface IProduct
    {
        string ProductName { get; }
        
        string[] Content { get; }
        
        int Price { get; }
        
        bool IsOnSale { get; }
        
        float Discount { get; }

        void Eat();
    }
}
