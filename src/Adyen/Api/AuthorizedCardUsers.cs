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
using Adyen.Requests.AuthorizedCardUsers;

namespace Adyen.Api;

public sealed class AuthorizedCardUsers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal AuthorizedCardUsers(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete the authorized users for a card.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the list of authorized users assigned to a card.
    /// </remarks>
    public Task DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers"),
            [new TemplateParam("paymentInstrumentId", request.PaymentInstrumentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get authorized users for a card.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthorisedCardUsers"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the authorized users for a card.
    /// </remarks>
    public Task<AuthorisedCardUsers> GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers"),
            [new TemplateParam("paymentInstrumentId", request.PaymentInstrumentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AuthorisedCardUsers>(),
            GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the authorized users for a card.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the list of authorized users for a card.
    /// <para>
    /// &gt;This request replaces all existing authorized users for the card.
    /// </para>
    /// </remarks>
    public Task PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers"),
            [new TemplateParam("paymentInstrumentId", request.PaymentInstrumentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create authorized users for a card.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns authorized users to a card. Users must have the <b>authorisedPaymentInstrumentUser</b> capability to be able to use the card.
    /// </remarks>
    public Task PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{paymentInstrumentId}/authorisedCardUsers"),
            [new TemplateParam("paymentInstrumentId", request.PaymentInstrumentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Response,
            [],
            requestOptions,
            cancellationToken);
}
