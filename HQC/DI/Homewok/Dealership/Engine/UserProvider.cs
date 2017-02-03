using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Engine
{
    public class UserProvider : IUserProvider
    {
        private readonly ICollection<IUser> users;

        public UserProvider()
        {
            this.users = new Collection<IUser>();
        }

        public IUser LoggedUser { get; set; }

        public IEnumerable<IUser> Users
        {
            get
            {
                return this.users;
            }
        }

        public void AddUser(IUser user)
        {
            this.users.Add(user);
        }
    }

    public interface IUserProvider
    {
        void AddUser(IUser user);

        IEnumerable<IUser> Users { get; }

        IUser LoggedUser { get; set; }


    }
}
