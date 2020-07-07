namespace User.Implement
{
    using Pattern.FactoryMethod;

    public sealed class FruitFactory : FactoryMethod
    {
        public override IProduct CreateProduct(int productID)
        {
            switch (productID)
            {
                case 1:
                    return Banana;
                case 2:
                    return Apple;
                default:
                    return JunkFruit;
            }
        }

        private IProduct JunkFruit => new ProductFood()
        {
            ProductName = @"Junk Fruit",
            Price = 999,
            Content = new string[] { "Box", "Moldy fruit" },
            IsOnSale = true,
            Discount = 1f
        };

        private IProduct Banana => new ProductFood()
        {
            ProductName = @"Banana",
            Price = 100,
            Content = new string[] { "Box", "Banana * 10" },
            IsOnSale = false,
            Discount = 1f
        };

        private IProduct Apple => new ProductFood()
        {
            ProductName = @"Apple",
            Price = 20,
            Content = new string[] { "Food wax", "Apple" },
            IsOnSale = false,
            Discount = 1f
        };
    }
}
