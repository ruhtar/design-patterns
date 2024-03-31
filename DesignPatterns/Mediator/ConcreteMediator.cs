using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    public class ConcreteMediator : FacebookGroupMediator
    {
        private List<User> users = [];
        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var u in users)
            {
                //Message is not receive from who is sending it.
                if (u != user)
                {
                    u.Receive(msg);
                }
            }
        }
    }
}