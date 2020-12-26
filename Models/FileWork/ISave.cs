using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    interface ISave : IFileWork
    {
        void Save(string path,object o);
    }
}
