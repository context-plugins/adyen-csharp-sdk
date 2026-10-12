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
using Adyen.Requests.GrantsApi;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grant"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantsGrantIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the specified grant.
    /// </remarks>
    public Task<Grant> GetGrantsGrantId(GetGrantsGrantIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants/{grantId}"),
            [new TemplateParam("grantId", request.GrantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Grant>(),
            GetGrantsGrantIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all the disbursements of a grant
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursements"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantsGrantIdDisbursementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the disbursements of a specified grant.
    /// </remarks>
    public Task<Disbursements> GetGrantsGrantIdDisbursements(GetGrantsGrantIdDisbursementsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants/{grantId}/disbursements"),
            [new TemplateParam("grantId", request.GrantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Disbursements>(),
            GetGrantsGrantIdDisbursementsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get disbursement details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrantsGrantIdDisbursementsDisbursementIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a disbursement specified in the path.
    /// </remarks>
    public Task<Disbursement> GetGrantsGrantIdDisbursementsDisbursementId(GetGrantsGrantIdDisbursementsDisbursementIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants/{grantId}/disbursements/{disbursementId}"),
            [
                new TemplateParam("grantId", request.GrantId),
                new TemplateParam("disbursementId", request.DisbursementId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Disbursement>(),
            GetGrantsGrantIdDisbursementsDisbursementIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all the grants of an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grants"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetGrants2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all the grants of a specific account holder.
    /// </remarks>
    public Task<Grants> GetGrants2(GetGrants2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants"),
            [],
            [new Param("counterpartyAccountHolderId", request.CounterpartyAccountHolderId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Grants>(),
            GetGrants2Error.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the repayment configuration of a disbursement
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Disbursement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchGrantsGrantIdDisbursementsDisbursementIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the percentage of your user's net income that is deducted for repaying the grant.
    /// </remarks>
    public Task<Disbursement> PatchGrantsGrantIdDisbursementsDisbursementId(PatchGrantsGrantIdDisbursementsDisbursementIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants/{grantId}/disbursements/{disbursementId}"),
            [
                new TemplateParam("grantId", request.GrantId),
                new TemplateParam("disbursementId", request.DisbursementId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Disbursement>(),
            PatchGrantsGrantIdDisbursementsDisbursementIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Make a request for a grant
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Grant"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGrants2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Make a request for a grant on behalf of an account holder.
    /// </remarks>
    public Task<Grant> PostGrants2(PostGrants2Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default15("/grants"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Grant>(),
            PostGrants2Error.Response,
            [],
            requestOptions,
            cancellationToken);
}
