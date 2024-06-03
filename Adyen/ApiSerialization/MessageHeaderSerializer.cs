using HeadOn.Classic.Adyen.Model.Nexo;

namespace HeadOn.Classic.Adyen.ApiSerialization
{
    internal class MessageHeaderSerializer
    {
        internal MessageHeader Deserialize(string messageHeaderJson)
        {
            return Converter.JsonConvertDeserializerWrapper<MessageHeader>.DeserializeObject(messageHeaderJson);
        }
    }
}
