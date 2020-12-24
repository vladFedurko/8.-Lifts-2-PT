using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    abstract class ABinarySave : ABinary,ISave
    {
        public abstract void Save(string path, object o);
    }
}
