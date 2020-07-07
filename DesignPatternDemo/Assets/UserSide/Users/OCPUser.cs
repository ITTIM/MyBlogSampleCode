/// <summary>
/// OCP user
/// </summary>

namespace User
{
    using SOLID;
    using UnityEngine;
    using User.Implement;

    public sealed class OCPUser : MonoBehaviour
    {
        private void Start()
        {
            var ocp1 = new OCP(@"AAA");
            ocp1.Add(new MoveAbility());
            ocp1.ExecuteAllMyAbility();

            var ocp2 = new OCP(@"BBB");
            ocp2.Add(new JumpAbility());
            ocp2.Add(new FlyAbility());
            ocp2.ExecuteAllMyAbility();
        }
    }
}