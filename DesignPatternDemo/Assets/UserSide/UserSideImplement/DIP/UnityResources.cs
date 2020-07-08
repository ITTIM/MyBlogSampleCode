namespace User.Implement
{
    using UnityEngine;
    using SOLID;

    public sealed class UnityResources : IResourceManager
    {
        private const string ResourceSourceEngine = @"Resources";

        public void Load(string assetKey)
        {
            Debug.Log($"Load [{assetKey}] by <{ResourceSourceEngine}>");
        }
    }
}
