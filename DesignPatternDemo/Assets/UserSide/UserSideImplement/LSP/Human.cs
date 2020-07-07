/// <summary>
/// Human
/// </summary>

namespace User.Implement
{
    using SOLID;
    
    public sealed class Human : IUnit
    {
        public string UserName => @"[Human]";

        public int GetPrice() => 99999;

        public float GetSize() => 1f;
    }
}
