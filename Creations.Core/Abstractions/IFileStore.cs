using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core.Abstractions
{
    public interface IFileStore
    {
        IFile GetFile(int id);
        bool StoreFile(IFile file);
    }
}
