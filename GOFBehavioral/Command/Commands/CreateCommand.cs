using Command.Data;
using Command.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class CreateCommand
    {
        Repository repo;
        public CreateCommand(Repository repo)
        {
            this.repo = repo;
        }
        public void Execute(Person p)
        {
            repo.Add(p);
        }
    }
}
