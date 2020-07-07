/// <summary>
/// Ball
/// </summary>

namespace User.Implement
{
    using SOLID;

    public sealed class Ball : IUnit
    {
        public string UserName => @"[Ball]";

        public int GetPrice() => 100;

        public float GetSize() => 10f;
    }
}
