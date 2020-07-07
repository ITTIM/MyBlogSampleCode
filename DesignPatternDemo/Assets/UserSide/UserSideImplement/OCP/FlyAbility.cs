/// <summary>
/// FlyAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class FlyAbility : IOCPBehaviour
    {
        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I can fly");
        }
    }
}
