using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept.Decorator
{

    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }


    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        public void AddedBehavior()
        {

        }
    }

    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: ");
            component.Operation();
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client();

            ConcreteComponent concreteComponent = new ConcreteComponent();
            Console.WriteLine("Client: I've got a simple component:");
            client.ClientCode(concreteComponent);
            Console.WriteLine();

            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA();
            decorator1.SetComponent(concreteComponent);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB();
            decorator2.SetComponent(decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
        }
    }

   
}
