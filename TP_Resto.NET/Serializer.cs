using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace TP_Resto.NET
{
    class Serializer
    {
        public Serializer()
        {

        }

        public Serializer(Almacenamiento a)
        {

        }

        public void Guardar<T>(T obj, String path)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream(path, FileMode.Create);
            serializer.Serialize(stream, obj);
            stream.Close();

        }

        public T CargarArchivo<T>(String path)
        {

            T obj;

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream(path, FileMode.Open);
            obj = (T)serializer.Deserialize(stream);
            stream.Close();

            return obj;

        }
    }
}
