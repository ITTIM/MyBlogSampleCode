/// <summary>
/// FlyAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class FlyAbility : IOCPBehaviour
    {
        private class Wings {}

        private Wings wings;

        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I have wings, so I can fly");
        }
    }
}
