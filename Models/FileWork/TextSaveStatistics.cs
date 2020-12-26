using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    class TextSaveStatistics : ATextSave
    {
        StreamWriter Writer;
        FileStream fileStream;

        public override void Save(string path, object o)
        {
            using (fileStream = new FileStream(path, FileMode.Create))
            {
                using (Writer = new StreamWriter(fileStream))
                {
                    IEnumerable<string> strings = (IEnumerable<string>)o;
                    foreach (string str in strings)
                        Writer.WriteLine(str);
                }
            }
        }
    }
}
