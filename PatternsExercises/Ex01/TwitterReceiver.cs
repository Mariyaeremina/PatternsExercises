using System;
using Patterns.Ex01.ExternalLibs.Twitter;

namespace Patterns.Ex01
{
    public class TwitterReceiver : IStrategy
    {
        public SocialNetworkUser[] GetSubscribers(String userName)
        {
            TwitterClient client = new TwitterClient();
            TwitterUser[] users = new TwitterClient().GetSubscribers(client.GetUserIdByName(userName));
            SocialNetworkUser[] subscribers = new SocialNetworkUser[users.Length];
            for (int i = 0; i < subscribers.Length; i++)
            {
                subscribers[i].UserName = client.GetUserNameById(users[i].UserId);
            }
            return subscribers;
        }
    }
}
