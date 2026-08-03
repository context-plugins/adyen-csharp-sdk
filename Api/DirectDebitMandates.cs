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
    /// get-mandates
    /// </summary>
    /// <param name="balanceAccountId">The unique identifier of the balance account linked to the payment instrument.</param>
    /// <param name="paymentInstrumentId">The unique identifier of the payment instrument linked to the mandate.</param>
    /// <param name="cursor">The pagination cursor returned in a previous GET <c>/mandates</c> request.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMandatesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMandatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandates</see> created for a business account.
    /// </remarks>
    public Task<ListMandatesResponse> GetMandates(string? balanceAccountId,
        string? paymentInstrumentId,
        string? cursor,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mandates"),
            [],
            [new Param("balanceAccountId", balanceAccountId),
                new Param("paymentInstrumentId", paymentInstrumentId),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMandatesResponse>(),
            GetMandatesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-mandates-mandateId
    /// </summary>
    /// <param name="mandateId">The unique identifier of the mandate.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Mandate"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMandatesMandateIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task<Mandate> GetMandatesMandateId(string mandateId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mandates/{mandateId}"),
            [new TemplateParam("mandateId", mandateId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Mandate>(),
            GetMandatesMandateIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// patch-mandates-mandateId
    /// </summary>
    /// <param name="mandateId">The unique identifier of the mandate.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMandatesMandateIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Amend the specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task PatchMandatesMandateId(string mandateId,
        MandateUpdate body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mandates/{mandateId}"),
            [new TemplateParam("mandateId", mandateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            VoidResponse.Instance,
            PatchMandatesMandateIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// post-mandates-mandateId-cancel
    /// </summary>
    /// <param name="mandateId">The unique identifier of the mandate.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMandatesMandateIdCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancel a specified <see href="https://docs.adyen.com/business-accounts/accept-direct-debits-uk">direct debit mandate</see>.
    /// </remarks>
    public Task PostMandatesMandateIdCancel(string mandateId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mandates/{mandateId}/cancel"),
            [new TemplateParam("mandateId", mandateId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostMandatesMandateIdCancelErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
