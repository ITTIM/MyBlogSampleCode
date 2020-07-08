namespace SOLID
{
    using UnityEngine;

    public sealed class Andy : IEmployee, IArtist
    {
        public void Create2DImage()
        {
            Debug.Log(@"Andy Create2DImage");
        }

        public void Create3DModel()
        {
            Debug.Log(@"Andy Create3DModel");
        }

        public void Work()
        {
            Debug.Log(@"Andy work");
        }
    }
}
