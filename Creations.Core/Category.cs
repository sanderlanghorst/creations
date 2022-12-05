using Creations.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core
{
    internal class Category : ICategory, IComparable<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CompareTo(Category? other)
        {
            if (other == null)
                return 1;
            return other.Id - Id;
        }
    }
}
