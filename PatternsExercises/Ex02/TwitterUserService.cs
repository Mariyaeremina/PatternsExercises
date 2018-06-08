using System;
using System.Linq;
using System.Text.RegularExpressions;
using Patterns.Ex01.ExternalLibs.Twitter;

namespace Patterns.Ex02
{
    public class TwitterUserService: AbstractUserService
    {
        readonly TwitterClient _client = new TwitterClient();
        
        public override string GetUserName(string pageUrl)
        {
            var regex = new Regex("twitter.com/(.*)");
            return regex.Match(pageUrl).Groups[0].Value;
        }

        public override string GetUserIdString(string pageUrl)
        {
            return GetUserId(GetUserName(pageUrl)).ToString();
        }

        public override UserInfo[] GetUserFriends(string pageUrl)
        {
            TwitterUser[] subscribers = _client.GetSubscribers(GetUserId(pageUrl));
            UserInfo[] friends = subscribers
                .Select(c =>
                {
                    UserInfo userInfo = new UserInfo
                    {
                        UserId = c.UserId.ToString(),
                        Name = _client.GetUserNameById(c.UserId)
                    };
                    return userInfo;
                })
                .ToArray();
            return friends;
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private long GetUserId(String userName)
        {
            //TODO: Return userId from userName
            return 0;
        }
    }
}