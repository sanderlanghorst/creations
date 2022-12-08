using Creations.Core.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creations.Application
{
    public class CreationManagement
    {
        private ICreationStore _store;
        private ILogger _logger;

        public CreationManagement(Microsoft.Extensions.Logging.ILogger logger, ICreationStore store)
        {
            _store = store;
            _logger = logger;
        }

        public ICreation? GetCreation(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            try
            {
                return _store.GetCreation(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "something went wrong");
            }
            return null;
        }
    }
}
