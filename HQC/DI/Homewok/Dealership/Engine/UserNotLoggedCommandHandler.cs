using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Engine
{
    public class RegisterUserCommandHandler : CommandHandler
    {
        private readonly IUserProvider userProvider;

        public RegisterUserCommandHandler(IUserProvider userProvider)
        {
            this.userProvider = userProvider;
        }

        protected override bool CanHandle(ICommand command)
        {
            return command.Name != "RegisterUser" && command.Name != "Login" && this.userProvider.LoggedUser == null;
        }

        protected override string HandleInternal(ICommand command)
        {
            return DealershipEngine.UserNotLogged;
        }
    }
}
