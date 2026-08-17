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
using Adyen.Models.Enums;

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
    /// <param name="accountHolderId">The unique identifier of the account holder that the dynamic offer is for.</param>
    /// <param name="financingType">The type of financing that the offer is for. If the value is not specified, returns all available types.  Possible values: <b>businessFinancing</b></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDynamicOffersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDynamicOffersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/">dynamic offers</see> available for <c>accountHolderId</c> specified as a query parameter.
    /// </remarks>
    public Task<GetDynamicOffersResponse> GetDynamicOffers(string accountHolderId,
        FinancingType? financingType,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/dynamicOffers"),
            [],
            [new Param("accountHolderId", accountHolderId), new Param("financingType", financingType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetDynamicOffersResponse>(),
            GetDynamicOffersErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Calculate a preliminary offer for a selected financing amount
    /// </summary>
    /// <param name="id">The unique identifier of the dynamic offer from which the user selected the financing amount.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculatedGrantOffer"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDynamicOffersIdCalculateError"/> when the server returns an error response.</exception>
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
    public Task<CalculatedGrantOffer> PostDynamicOffersIdCalculate(string id,
        CalculateGrantOfferRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/dynamicOffers/{id}/calculate"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculatedGrantOffer>(),
            PostDynamicOffersIdCalculateErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a static offer for a selected financing amount
    /// </summary>
    /// <param name="id">The unique identifier of the dynamic offer from which the user selected the financing amount.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDynamicOffersIdGrantOfferError"/> when the server returns an error response.</exception>
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
    public Task<GrantOffer1> PostDynamicOffersIdGrantOffer(string id,
        CreateGrantOfferRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/dynamicOffers/{id}/grantOffer"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GrantOffer1>(),
            PostDynamicOffersIdGrantOfferErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
