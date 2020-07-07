///---------------------------------
/// SimpleObjectA
///---------------------------------

namespace Pattern.SimpleFactory
{
    using UnityEngine;

    internal sealed class SimpleObjectA : ISimpleObject
    {
        public void DoSomething()
        {
            Debug.Log(@"BlackTea");
        }
    }
}
