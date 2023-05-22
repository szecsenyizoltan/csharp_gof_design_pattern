using Command.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class DeleteCommand
    {
        Repository repo;
        public DeleteCommand(Repository repo)
        {
            this.repo = repo;
        }
        public void Execute(int id)
        {
            repo.Delete(id);
        }
    }
}
