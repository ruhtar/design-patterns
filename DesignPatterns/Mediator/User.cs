using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public abstract class User
    {
        protected FacebookGroupMediator Mediator;
        protected string Name;

        public User(FacebookGroupMediator mediator, string name)
        {
            Mediator = mediator;
            Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}