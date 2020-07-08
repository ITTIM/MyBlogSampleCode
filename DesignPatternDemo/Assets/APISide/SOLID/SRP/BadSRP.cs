/// <summary>
/// BadSRP
/// </summary>

namespace SOLID
{
    using UnityEngine;

    public static class BadSRP
    {
        public enum ThingType
        {
            None,
            Walk,
            Run,
            Move,
            Dance,
            Fly,
        }

        /// <summary>
        /// It is not good idea to create a powerful function
        /// In this case, it provides 6 kind of ability
        /// </summary>
        /// <param name="thingType"></param>
        /// <param name="value"></param>
        /// <param name="direction"></param>
        /// <param name="duration"></param>
        public static void DoSomething(ThingType thingType, float value = 0f, float direction = 0f, float duration = 0f)
        {
            switch (thingType)
            {
                case ThingType.Dance:
                    Debug.Log($"BadSRP.dance {value + 1f}, {direction / 3f}, {duration * 2f}");
                    break;
                case ThingType.Walk:
                    Debug.Log($"BadSRP.walk {value * 2f}, {direction / 5f}, {duration + 10f}");
                    break;
                case ThingType.Run:
                    Debug.Log($"BadSRP.Run {value * 2.222f}, {direction / 0.5f}, {duration + 3f}");
                    break;
                case ThingType.Fly:
                    Debug.Log($"BadSRP.Fly {value + 11f}, {direction * 0f}, {duration + 1f}");
                    break;
                case ThingType.Move:
                    Debug.Log($"BadSRP.Fly {value + 4f}, {direction - 1f}, {duration * 2f}");
                    break;
                case ThingType.None:
                default:
                    Debug.Log($"BadSRP.none {value * 0f}, {direction * 0f}, {duration * 0f}");
                    break;
            }
        }
    }
}
