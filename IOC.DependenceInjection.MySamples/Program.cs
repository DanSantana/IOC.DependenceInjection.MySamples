using System;

namespace IOC.DependenceInjection.MySamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new MessageManager(new ReceptionService());
            string result = message.HelloMessage("Carol");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
