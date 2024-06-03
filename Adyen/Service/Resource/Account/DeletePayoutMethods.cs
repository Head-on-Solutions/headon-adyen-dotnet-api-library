using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Account
{
    public class DeletePayoutMethods : Resource
    {
        public DeletePayoutMethods(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/deletePayoutMethods")
        {
        }
    }
}
