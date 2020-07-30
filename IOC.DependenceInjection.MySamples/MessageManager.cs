using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.DependenceInjection.MySamples
{
    class MessageManager
    {
        private readonly IReceptionService _receptionService;
        public MessageManager(IReceptionService receptionService)
        {
            _receptionService = receptionService ??
                throw new ArgumentNullException(nameof(receptionService));
        }

        public string HelloMessage(string name) => _receptionService.Greeting(name);
    }
}
