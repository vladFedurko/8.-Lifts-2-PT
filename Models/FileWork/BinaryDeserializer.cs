using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    internal class BinaryDeserializer : ABinaryLoad
    {
        BinaryFormatter format = new BinaryFormatter();
        FileStream fileStream;
        public override object Load(string path)
        {
            using (fileStream = new FileStream(path, FileMode.Open))
            {
                fileStream.Position = 0;
                object o = format.Deserialize(fileStream);
                if (o.GetType().Attributes.HasFlag(System.Reflection.TypeAttributes.Serializable))
                    //проверка на сериализумость полей???
                    return o;
                else return null;
            }
        }
    }
}
