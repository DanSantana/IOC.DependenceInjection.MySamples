using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.DependenceInjection.MySamples
{
    class ReceptionService : IReceptionService
    {
        public string Greeting(string name) => $"Hello, {name}!";

    }
}
