/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using HeadOn.Classic.Adyen.Constants;
using HeadOn.Classic.Adyen.Model;
using HeadOn.Classic.Adyen.Service.Resource;
using HeadOn.Classic.Adyen.Model.Management;

namespace HeadOn.Classic.Adyen.Service.Management
{
    /// <summary>
    /// WebhooksMerchantLevelService Interface
    /// </summary>
    public interface IWebhooksMerchantLevelService
    {
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        void RemoveWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Remove a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        Task RemoveWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ListWebhooksResponse"/>.</returns>
        ListWebhooksResponse ListAllWebhooks(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// List all webhooks
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="pageNumber"><see cref="int?"/> - The number of the page to fetch.</param>
        /// <param name="pageSize"><see cref="int?"/> - The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ListWebhooksResponse"/>.</returns>
        Task<ListWebhooksResponse> ListAllWebhooksAsync(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook GetWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> GetWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"><see cref="UpdateMerchantWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook UpdateWebhook(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="updateMerchantWebhookRequest"><see cref="UpdateMerchantWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> UpdateWebhookAsync(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"><see cref="CreateMerchantWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="Webhook"/>.</returns>
        Webhook SetUpWebhook(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Set up a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="createMerchantWebhookRequest"><see cref="CreateMerchantWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="Webhook"/>.</returns>
        Task<Webhook> SetUpWebhookAsync(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="GenerateHmacKeyResponse"/>.</returns>
        GenerateHmacKeyResponse GenerateHmacKey(string merchantId, string webhookId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Generate an HMAC key
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="GenerateHmacKeyResponse"/>.</returns>
        Task<GenerateHmacKeyResponse> GenerateHmacKeyAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"><see cref="TestWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TestWebhookResponse"/>.</returns>
        TestWebhookResponse TestWebhook(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Test a webhook
        /// </summary>
        /// <param name="merchantId"><see cref="string"/> - The unique identifier of the merchant account.</param>
        /// <param name="webhookId"><see cref="string"/> - Unique identifier of the webhook configuration.</param>
        /// <param name="testWebhookRequest"><see cref="TestWebhookRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TestWebhookResponse"/>.</returns>
        Task<TestWebhookResponse> TestWebhookAsync(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the WebhooksMerchantLevelService API endpoints
    /// </summary>
    public class WebhooksMerchantLevelService : AbstractService, IWebhooksMerchantLevelService
    {
        private readonly string _baseUrl;
        
        public WebhooksMerchantLevelService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://management-test.adyen.com/v1");
        }
        
        public void RemoveWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            RemoveWebhookAsync(merchantId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task RemoveWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            await resource.RequestAsync(null, requestOptions, new HttpMethod("DELETE"), cancellationToken).ConfigureAwait(false);
        }
        
        public ListWebhooksResponse ListAllWebhooks(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default)
        {
            return ListAllWebhooksAsync(merchantId, pageNumber, pageSize, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ListWebhooksResponse> ListAllWebhooksAsync(string merchantId, int? pageNumber = default, int? pageSize = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (pageNumber != null) queryParams.Add("pageNumber", pageNumber.ToString());
            if (pageSize != null) queryParams.Add("pageSize", pageSize.ToString());
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ListWebhooksResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook GetWebhook(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return GetWebhookAsync(merchantId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> GetWebhookAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook UpdateWebhook(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return UpdateWebhookAsync(merchantId, webhookId, updateMerchantWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> UpdateWebhookAsync(string merchantId, string webhookId, UpdateMerchantWebhookRequest updateMerchantWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(updateMerchantWebhookRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken).ConfigureAwait(false);
        }
        
        public Webhook SetUpWebhook(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default)
        {
            return SetUpWebhookAsync(merchantId, createMerchantWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Webhook> SetUpWebhookAsync(string merchantId, CreateMerchantWebhookRequest createMerchantWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Webhook>(createMerchantWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public GenerateHmacKeyResponse GenerateHmacKey(string merchantId, string webhookId, RequestOptions requestOptions = default)
        {
            return GenerateHmacKeyAsync(merchantId, webhookId, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<GenerateHmacKeyResponse> GenerateHmacKeyAsync(string merchantId, string webhookId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}/generateHmac";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<GenerateHmacKeyResponse>(null, requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public TestWebhookResponse TestWebhook(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default)
        {
            return TestWebhookAsync(merchantId, webhookId, testWebhookRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<TestWebhookResponse> TestWebhookAsync(string merchantId, string webhookId, TestWebhookRequest testWebhookRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/merchants/{merchantId}/webhooks/{webhookId}/test";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TestWebhookResponse>(testWebhookRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}