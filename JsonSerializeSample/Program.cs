using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace JsonSerializeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Json serialize.");
            Serialize();
        }

        static void Serialize()
        {
            var sampleData = new SampleData()
            {
                Body = new Body()
                {
                    Origin = new Origin() { type = "player" },
                    commandLine = "time set 0",
                    version = "1"
                },

                Header = new Header()
                {
                    requestId = "e608eba7-13cb-48f9-b8d5-139088cc7cd8",
                    messagePurpose = "commandRequest",
                    version = "1",
                    messageType = "commandRequest"
                }
            };

            var serializer = new DataContractJsonSerializer(typeof(SampleData));
            var ms = new MemoryStream();
            serializer.WriteObject(ms, sampleData);
            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
        }
    }
}
