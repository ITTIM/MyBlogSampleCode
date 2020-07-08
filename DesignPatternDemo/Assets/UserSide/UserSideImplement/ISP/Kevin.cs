/// <summary>
/// Kevin
/// </summary>

namespace User.Implement
{
    using SOLID;
    using Print = UnityEngine.Debug;

    public sealed class Kevin : IEmployee, IProgrammer
    {
        public void Debug()
        {
            Print.Log(@"Kevin debug");
        }

        public void Work()
        {
            Print.Log(@"Kevin work");
            Debug();
            WriteCode();
        }

        public void WriteCode()
        {
            Print.Log(@"Kevin write code");
        }
    }
}
