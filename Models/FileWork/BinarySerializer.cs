using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Models.FileWork
{
    internal class BinarySerializer : ABinarySave
    {
        BinaryFormatter format = new BinaryFormatter();
        FileStream fileStream;
        public override void Save(string path, object o)
        {
            using (fileStream = new FileStream(path, FileMode.Create))
            {
                if (o.GetType().Attributes.HasFlag(System.Reflection.TypeAttributes.Serializable))
                    //проверка на сериализумость полей не реализована
                    format.Serialize(fileStream, o);
            }
        }
    }
}
