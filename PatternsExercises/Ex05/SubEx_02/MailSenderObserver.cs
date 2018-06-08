using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    public class MailSenderObserver: MailSender, IObserver
    {
        private string email;
        public MailSenderObserver(string email)
        {
            this.email = email;
        }

        public void Update()
        {
            Send(email);
        }
    }
}
