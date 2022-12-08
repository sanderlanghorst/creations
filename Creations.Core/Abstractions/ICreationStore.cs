using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Core.Abstractions
{
    public interface ICreationStore
    {
        ICreation GetCreation(int id);
        ICollection<ICreation> GetCreations(IUser user);
        bool InsertCreation(ICreation creation);
        bool UpdateCreation(ICreation creation);
        bool DeleteCreation(int id);

        ICollection<ICategory> GetCategories();
        ICategory GetCategory(int id);
        bool InsertCategory(ICategory category);
        bool UpdateCategory(ICategory category);
        bool DeleteCategory(int id);
    }
}
