using Creations.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core
{
    public sealed class User : IUser
    {
        public int Id { get; set; }

        public string Username { get; set; }
    }
}
