namespace Patterns.Ex00
{
    public class LogImporterClient //класс клиента, импртирующего логи
    {
        /// <summary>
        /// TODO: Изменения нужно вносить в этом методе
        /// </summary>
        public void DoMethod()
        {
            //LogImporter importer = new LogImporter(new FileLogReader());
            //importer.ImportLogs("ftp://log.txt");

            LogImporter importer = new LogImporter(new FtpLogReader("login", "password", "path"));
            importer.ImportLogs("ftp://log.txt");
        }

    }
}