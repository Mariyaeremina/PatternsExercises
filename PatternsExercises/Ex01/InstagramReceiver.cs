using System;
using Patterns.Ex01.ExternalLibs.Instagram;

namespace Patterns.Ex01
{
    public class InstagramReceiver : IStrategy
    {
        public SocialNetworkUser[] GetSubscribers(String userName)
        {
            InstagramUser[] users = new InstagramClient().GetSubscribers(userName);
            SocialNetworkUser[] subscribers = new SocialNetworkUser[users.Length];
            for (int i = 0; i < subscribers.Length; i++)
            {
                subscribers[i].UserName = users[i].UserName;
            }
            return subscribers;
        }
    }
}
