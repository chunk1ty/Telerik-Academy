using Dealership.Common.Enums;
using Dealership.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Engine
{
    public class UserNotLoggedCommandHandler : CommandHandler
    {
        private readonly IUserProvider userProvider;
        private readonly IDealershipFactory dealershipFactory;

        public UserNotLoggedCommandHandler(IUserProvider userProvider, IDealershipFactory dealershipFactory)
        {
            this.userProvider = userProvider;
            this.dealershipFactory = dealershipFactory;
        }

        protected override bool CanHandle(ICommand command)
        {
            return command.Name != "RegisterUser";
        }

        protected override string HandleInternal(ICommand command)
        {
            var username = command.Parameters[0];
            var firstName = command.Parameters[1];
            var lastName = command.Parameters[2];
            var password = command.Parameters[3];

            var role = Role.Normal;

            if (command.Parameters.Count > 4)
            {
                role = (Role)Enum.Parse(typeof(Role), command.Parameters[4]);
            }

            return this.RegisterUser(username, firstName, lastName, password, role);
        }

        private string RegisterUser(string username, string firstName, string lastName, string password, Role role)
        {
            if (this.userProvider.LoggedUser != null)
            {
                return string.Format(DealershipEngine.UserLoggedInAlready, this.userProvider.LoggedUser.Username);
            }

            if (this.userProvider.Users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(DealershipEngine.UserAlreadyExist, username);
            }

            var user = this.dealershipFactory.CreateUser(username, firstName, lastName, password, role);
            this.userProvider.LoggedUser = user;
            this.userProvider.AddUser(user);

            return string.Format(DealershipEngine.UserRegisterеd, username);
        }
    }
}
