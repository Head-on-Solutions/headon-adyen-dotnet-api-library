using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
    public class RefundNotPaidOutTransfers : Resource
    {
        public RefundNotPaidOutTransfers(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/refundNotPaidOutTransfers")
        {
        }
    }
}
