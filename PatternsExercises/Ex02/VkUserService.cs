using System;

namespace Patterns.Ex02
{
    public class VkUserService: AbstractUserService
    {
        public override string GetUserName(string pageUrl)
        {
            return GetName(GetUserIdString(pageUrl));
        }

        public override string GetUserIdString(string pageUrl)
        {
            return Parse(pageUrl);
        }

        public override UserInfo[] GetUserFriends(string pageUrl)
        {
            VkUser[] users = GetFriendsById(Parse(pageUrl));
            return ConvertToUserInfo(users);
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private string GetName(string userId)
        {
            return "NAME";
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private VkUser[] GetFriendsById(string userId)
        {
            return new VkUser[0];
        }

        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        private string Parse(string pageUrl)
        {
            return "USER_ID";
        }


        /// <summary>
        /// Нет необходимости менять этот метод, достаточно просто переиспользовать
        /// Реализация его не важна, стоит полагаться только на его внешний интерфейс
        /// </summary>
        /// <param name="friends"></param>
        /// <returns></returns>
        private UserInfo[] ConvertToUserInfo(VkUser[] friends)
        {
            return new UserInfo[0];
        }
    }
}