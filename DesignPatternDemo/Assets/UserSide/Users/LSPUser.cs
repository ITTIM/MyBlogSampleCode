/// <summary>
/// LSPUser
/// </summary>

namespace User
{
    using SOLID;
    using User.Implement;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public sealed class LSPUser : MonoBehaviour
    {
        private void Start()
        {
            var lspTable = new LSP();
            lspTable.AddUnit(new Human(), new Ball(), new Love(), new Toy());
            lspTable.ShowAllPrice();
            lspTable.ShowAllSize();
        }
    }
}
