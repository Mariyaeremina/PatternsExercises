using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    public class MailSenderDecorator : DatabaseSaverDecorator
    {
        private MailSender mailSender;
        private string email;

        public MailSenderDecorator(IDatabaseSaver databaseSaver, MailSender mailSender, string email): base(databaseSaver)
        {
            this.mailSender = mailSender;
            this.email = email;
        }

        public new void SaveData(object data)
        {
            base.SaveData(data);
            mailSender.Send(email);
        }
    }
}
