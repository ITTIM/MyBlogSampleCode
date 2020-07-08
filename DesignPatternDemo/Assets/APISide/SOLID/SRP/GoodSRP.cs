/// <summary>
/// GoodSRP
/// </summary>

namespace SOLID
{
    using UnityEngine;

    /// <summary>
    /// Single Responsibility Principle:
    /// Each class in your system should have only one responsibility
    /// 
    /// In this case
    /// GoodSRP provides only move ability for user, nothing else
    /// User will only use it for move, the logic is simple
    /// And the code inside it, is clean
    /// 
    /// BadSRP provides several kinds of ability for user
    /// User will use it for several kinds of case
    /// The logic will become complicated and difficult to understand
    /// And the code inside it, is dirty
    /// </summary>
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
