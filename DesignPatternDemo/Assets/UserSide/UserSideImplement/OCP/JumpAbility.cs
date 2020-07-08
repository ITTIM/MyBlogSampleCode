/// <summary>
/// JumpAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class JumpAbility : IOCPBehaviour
    {
        private class Legs { }

        private Legs legs;

        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I have legs, so I can jump");
        }
    }
}
