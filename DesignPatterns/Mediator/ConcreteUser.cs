using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator mediator, string message) : base(mediator, message)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{Name} : received <= {message} ");
        }

        public override void Send(string message)
        {
            Mediator.SendMessage(message, this);        
        }
    }
}