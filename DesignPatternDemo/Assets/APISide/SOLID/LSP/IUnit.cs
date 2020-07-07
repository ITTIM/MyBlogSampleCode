/// <summary>
/// IUnit
/// </summary>

namespace SOLID
{
    public interface IUnit
    {
        string UserName { get; }
        int GetPrice();
        float GetSize();
    }
}
