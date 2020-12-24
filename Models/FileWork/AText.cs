using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    abstract class AText : IFileFormat
    {
        public const string Filter = "Text files(*.txt)|*.txt";
    }
}
