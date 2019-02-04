using MalinaReborn.Core.Mappers;
using MalinaReborn.Core.Models;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MalinaReborn.Core.SourcesLists
{
    public class FileSourceList : ISourceList
    {
        private readonly FileSourceOptions _options;
        private readonly SourceFactory _sourceFactory;

        public FileSourceList(IOptions<FileSourceOptions> options, SourceFactory sourceFactory)
        {
            _options = options.Value;
            _sourceFactory = sourceFactory;
        }

        public IEnumerable<Source> Get()
        {
            return Directory.EnumerateFiles(_options.Path, "*", SearchOption.AllDirectories)
                .Where(FileHasRequiredExtension)
                .Select(_sourceFactory.CreateSource);
        }

        private bool FileHasRequiredExtension(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }

            return _options.Extensions.Any(path.EndsWith);
        }
    }
}
