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
using Adyen.Requests.PaymentMethodsMerchantLevel;

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
    /// Get all payment methods
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for all payment methods of the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<PaymentMethodResponse> GetMerchantsMerchantIdPaymentMethodSettings(GetMerchantsMerchantIdPaymentMethodSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("storeId", request.StoreId),
                new Param("businessLineId", request.BusinessLineId),
                new Param("pageSize", request.PageSize),
                new Param("pageNumber", request.PageNumber),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentMethodResponse>(),
            GetMerchantsMerchantIdPaymentMethodSettingsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get payment method details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for the merchant account and the payment method identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ManagementPaymentMethod>(),
            GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Apple Pay domains
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplePayResponseInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/enable-apple-pay#register-merchant-domain">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read
    /// </para>
    /// </remarks>
    public Task<ApplePayResponseInfo> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApplePayResponseInfo>(),
            GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a payment method
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment method details for the merchant account and the payment method identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ManagementPaymentMethod>(),
            PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Request a payment method
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ManagementPaymentMethod"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdPaymentMethodSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to add a new payment method to the merchant account identified in the path.
    /// Depending the payment method <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings#request-type"><c>type</c></see>, you may need to send an additional object required for the payment method.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task<ManagementPaymentMethod> PostMerchantsMerchantIdPaymentMethodSettings(PostMerchantsMerchantIdPaymentMethodSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ManagementPaymentMethod>(),
            PostMerchantsMerchantIdPaymentMethodSettingsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Add an Apple Pay domain
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds the new domain to the list of Apple Pay domains that are registered with the merchant account and the payment method identified in the path. For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/web-drop-in/?tab=adyen-certificate-live_1#going-live">Apple Pay documentation</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Payment methods read and write
    /// </para>
    /// </remarks>
    public Task PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("paymentMethodId", request.PaymentMethodId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
