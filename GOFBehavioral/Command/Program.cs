using Command.Data;
using Command.UI;
using System;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            UserInterface ui = new UserInterface(repo.People);

            ui.CreateCommand = new Commands.CreateCommand(repo);
            ui.DeleteCommand = new Commands.DeleteCommand(repo);

            ui.Show();
        }
    }
}
