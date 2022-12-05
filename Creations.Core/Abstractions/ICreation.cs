using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core.Abstractions
{
    public interface ICreation
    {
        int Id { get; }
        string Name { get; }
        string Description { get;}
        IUser Author { get; }
        ICategory Category { get; }

        Vector3 Dimensions { get;}

        /// <summary>
        /// Weight in grams
        /// </summary>
        float Weight { get;}
        
        //future
        int? FileId { get; }
    }
}
