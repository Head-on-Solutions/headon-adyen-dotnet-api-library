using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
    public class AccountHolderTransactionList : Resource
    {
        public AccountHolderTransactionList(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/accountHolderTransactionList")
        {
        }
    }
}
