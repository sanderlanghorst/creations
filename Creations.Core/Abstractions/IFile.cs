using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core.Abstractions
{
    public interface IFile
    {
        string Name { get; }
        byte[] Data { get; }
        string MimeType { get; }
    }
}
