using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5
{
    public class CreationTimeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var firstFile = x as FileInfo;
            var secondFile = y as FileInfo;

            if (firstFile != null && secondFile != null)
            {
                if (firstFile.CreationTimeUtc > secondFile.CreationTimeUtc)
                {
                    return 1;
                }
                else if (firstFile.CreationTimeUtc < secondFile.CreationTimeUtc)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new NotImplementedException("Невозможно сравнить два обьекта");
            }
        }
    }
}
