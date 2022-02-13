using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    public interface IFileService
    {
        public void Init(string fileName, string fileExtension, string directoryPath, int capacity);
        public void Write(string text);
    }
}
