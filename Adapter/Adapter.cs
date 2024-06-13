using Newtonsoft.Json.Linq;
using OOP_C_;
using System.Reflection;

namespace Adapter
{
    public class Adapter : File_DLL
    {
        private Type _type;
        private Object converter;
        
        public Adapter()
        {
            string currentFilePath = Assembly.GetExecutingAssembly().Location;
            string currentDirectory = Path.GetDirectoryName(currentFilePath);

            string fullPath = Path.Combine(currentDirectory, "JsonToXmlConverterLib.dll");

            _type = Assembly.LoadFile(fullPath).GetType("JsonToXmlConverterLib.PluginJsonToXmlConverter");
            converter = Activator.CreateInstance(_type);
        }

        public override string settingItem { get => "JSON в XML"; }
        public override string PostSave(string preSave)
        {
            JArray jsonArray = JArray.Parse(preSave);
            JObject jsonObject = new JObject();
            jsonObject["Figures"] = jsonArray;
            string jsonObjectString = jsonObject.ToString();

            //MethodInfo method = obj.GetType().GetMethod("MethodName");
            //method.Invoke(obj, new object[] { arg1, arg2 });

            return (string)converter.GetType().GetMethod("JsonToXml").Invoke(converter, new object[] { jsonObjectString }); 
        }
        public override string PreOpen(string fileData)
        {

            fileData = (string)converter.GetType().GetMethod("XmlToJson").Invoke(converter, new object[] { fileData });

            JObject jsonObject = JObject.Parse(fileData);
            JArray jsonArray = (JArray)jsonObject["Figures"];
            return jsonArray.ToString();
        }
    }
}
