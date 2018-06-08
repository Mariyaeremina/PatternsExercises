using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    public class DatabaseSaverDecorator : IDatabaseSaver
    {
        private IDatabaseSaver databaseSaver;

        public DatabaseSaverDecorator(IDatabaseSaver databaseSaver)
        {
            this.databaseSaver = databaseSaver;
        }

        public void SaveData(object data)
        {
            databaseSaver.SaveData(data);
        }
    }
}
