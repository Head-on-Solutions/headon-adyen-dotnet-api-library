using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
    public class AccountHolderBalance : Resource
    {
        public AccountHolderBalance(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/accountHolderBalance")
        {
        }
    }
}
