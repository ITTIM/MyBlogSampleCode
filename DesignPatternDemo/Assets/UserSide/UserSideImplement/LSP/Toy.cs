/// <summary>
/// Toy
/// </summary>

namespace SOLID
{
    public sealed class Toy : IUnit
    {
        public string UserName => @"[Toy]";

        public int GetPrice() => 100;

        public float GetSize() => 2f;
    }
}
