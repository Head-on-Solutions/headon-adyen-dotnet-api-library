using HeadOn.Classic.Adyen.Model.MarketPay.Notification;
using HeadOn.Classic.Adyen.Model.Notification;
using HeadOn.Classic.Adyen.Util;

namespace HeadOn.Classic.Adyen.Webhooks
{
    public class WebhookHandler
    {
        public NotificationRequest HandleNotificationRequest(string jsonRequest)
        {
            return JsonOperation.Deserialize<NotificationRequest>(jsonRequest);
        }

        public IGenericWebhook HandleMarketpayNotificationJson(string jsonRequest)
        {
            return JsonOperation.Deserialize<IGenericWebhook>(jsonRequest);
        }
    }
}
