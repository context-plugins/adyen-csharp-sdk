using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.DynamicOffers;

namespace Adyen.Api;

public sealed class DynamicOffers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DynamicOffers(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get all available dynamic offers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDynamicOffersResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetDynamicOffersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/">dynamic offers</see> available for <c>accountHolderId</c> specified as a query parameter.
    /// </remarks>
    public Task<GetDynamicOffersResponse> GetDynamicOffers(GetDynamicOffersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/dynamicOffers"),
            [],
            [new Param("accountHolderId", request.AccountHolderId), new Param("financingType", request.FinancingType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetDynamicOffersResponse>(),
            GetDynamicOffersError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Calculate a preliminary offer for a selected financing amount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculatedGrantOffer"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDynamicOffersIdCalculateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculates a preliminary offer for the financing amount that the user selected from a <see href="https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/">dynamic offer</see>. The preliminary offer is for informational purposes only and cannot be used to initiate a grant.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 120 requests per minute.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 120 requests per minute.</description></item>
    /// </list>
    /// </remarks>
    public Task<CalculatedGrantOffer> PostDynamicOffersIdCalculate(PostDynamicOffersIdCalculateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/dynamicOffers/{id}/calculate"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CalculatedGrantOffer>(),
            PostDynamicOffersIdCalculateError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a static offer for a selected financing amount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDynamicOffersIdGrantOfferError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a static offer for the financing amount that the user selected from the <see href="https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/">dynamic offer</see>.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 30 requests per minute.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 30 requests per minute.</description></item>
    /// </list>
    /// </remarks>
    public Task<GrantOffer1> PostDynamicOffersIdGrantOffer(PostDynamicOffersIdGrantOfferRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/dynamicOffers/{id}/grantOffer"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GrantOffer1>(),
            PostDynamicOffersIdGrantOfferError.Response,
            [],
            requestOptions,
            cancellationToken);
}
