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
using Adyen.Requests.DirectDebitMandates;

namespace Adyen.Api;

public sealed class DirectDebitMandates
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal DirectDebitMandates(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get a list of mandates
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMandatesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMandatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandates</see> created for a business account.
    /// </remarks>
    public Task<ListMandatesResponse> GetMandates(GetMandatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/mandates"),
            [],
            [
                new Param("balanceAccountId", request.BalanceAccountId),
                new Param("paymentInstrumentId", request.PaymentInstrumentId),
                new Param("cursor", request.Cursor),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMandatesResponse>(),
            GetMandatesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a specific mandate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Mandate1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMandatesMandateIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task<Mandate1> GetMandatesMandateId(GetMandatesMandateIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/mandates/{mandateId}"),
            [new TemplateParam("mandateId", request.MandateId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Mandate1>(),
            GetMandatesMandateIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Amend a mandate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchMandatesMandateIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Amend the specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task PatchMandatesMandateId(PatchMandatesMandateIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/mandates/{mandateId}"),
            [new TemplateParam("mandateId", request.MandateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            VoidResponse.Instance,
            PatchMandatesMandateIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel a mandate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMandatesMandateIdCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task PostMandatesMandateIdCancel(PostMandatesMandateIdCancelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/mandates/{mandateId}/cancel"),
            [new TemplateParam("mandateId", request.MandateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostMandatesMandateIdCancelError.Response,
            [],
            requestOptions,
            cancellationToken);
}
