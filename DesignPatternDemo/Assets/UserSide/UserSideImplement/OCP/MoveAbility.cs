/// <summary>
/// MoveAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class MoveAbility : IOCPBehaviour
    {
        private class Wheel { }

        private Wheel wheel;

        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I have wheel, so I can move");
        }
    }
}
