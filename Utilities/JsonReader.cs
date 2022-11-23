using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BaseFramework.Utilities
{
    public class JsonReader
    {

        public JsonReader()
        {

        }
        public string ReadData(String value)
        {
            string filePath = System.IO.Directory.GetParent(@"../../../") + "/config.json";
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(filePath));    
            Console.WriteLine($"Browser ------- {jsonFile[value]}");
            return jsonFile[value];
        }
    }
}
