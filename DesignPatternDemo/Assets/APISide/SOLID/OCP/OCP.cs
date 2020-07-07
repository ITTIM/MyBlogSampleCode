/// <summary>
/// OCP
/// </summary>

namespace SOLID
{
    using System.Collections.Generic;
    using UnityEngine;

    public sealed class OCP
    {
        private List<IOCPBehaviour> behaviours = new List<IOCPBehaviour>();

        private string userName;

        public OCP(string yourName)
        {
            userName = yourName;
        }

        public void Add(IOCPBehaviour behaviour)
        {
            behaviours.Add(behaviour);
        }

        public void ExecuteAllMyAbility()
        {
            foreach (var behaviour in behaviours)
            {
                Debug.Log($"I am {userName}, and ...");
                behaviour.DoWhatEverYouWant();
            }
        }
    }
}
