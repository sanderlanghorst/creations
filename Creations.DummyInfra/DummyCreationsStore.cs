using Creations.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.DummyInfra
{
    public sealed class DummyCreationsStore : ICreationStore
    {
        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCreation(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ICategory> GetCategories()
        {
            throw new NotImplementedException();
        }

        public ICategory GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ICreation> GetCreations(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool InsertCategory(ICategory category)
        {
            throw new NotImplementedException();
        }

        public bool InsertCreation(ICreation creation)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(ICategory category)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCreation(ICreation creation)
        {
            throw new NotImplementedException();
        }
    }
}
