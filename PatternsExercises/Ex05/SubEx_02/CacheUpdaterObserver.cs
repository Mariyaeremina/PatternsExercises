using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    public class CacheUpdaterObserver: CacheUpdater, IObserver
    {
        public void Update()
        {
            UpdateCache();
        }
    }
}
