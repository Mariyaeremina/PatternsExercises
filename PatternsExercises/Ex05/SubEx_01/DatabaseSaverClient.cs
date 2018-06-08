using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    public class DatabaseSaverClient
    {
        public void Main(bool b)
        {
            IDatabaseSaver databaseSaver = new DatabaseSaver();
            databaseSaver = new MailSenderDecorator(databaseSaver, new MailSender(), "email");
            databaseSaver = new CacheUpdaterDecorator(databaseSaver, new CacheUpdater());
            DoSmth(databaseSaver);
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }
}