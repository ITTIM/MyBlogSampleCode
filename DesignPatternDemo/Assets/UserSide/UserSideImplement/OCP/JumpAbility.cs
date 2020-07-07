/// <summary>
/// JumpAbility
/// </summary>

namespace User.Implement
{
    using SOLID;
    using UnityEngine;

    public sealed class JumpAbility : IOCPBehaviour
    {
        public void DoWhatEverYouWant()
        {
            Debug.Log(@"I can jump");
        }
    }
}
