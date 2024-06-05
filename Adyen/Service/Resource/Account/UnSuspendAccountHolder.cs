﻿using HeadOn.Classic.Adyen.Constants;

namespace HeadOn.Classic.Adyen.Service.Resource.Account
{
    public class UnSuspendAccountHolder : Resource
    {
        public UnSuspendAccountHolder(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/unSuspendAccountHolder")
        {
        }
    }
}