using Observer.Subject;
using Observer.Subscribers;
using System;

namespace Observer
{
    internal class Program
    {
        static UI ui = new UI();
        static Repository repo = new Repository();
        static void Main(string[] args)
        {
            

            Person p = new Person();

            //p.Subscribe(ui);
            //p.Subscribe(repo);

            p.StateChanged += P_StateChanged;

            p.Name = "Béla";
            p.Salary = 3000;

            p.Salary = 5000;

            

            
        }

        private static void P_StateChanged(object sender, EventArgs e)
        {
            ui.Show(sender as Person);
            repo.Save(sender as Person);
        }
    }
}
