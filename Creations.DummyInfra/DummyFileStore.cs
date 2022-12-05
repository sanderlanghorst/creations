using Creations.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.DummyInfra
{
    public class DummyFileStore : IFileStore
    {
        public IFile GetFile(int id)
        {
            throw new NotImplementedException();
        }

        public bool StoreFile(IFile file)
        {
            throw new NotImplementedException();
        }
    }
}
