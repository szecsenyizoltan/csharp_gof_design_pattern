using System;
using TemplateMethod.Logic;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonLogic logic = new PersonLogicJson("data.dat");
            var filtered = logic.Filter(t => true);
            
            
        }
    }
}
