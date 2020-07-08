/// <summary>
/// LSP
/// </summary>

namespace SOLID
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Liskov Substitution Principle:
    /// If S is a subtype of T
    /// Then objects of type T may be replaced
    /// with objects of type S
    /// without altering any of the desirable properties of the program
    /// 
    /// In this case, LSP don't really know the instance type
    /// As long as the instance implement the IUnit interface
    /// And LSP will works fine with it
    /// </summary>
    public sealed class LSP
    {
        private List<IUnit> unitList = new List<IUnit>();

        public void AddUnit(params IUnit[] units)
        {
            unitList.AddRange(units);
        }

        public void ShowAllPrice()
        {
            foreach (var unit in unitList)
            {
                Debug.Log($"{unit.UserName} price = {unit.GetPrice()}");
            }
        }

        public void ShowAllSize()
        {
            unitList.ForEach(unit =>
            {
                Debug.Log($"{unit.UserName} size = {unit.GetSize():0.0}");
            });
        }
    }
}
