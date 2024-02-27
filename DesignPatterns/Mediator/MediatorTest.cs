using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class MediatorTest
    {
        public static void Validate(){
            var mediator = new ConcreteMediator();

            var user1 = new ConcreteUser(mediator, "Hello world");
            var user2 = new ConcreteUser(mediator, "foo");
            var user3 = new ConcreteUser(mediator, "bar");

            mediator.RegisterUser(user1);
            mediator.RegisterUser(user2);
            mediator.RegisterUser(user3);

            user1.Send("TESTEEE");
        }
    }
}