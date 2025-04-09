using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Utilities
{
    public class DataSerializer
    {



        public void XmlSerialize<T>(T obj, string filename)

        {

            using StreamWriter writer = new StreamWriter(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, obj);

        }

        public T XmlDeserialize<T>(string filename)

        {

            using StreamReader reader = new StreamReader(filename);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(reader);

        }


        public void JsonSerialize<T>(T obj, string filename)

        {

            string jsonString = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filename, jsonString);

        }


        public T JsonDeserialize<T>(string filename)

        {

            string jsonString = File.ReadAllText(filename);

            return JsonSerializer.Deserialize<T>(jsonString);

        }

    }
}
