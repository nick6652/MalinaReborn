using System.Collections.Generic;
using MalinaReborn.Core.Models;

namespace MalinaReborn.Core.SourcesLists
{
    interface ISourceList
    {
        IEnumerable<Source> Get();
    }
}
