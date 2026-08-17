using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class PaymentsApp
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal PaymentsApp(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get a list of Payments Apps - merchant level
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="statuses">The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * <b>BOARDING</b>   * <b>BOARDED</b>   * <b>REVOKED</b></param>
    /// <param name="limit">The number of items to return.</param>
    /// <param name="offset">The number of items to skip.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentsAppResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPaymentsAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of Payments App instances for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<PaymentsAppResponse> GetMerchantsMerchantIdPaymentsApps(string merchantId,
        string? statuses,
        int? limit = 10,
        long? offset = 0L,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default26("/merchants/{merchantId}/paymentsApps"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("statuses", statuses), new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentsAppResponse>(),
            GetMerchantsMerchantIdPaymentsAppsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of Payments Apps - store level
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="statuses">The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.   Possible values:  * <b>BOARDING</b>   * <b>BOARDED</b>   * <b>REVOKED</b></param>
    /// <param name="limit">The number of items to return.</param>
    /// <param name="offset">The number of items to skip.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentsAppResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of Payments App instances for the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<PaymentsAppResponse> GetMerchantsMerchantIdStoresStoreIdPaymentsApps(string merchantId,
        string storeId,
        string? statuses,
        int? limit = 10,
        long? offset = 0L,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default26("/merchants/{merchantId}/stores/{storeId}/paymentsApps"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("storeId", storeId)],
            [new Param("statuses", statuses), new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentsAppResponse>(),
            GetMerchantsMerchantIdStoresStoreIdPaymentsAppsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a boarding token - merchant level
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BoardingTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the <c>boardingRequestToken</c> of the Payments App for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<BoardingTokenResponse> PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(string merchantId,
        BoardingTokenRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default26("/merchants/{merchantId}/generatePaymentsAppBoardingToken"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BoardingTokenResponse>(),
            PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Revoke Payments App instance authentication
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="installationId">The unique identifier of the Payments App instance on a device.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes the authentication of the Payments App instance for the <c>installationId</c> and merchant account identified in the path. This call revokes the authentication of the Payments App instance with the <c>installationId</c> identified in the path for both merchant accounts and stores.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<JsonElement> PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(string merchantId,
        string installationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default26("/merchants/{merchantId}/paymentsApps/{installationId}/revoke"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("installationId", installationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<JsonElement>(),
            PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a boarding token - store level
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BoardingTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the <c>boardingRequestToken</c> of the Payments App for the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<BoardingTokenResponse> PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(string merchantId,
        string storeId,
        BoardingTokenRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default26("/merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("storeId", storeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BoardingTokenResponse>(),
            PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
