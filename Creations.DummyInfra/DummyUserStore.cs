using Creations.Core.Abstractions;

namespace Creations.DummyInfra
{
    public class DummyUserStore : Core.Abstractions.IUserStore
    {
        public bool CreateUser(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IUser GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}