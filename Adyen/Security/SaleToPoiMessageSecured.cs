using HeadOn.Classic.Adyen.Model.Nexo;

namespace HeadOn.Classic.Adyen.Security
{
    public class SaleToPoiMessageSecured
    {
        public MessageHeader MessageHeader { get; set; }

        public string NexoBlob { get; set; }

        public SecurityTrailer SecurityTrailer { get; set; }
    }
}
