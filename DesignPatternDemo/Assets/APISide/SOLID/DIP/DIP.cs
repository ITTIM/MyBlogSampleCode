/// <summary>
/// Dependency Inversion Principle:
/// 1. High-level modules should not depend on low-level modules.
/// Both should depend on abstractions.
/// 2. Abstractions should not depend on details.
/// Details should depend on abstractions.
/// 
/// In this case
/// DIP takes a IResourceManager instance as it's asset loading module, and use it's abstractions
/// But DIP don't care about detail of the isntance
/// </summary>
namespace SOLID
{
    public sealed class DIP
    {
        private IResourceManager resourceManager;

        public DIP(IResourceManager rm)
        {
            resourceManager = rm;
        }

        public void Load()
        {
            resourceManager.Load(@"A");
            resourceManager.Load(@"BB");
            resourceManager.Load(@"CCC");
        }
    }
}
