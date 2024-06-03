using System.Threading.Tasks;
using HeadOn.Classic.Adyen.Model;
using HeadOn.Classic.Adyen.Model.Hop;
using HeadOn.Classic.Adyen.Service.Resource.Hop;

namespace HeadOn.Classic.Adyen.Service
{
    public class HostedOnboardingPages : AbstractService
    {
        private readonly GetOnboardingUrl _getOnboardingUrl;

        public HostedOnboardingPages(Client client)
            : base(client)
        {
            _getOnboardingUrl = new GetOnboardingUrl(this);

        }

        /// <summary>
        /// Get Hosted Onboarding Page URL
        /// </summary>
        /// <param name="request">Request for Hosted Onboarding Page URL </param>
        /// <param name="requestOptions">Request options</param>
        /// <returns>Hosted Onboarding Page URL</returns>
        public GetOnboardingUrlResponse GetOnboardingUrl(GetOnboardingUrlRequest request,
            RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _getOnboardingUrl.Request(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<GetOnboardingUrlResponse>(jsonResponse);
        }

        /// <summary>
        /// Get Hosted Onboarding Page URL async
        /// </summary>
        /// <param name="request">Request for Hosted Onboarding Page URL </param>
        /// <param name="requestOptions">Request options</param>
        /// <returns>Hosted Onboarding Page URL</returns>
        public async Task<GetOnboardingUrlResponse> GetOnboardingUrlAsync(GetOnboardingUrlRequest request,
            RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = await _getOnboardingUrl.RequestAsync(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<GetOnboardingUrlResponse>(jsonResponse);
        }
    }
}