using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Account
{
    public class CloseAccountHolder : Resource
    {
        public CloseAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/closeAccountHolder")
        {
        }
    }
}
