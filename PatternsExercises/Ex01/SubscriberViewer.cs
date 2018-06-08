using System;



namespace Patterns.Ex01
{
    public class SubscriberViewer
    {
        /// <summary>
        /// ���������� ������ ����������� ������������ �� ���.����.
        /// TODO: ���������� �������� ���� ����� �� �������� ������
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>
        public IStrategy strategy;
        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
            switch (networkType)
            {
                case SocialNetwork.Instagram:
                    {
                        strategy = new InstagramReceiver();
                        break;
                    }                    
                case SocialNetwork.Twitter:
                    {
                        strategy = new TwitterReceiver();
                        break;
                    }
                default:
                    {
                        return null;
                    }              
            }
            return strategy.GetSubscribers(userName);
        }        
    }
}