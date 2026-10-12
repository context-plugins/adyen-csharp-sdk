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
using Adyen.Requests.GrantOffersApi;

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
    /// Get all available grant offers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffers"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantOffersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/platforms/capital#grant-offers">grant offers</see> available for <c>accountHolderId</c> specified as a query parameter.
    /// </remarks>
    public Task<GrantOffers> GetGrantOffers(GetGrantOffersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/grantOffers"),
            [],
            [new Param("accountHolderId", request.AccountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffers>(),
            GetGrantOffersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a grant offer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantOffersGrantOfferIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a single grant offer.
    /// </remarks>
    public Task<GrantOffer> GetGrantOffersGrantOfferId(GetGrantOffersGrantOfferIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/grantOffers/{grantOfferId}"),
            [new TemplateParam("grantOfferId", request.GrantOfferId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffer>(),
            GetGrantOffersGrantOfferIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the details of a static offer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffer1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantOffersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified static offer.
    /// </remarks>
    public Task<GrantOffer1> GetGrantOffersId(GetGrantOffersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grantOffers/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffer1>(),
            GetGrantOffersIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all available static offers
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GrantOffers"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantOffers1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/capital/get-grant-offers/static-offers">static offers</see> available for <c>accountHolderId</c> specified as a query parameter. This also includes static offers created for financing amounts that the user selected from <see href="https://docs.adyen.com/capital/get-grant-offers/dynamic-offers/">dynamic offers</see>.
    /// </remarks>
    public Task<GrantOffers> GetGrantOffers1(GetGrantOffers1Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grantOffers"),
            [],
            [new Param("accountHolderId", request.AccountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GrantOffers>(),
            GetGrantOffers1Error.Response,
            [],
            requestOptions,
            cancellationToken);
}
