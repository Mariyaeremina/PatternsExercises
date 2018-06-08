using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_01
{
    class NewDatabaseSaver : IDatabaseSaver
    {
        public void SaveData(object data)
        {
            new MailSender().Send("email");
            new CacheUpdater().UpdateCache();
        }
    }
}
