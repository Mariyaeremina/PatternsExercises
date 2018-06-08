using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex02
{
    public abstract class AbstractUserService
    {
        public UserInfo GetUserInfo(string pageUrl)
        {
            UserInfo result = new UserInfo();
            result.Name = GetUserName(pageUrl);
            result.UserId = GetUserIdString(pageUrl);
            result.Friends = GetUserFriends(pageUrl);
            return result;
        }
        public abstract string GetUserName(string pageUrl);
        public abstract string GetUserIdString(string pageUrl);
        public abstract UserInfo[] GetUserFriends(string pageUrl);
    }
}
