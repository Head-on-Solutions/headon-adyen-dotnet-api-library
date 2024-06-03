using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
    public class RefundFundsTransfer : Resource
    {
        public RefundFundsTransfer(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/refundFundsTransfer")
        {
        }
    }
}
