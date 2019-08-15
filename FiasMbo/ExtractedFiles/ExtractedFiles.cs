using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.ExtractedFiles
{
    public class ExtractedFiles : IExtractedFiles
    {
        public List<string> SelectExtractedFiles()
        {
            List<string> ret = new List<string>();
            var directoriesPath = Path.Combine(Directory.GetCurrentDirectory(), DirectoryPaths.FILE_FOLDER);
            var directories = Directory.GetDirectories(directoriesPath);
            foreach (var directory in directories)
            {
                ret.AddRange(Directory.GetFiles(directory));
            }
            return ret;
        }
    }
}
