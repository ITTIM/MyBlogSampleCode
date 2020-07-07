///---------------------------------
/// SimpleObjectB
///---------------------------------

namespace Pattern.SimpleFactory
{
    using UnityEngine;

    internal sealed class SimpleObjectB : ISimpleObject
    {
        public void DoSomething()
        {
            Debug.Log(@"Coffee");
        }
    }
}
