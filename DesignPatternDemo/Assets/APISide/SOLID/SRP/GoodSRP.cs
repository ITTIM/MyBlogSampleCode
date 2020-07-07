/// <summary>
/// GoodSRP
/// </summary>

namespace SOLID
{
    using UnityEngine;

    public static class GoodSRP
    {
        public static void Walk(float distance = 1f)
        {
            Debug.Log($"GoodSRP Walk {distance}");
        }

        public static void Run(float height = 10f)
        {
            Debug.Log($"GoodSRP Run {height}");
        }
    }
}
