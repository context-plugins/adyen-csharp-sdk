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

public sealed class GrantsApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal GrantsApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get the details of a grant
    /// </summary>
    /// <param name="grantId">The unique identifier of the grant reference.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsGrantIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified grant.
    /// </remarks>
    public Task<Grant> GetGrantsGrantId(string grantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants/{grantId}"),
            [new TemplateParam("grantId", grantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Grant>(),
            GetGrantsGrantIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the disbursements of a grant
    /// </summary>
    /// <param name="grantId">The unique identifier of the grant reference.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursements"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsGrantIdDisbursementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the disbursements of a specified grant.
    /// </remarks>
    public Task<Disbursements> GetGrantsGrantIdDisbursements(string grantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants/{grantId}/disbursements"),
            [new TemplateParam("grantId", grantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Disbursements>(),
            GetGrantsGrantIdDisbursementsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get disbursement details
    /// </summary>
    /// <param name="grantId">The unique identifier of the grant reference.</param>
    /// <param name="disbursementId">The unique identifier of the disbursement.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsGrantIdDisbursementsDisbursementIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a disbursement specified in the path.
    /// </remarks>
    public Task<Disbursement> GetGrantsGrantIdDisbursementsDisbursementId(string grantId,
        string disbursementId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants/{grantId}/disbursements/{disbursementId}"),
            [new TemplateParam("grantId", grantId), new TemplateParam("disbursementId", disbursementId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Disbursement>(),
            GetGrantsGrantIdDisbursementsDisbursementIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get all the grants of an account holder
    /// </summary>
    /// <param name="counterpartyAccountHolderId">The unique identifier of the account holder that received the grants.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grants"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrants2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all the grants of a specific account holder.
    /// </remarks>
    public Task<Grants> GetGrants2(string counterpartyAccountHolderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants"),
            [],
            [new Param("counterpartyAccountHolderId", counterpartyAccountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Grants>(),
            GetGrants2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Update the repayment configuration of a disbursement
    /// </summary>
    /// <param name="grantId">The unique identifier of the grant reference.</param>
    /// <param name="disbursementId">The unique identifier of the disbursement.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchGrantsGrantIdDisbursementsDisbursementIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the percentage of your user's net income that is deducted for repaying the grant.
    /// </remarks>
    public Task<Disbursement> PatchGrantsGrantIdDisbursementsDisbursementId(string grantId,
        string disbursementId,
        DisbursementInfoUpdate body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants/{grantId}/disbursements/{disbursementId}"),
            [new TemplateParam("grantId", grantId), new TemplateParam("disbursementId", disbursementId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Disbursement>(),
            PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Make a request for a grant
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGrants2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Make a request for a grant on behalf of an account holder.
    /// </remarks>
    public Task<Grant> PostGrants2(CapitalGrantInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default15("/grants"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Grant>(),
            PostGrants2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}
