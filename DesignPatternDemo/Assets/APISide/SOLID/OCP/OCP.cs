/// <summary>
/// OCP
/// </summary>

namespace SOLID
{
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Open-Closed Principle:
    /// A module will be said to be open, if it is still available for extension.
    /// A module will be said to be closed, if it is available for use by other modules.
    /// 
    /// In this case, OCP provides a IOCPBehaviour interface
    /// [Open] for user to implement their own Ability they want
    /// 
    /// And OCP hide all the detail about how OCP will use the behaviour
    /// For example, OCP will do something before and after Add behaviour
    /// That is [closed] for user to modify, they can't even know about it
    /// </summary>
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
            DoSomthing();
            behaviours.Add(behaviour);
            DoSomthing();
        }

        public void ExecuteAllMyAbility()
        {
            foreach (var behaviour in behaviours)
            {
                Debug.Log($"I am {userName}, and ...");
                behaviour.DoWhatEverYouWant();
            }

            DoSomthing();
        }

        private void DoSomthing()
        { }
    }
}
