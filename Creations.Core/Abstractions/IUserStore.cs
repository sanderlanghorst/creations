using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core.Abstractions
{
    public interface IUserStore
    {
        IUser GetUser(string username);

        bool CreateUser(IUser user);

        bool UpdateUser(IUser user);

        bool DeleteUser(int id);
    }
}
