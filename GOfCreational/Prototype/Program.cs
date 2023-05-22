using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.Names = new string[] { "John", "Doe" };
            a.Address = new Address()
            {
                Street = "London Road",
                HouseNumber = 112
            };

            Person b = a.GetClone(true);
            b.Names[0] = "Jane";
            b.Address.HouseNumber += 10;
            ;
            

        }
    }
}
