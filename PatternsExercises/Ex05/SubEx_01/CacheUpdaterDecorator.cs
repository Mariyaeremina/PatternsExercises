using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    public class CacheUpdaterDecorator : DatabaseSaverDecorator
    {
        private CacheUpdater cacheUpdater;

        public CacheUpdaterDecorator(IDatabaseSaver databaseSaver, CacheUpdater cacheUpdater): base(databaseSaver)
        {
            this.cacheUpdater = cacheUpdater;
        }

        public new void SaveData(object data)
        {
            base.SaveData(data);
            cacheUpdater.UpdateCache();
        }
    }
}
