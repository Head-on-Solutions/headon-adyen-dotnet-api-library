using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
    public class TransferFunds : Resource
    {
        public TransferFunds(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/transferFunds")
        {
        }
    }
}
