/// <summary>
/// ISPUser
/// </summary>

namespace SOLID
{
    using UnityEngine;
    using User.Implement;

    public sealed class ISPUser : MonoBehaviour
    {
        private void Start()
        {
            var ispCompany = new ISP();
            ispCompany.RecruitEmployees(new Kevin(), new Andy(), new Aimee());
            ispCompany.RunCompany();
            Debug.Log(@"=============");
            ispCompany.UseProgrammer();
            Debug.Log(@"=============");
            ispCompany.UseArtist();
            Debug.Log(@"=============");
            ispCompany.UseGameDesigner();
        }
    }
}
