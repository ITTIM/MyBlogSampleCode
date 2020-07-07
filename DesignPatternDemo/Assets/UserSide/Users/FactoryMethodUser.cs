/// <summary>
/// FactoryMethodUser
/// </summary>

namespace User
{
    using UnityEngine;
    using User.Implement;

    public sealed class FactoryMethodUser : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(@"### Begin of FactoryMethodUser result");
            var fruitFactory = new FruitFactory();
            var ironFactory = new IronFactory();

            var f1 = fruitFactory.CreateProduct(1);
            var f2 = fruitFactory.CreateProduct(2);
            var f3 = fruitFactory.CreateProduct(3);
            f1.Eat();
            f2.Eat();
            f3.Eat();

            var i1 = ironFactory.CreateProduct(1);
            var i2 = ironFactory.CreateProduct(111);
            var i3 = ironFactory.CreateProduct(999);
            i1.Eat();
            i2.Eat();
            i3.Eat();
            Debug.Log(@"### End of FactoryMethodUser result");
        }
    }
}
