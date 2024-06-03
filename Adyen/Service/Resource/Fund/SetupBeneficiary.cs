using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Fund
{
   public class SetupBeneficiary : Resource
    {
        public SetupBeneficiary(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Fund/" + ClientConfig.MarketPayFundApiVersion + "/setupBeneficiary")
        {
        }
    }
}
