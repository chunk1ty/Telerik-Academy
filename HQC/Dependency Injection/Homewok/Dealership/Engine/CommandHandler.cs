using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Engine
{
    public abstract class CommandHandler : ICommandHandler
    {
        public ICommandHandler Successor { get; set; }

        public string Handle(ICommand command)
        {
            if (this.CanHandle(command))
            {
                return this.HandleInternal(command);
            }

            if (this.Successor != null)
            {
                return this.Successor.Handle(command);
            }

            return string.Format("Invalid command", command.Name);
        }

        public void SetSuccessor(ICommandHandler commandHandler)
        {
            this.Successor = commandHandler;
        }

        protected abstract bool CanHandle(ICommand command);
        protected abstract string HandleInternal(ICommand command);
    }


    public interface ICommandHandler
    {
        string Handle(ICommand command);

        void SetSuccessor(ICommandHandler commandHandler);
    }
}
