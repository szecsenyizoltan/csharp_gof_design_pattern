using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket error = new Ticket("printer", "My printer is not working...");
            error.Send();
            error.Close();
        }
    }
}
