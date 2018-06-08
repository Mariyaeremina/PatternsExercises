using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    public class DatabaseSaverClient
    {
        public void Main(bool b)
        {
            var databaseSaver = new DatabaseServerObservable();
            databaseSaver.AddObserver(new MailSenderObserver("email"));
            databaseSaver.AddObserver(new CacheUpdaterObserver());
            DoSmth(databaseSaver);
            databaseSaver.NotifyObservers();
        }

        private void DoSmth(IDatabaseSaver saver)
        {
            saver.SaveData(null);
        }
    }

    

    

    
}