﻿using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Account
{
    public class DeleteShareholder : Resource
    {
        public DeleteShareholder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/deleteShareholders")
        {
        }
    }
}
