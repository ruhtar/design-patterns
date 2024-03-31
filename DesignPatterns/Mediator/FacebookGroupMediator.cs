namespace DesignPatterns.Mediator
{
    public interface FacebookGroupMediator
    {
        //Sends the message to all registered users in the group.
        void SendMessage(string msg, User user);
        //Registers a User in the group.
        void RegisterUser(User user);
    }
}