using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    abstract class ABinary : IFileFormat
    {
        public const string Filter = "Bin files(*.bin)|*.bin";
        public const string Format = "bin";
    }
}
