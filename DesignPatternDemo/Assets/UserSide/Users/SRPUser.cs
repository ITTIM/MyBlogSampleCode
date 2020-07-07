/// <summary>
/// SRP user
/// </summary>

namespace User
{
    using UnityEngine;
    using SOLID;

    public sealed class SRPUser : MonoBehaviour
    {
        private void Start()
        {
            GoodSRP.Walk();
            GoodSRP.Run(1f);

            BadSRP.DoSomething(BadSRP.ThingType.Move, 1f, 90f, 0.5f);
            BadSRP.DoSomething(BadSRP.ThingType.Fly, 123f, 45f, 0.25f);
        }
    }
}
