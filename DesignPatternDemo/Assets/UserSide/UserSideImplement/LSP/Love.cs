namespace User.Implement
{
    using SOLID;

    public sealed class Love : IUnit
    {
        public string UserName => @"[Love]";

        public int GetPrice() => 0;

        public float GetSize() => -999.0f;
    }
}
