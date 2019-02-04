using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalinaReborn.Core.Models
{
    public class FileSourceOptions
    {
        public string Path { get; set; }
        public IEnumerable<string> Extensions { get; set; }
    }
}
