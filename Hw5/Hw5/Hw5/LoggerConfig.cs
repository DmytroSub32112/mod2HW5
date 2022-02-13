using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
   public class LoggerConfig
    {
        public string TimeFormat { get; set; }
        public string NameFormat { get; set; }
        public string DirectoryPath { get; set; }
        public string FileExtension { get; set; }
        public int DirectoryCapacity { get; set; }
    }
}
