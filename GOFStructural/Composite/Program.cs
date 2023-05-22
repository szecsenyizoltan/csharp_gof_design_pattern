using Composite.Classes;
using System;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorkItem company = new Department("OE-NIK");

            IWorkItem szfi = new Department("SZFI");
            IWorkItem bmi = new Department("BMI");
            IWorkItem kri = new Department("KRI");

            company.AddChild(szfi);
            company.AddChild(bmi);
            company.AddChild(kri);

            IWorkItem vz = new Employee("Vámossy Zoltán");
            IWorkItem kd = new Employee("Kiss Dániel");

            szfi.AddChild(vz);
            szfi.AddChild(kd);

            IWorkItem lr = new Employee("Lovas Róbert");
            kri.AddChild(lr);

            IWorkItem hp = new Department("Haladó programozás");
            szfi.AddChild(hp);

            IWorkItem ka = new Employee("Kovács András");
            IWorkItem sm = new Employee("Sipos Miklós");
            hp.AddChild(ka);
            hp.AddChild(sm);

            hp.Display(1);
            Console.ReadKey();


        }
    }
}
