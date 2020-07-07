/// <summary>
/// LSP
/// </summary>

namespace SOLID
{
    using System.Collections.Generic;
    using UnityEngine;

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
