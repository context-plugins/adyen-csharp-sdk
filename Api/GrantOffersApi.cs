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

public sealed class GrantOffersApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GrantOffersApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-grantOffers
    /// </summary>
    /// <param name="accountHolderId">The unique identifier of the grant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffers"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantOffersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/platforms/capital#grant-offers">grant offers</see> available for <c>accountHolderId</c> specified as a query parameter.
    /// </remarks>
    public Task<GrantOffers> GetGrantOffers(string accountHolderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/grantOffers"),
            [],
            [new Param("accountHolderId", accountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffers>(),
            GetGrantOffersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-grantOffers-grantOfferId
    /// </summary>
    /// <param name="grantOfferId">The unique identifier of the grant offer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantOffersGrantOfferIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a single grant offer.
    /// </remarks>
    public Task<GrantOffer> GetGrantOffersGrantOfferId(string grantOfferId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/grantOffers/{grantOfferId}"),
            [new TemplateParam("grantOfferId", grantOfferId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffer>(),
            GetGrantOffersGrantOfferIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-grantOffers-id
    /// </summary>
    /// <param name="id">The unique identifier of the static offer.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantOffersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified static offer.
    /// </remarks>
    public Task<GrantOffer1> GetGrantOffersId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/grantOffers/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffer1>(),
            GetGrantOffersIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
