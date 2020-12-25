using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    abstract class ATextLoad :  AText, ILoad
    {
        public abstract object Load(string path);
    }
}
