using Newtonsoft.Json;

namespace HeadOn.Classic.Adyen.ApiSerialization.Converter
{
    internal class JsonConvertDeserializerWrapper<T>
    {
        internal static T DeserializeObject(string objectToDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(objectToDeserialize);
        }
    }
}
