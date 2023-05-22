using System;

namespace ChainOfResponsibility02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss dezso = new Boss("Dezső", 99999999);
            Boss bela = new Boss(dezso, "Béla", 100000);
            Boss geza = new Boss(bela, "Géza", 10000);
            
            

            string item = "nyomtató";
            int price = 999999999;
            bool accept = false;

            accept = geza.AcceptRequest(item, price);

            Console.WriteLine(accept);
        }
    }
}
