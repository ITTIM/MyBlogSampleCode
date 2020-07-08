/// <summary>
/// Aimee
/// </summary>

namespace User.Implement
{
    using UnityEngine;
    using SOLID;

    public sealed class Aimee : IEmployee, IGameDesigner, IArtist
    {
        public void Create2DImage()
        {
            Debug.Log(@"Aimee Create2DImage");
        }

        public void Create3DModel()
        {
            Debug.Log(@"Aimee Create3DModel");
        }

        public void CreateGamePlay()
        {
            Debug.Log(@"Aimee CreateGamePlay");
        }

        public void CreateUILayout()
        {
            Debug.Log(@"Aimee CreateUILayout");
        }

        public void Work()
        {
            Debug.Log(@"Aimee work");
        }
    }
}
