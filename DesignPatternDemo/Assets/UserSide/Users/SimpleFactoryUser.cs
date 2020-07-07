///---------------------------------
///SimpleFactoryUser
///---------------------------------

namespace User
{
    using Pattern.SimpleFactory;
    using UnityEngine;

    public class SimpleFactoryUser : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(@"### Begin of SimpleFactoryUser result");
            var coffee = SimpleFactory.Make(SimpleMenu.COFFEE);
            var blackTea = SimpleFactory.Make(SimpleMenu.BLACKTEA);
            coffee.DoSomething();
            blackTea.DoSomething();
            Debug.Log(@"### End of SimpleFactoryUser result");
        }
    }
}
