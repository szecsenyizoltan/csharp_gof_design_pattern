using Mediator.Data;
using Mediator.Mediator;
using Mediator.UI;
using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Messenger messenger = new Messenger();
            UserInterface ui = new UserInterface(messenger);
            Repository repo = new Repository(messenger);

            ui.Show();
        }
    }
}
