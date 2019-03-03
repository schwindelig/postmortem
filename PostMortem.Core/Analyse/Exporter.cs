using System.IO;
using Newtonsoft.Json;
using PostMortem.Core.Exceptions;
using Serilog;

namespace PostMortem.Core.Analyse
{
    public class Exporter
    {
        public void ExportJson(object data, string path)
        {
            Log.Verbose("Exporting data as JSON to {path}", path);

            if (File.Exists(path))
            {
                throw new FileAlreadyExistsException($"File at {path} already exists");
            }

            using (TextWriter textWriter = File.CreateText(path))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(textWriter, data);
                textWriter.Flush();
            }
        }

        public void ExportFile(string data, string path)
        {
            Log.Verbose("Exporting data to {path}", path);

            if (File.Exists(path))
            {
                throw new FileAlreadyExistsException($"File at {path} already exists");
            }

            File.WriteAllText(path, data);
        }
    }
}
