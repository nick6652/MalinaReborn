using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MalinaReborn.Core.Models;

namespace MalinaReborn.Core.Mappers
{
    public class SourceFactory
    {
        public Source CreateSource(string path)
        {
            return new Source
            {
                Path = path,
                Title = Path.GetFileNameWithoutExtension(path)
            };
        }
    }
}
