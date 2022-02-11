using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    public interface ILogger
    {
        public void Write(LogType type, string message);
        public void WriteError(string message);
        public void WriteWarning(string message);
        public void WriteInfo(string message);
    }
}
