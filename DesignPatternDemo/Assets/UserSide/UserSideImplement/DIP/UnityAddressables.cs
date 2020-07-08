namespace User.Implement
{
    using UnityEngine;
    using SOLID;

    public sealed class UnityAddressables : IResourceManager
    {
        private const string ResourceSourceEngine = @"Addressables";

        public void Load(string assetKey)
        {
            Debug.Log($"Load [{assetKey}] by <{ResourceSourceEngine}>");
        }
    }
}
