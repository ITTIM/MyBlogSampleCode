/// <summary>
/// DIPUser
/// </summary>

namespace User
{
    using SOLID;
    using UnityEngine;
    using User.Implement;

    public sealed class DIPUser : MonoBehaviour
    {
        private void Start()
        {
            var dip1 = new DIP(new UnityResources());
            dip1.Load();
            
            var dip2 = new DIP(new UnityAddressables());
            dip2.Load();
        }
    }
}
