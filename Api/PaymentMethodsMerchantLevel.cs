using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class PaymentMethodsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentMethodsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-merchants-merchantId-paymentMethodSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="storeId">The unique identifier of the store for which to return the payment methods.</param>
    /// <param name="businessLineId">The unique identifier of the Business Line for which to return the payment methods.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for all payment methods of the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<PaymentMethodResponse> GetMerchantsMerchantIdPaymentMethodSettings(string merchantId,
        string? storeId,
        string? businessLineId,
        int? pageSize,
        int? pageNumber,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("storeId", storeId),
                new Param("businessLineId", businessLineId),
                new Param("pageSize", pageSize),
                new Param("pageNumber", pageNumber)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethodResponse>(),
            GetMerchantsMerchantIdPaymentMethodSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId-paymentMethodSettings-paymentMethodId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for the merchant account and the payment method identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId,
        string paymentMethodId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("paymentMethodId", paymentMethodId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ManagementPaymentMethod>(),
            GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId-paymentMethodSettings-paymentMethodId-getApplePayDomains
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplePayResponseInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<ApplePayResponseInfo> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(string merchantId,
        string paymentMethodId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("paymentMethodId", paymentMethodId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApplePayResponseInfo>(),
            GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-merchants-merchantId-paymentMethodSettings-paymentMethodId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment method details for the merchant account and the payment method identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId,
        string paymentMethodId,
        UpdatePaymentMethodInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("paymentMethodId", paymentMethodId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<ManagementPaymentMethod>(),
            PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantId-paymentMethodSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdPaymentMethodSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to add a new payment method to the merchant account identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> PostMerchantsMerchantIdPaymentMethodSettings(string merchantId,
        PaymentMethodSetupInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ManagementPaymentMethod>(),
            PostMerchantsMerchantIdPaymentMethodSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantId-paymentMethodSettings-paymentMethodId-addApplePayDomains
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(string merchantId,
        string paymentMethodId,
        ApplePayInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("paymentMethodId", paymentMethodId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
