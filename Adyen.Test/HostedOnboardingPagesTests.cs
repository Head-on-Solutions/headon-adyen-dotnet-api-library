using System.Threading.Tasks;
using HeadOn.Classic.Adyen.Model;
using HeadOn.Classic.Adyen.Model.Hop;
using HeadOn.Classic.Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeadOn.Classic.Adyen.Test
{
    [TestClass]
    public class HostedOnboardingPagesTest : BaseTest
    {
        /// <summary>
        /// test /getOnboardingUrl
        /// </summary>
        [TestMethod]
        public void TestGetOnboardingUrlSuccess()
        {
            var client =
                CreateMockTestClientApiKeyBasedRequest(
                    "Mocks/hop/get-onboarding-url-success.json");
            var hop = new HostedOnboardingPages(client);
            var getOnboardingUrlRequest = new GetOnboardingUrlRequest();
            var redirectResponse = hop.GetOnboardingUrl(getOnboardingUrlRequest, new RequestOptions());

            Assert.AreEqual("https://test.adyen.com/hop", redirectResponse.RedirectUrl);
            Assert.AreEqual("1234567890123456", redirectResponse.PspReference);
            Assert.AreEqual("success", redirectResponse.ResultCode);
            Assert.AreEqual(false, redirectResponse.SubmittedAsync);
        }

        /// <summary>
        /// test /getOnboardingUrl async
        /// </summary>
        [TestMethod]
        public async Task TestGetOnboardingUrlSuccessAsync()
        {
            var client =
                CreateAsyncMockTestClientApiKeyBasedRequest(
                    "Mocks/hop/get-onboarding-url-success-async.json");
            var hop = new HostedOnboardingPages(client);
            var getOnboardingUrlRequest = new GetOnboardingUrlRequest();
            var redirectResponse = await hop.GetOnboardingUrlAsync(getOnboardingUrlRequest, new RequestOptions());

            Assert.AreEqual("https://test.adyen.com/hop", redirectResponse.RedirectUrl);
            Assert.AreEqual("1234567890123456", redirectResponse.PspReference);
            Assert.AreEqual("success", redirectResponse.ResultCode);
            Assert.AreEqual(true, redirectResponse.SubmittedAsync);
        }
    }
}
