using Creations.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core
{
    public class Creation : ICreation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IUser Author { get; set; }

        public ICategory Category { get; set; }

        public Vector3 Dimensions { get; set; }

        public float Weight { get; set; }

        public int? FileId { get; set; }
    }
}
