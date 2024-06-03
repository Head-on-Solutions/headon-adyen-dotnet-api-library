using HeadOn.Classic.Adyen.Model.DataProtection;
using HeadOn.Classic.Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeadOn.Classic.Adyen.Test
{
    [TestClass]
    public class DataProtectionTest : BaseTest
    {
        [TestMethod]
        public void TestRequestSubjectErasure()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("Mocks/data-protection-response.json");
            var service = new DataProtectionService(client);
            var response = service.RequestSubjectErasure(new SubjectErasureByPspReferenceRequest());
            Assert.AreEqual(response.Result, SubjectErasureResponse.ResultEnum.ACTIVERECURRINGTOKENEXISTS);
        }
    }
}