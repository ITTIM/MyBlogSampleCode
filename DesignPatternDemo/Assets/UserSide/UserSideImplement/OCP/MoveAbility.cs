/// <summary>
/// MoveAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class MoveAbility : IOCPBehaviour
    {
        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I can move");
        }
    }
}
