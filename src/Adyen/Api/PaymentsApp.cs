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
using Adyen.Requests.PaymentsApp;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentsAppResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPaymentsAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of Payments App instances for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<PaymentsAppResponse> GetMerchantsMerchantIdPaymentsApps(GetMerchantsMerchantIdPaymentsAppsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default26("/merchants/{merchantId}/paymentsApps"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [
                new Param("statuses", request.Statuses),
                new Param("limit", request.Limit),
                new Param("offset", request.Offset),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentsAppResponse>(),
            GetMerchantsMerchantIdPaymentsAppsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of Payments Apps - store level
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentsAppResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of Payments App instances for the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<PaymentsAppResponse> GetMerchantsMerchantIdStoresStoreIdPaymentsApps(GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default26("/merchants/{merchantId}/stores/{storeId}/paymentsApps"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("storeId", request.StoreId)],
            [
                new Param("statuses", request.Statuses),
                new Param("limit", request.Limit),
                new Param("offset", request.Offset),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentsAppResponse>(),
            GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a boarding token - merchant level
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BoardingTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the <c>boardingRequestToken</c> of the Payments App for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<BoardingTokenResponse> PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default26("/merchants/{merchantId}/generatePaymentsAppBoardingToken"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BoardingTokenResponse>(),
            PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Revoke Payments App instance authentication
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes the authentication of the Payments App instance for the <c>installationId</c> and merchant account identified in the path. This call revokes the authentication of the Payments App instance with the <c>installationId</c> identified in the path for both merchant accounts and stores.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<JsonElement> PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default26("/merchants/{merchantId}/paymentsApps/{installationId}/revoke"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("installationId", request.InstallationId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<JsonElement>(),
            PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a boarding token - store level
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BoardingTokenResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a boarding token used to authenticate the installation of a Payments App instance on an Android device. The boarding token is created for the <c>boardingRequestToken</c> of the Payments App for the store identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Adyen Payments App role
    /// </para>
    /// </remarks>
    public Task<BoardingTokenResponse> PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default26("/merchants/{merchantId}/stores/{storeId}/generatePaymentsAppBoardingToken"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("storeId", request.StoreId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BoardingTokenResponse>(),
            PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError.Response,
            [],
            requestOptions,
            cancellationToken);
}
