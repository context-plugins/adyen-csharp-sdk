using System;
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
using Adyen.Requests.Verification;

namespace Adyen.Api;

public sealed class Verification
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Verification(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Trigger verification
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCheckAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Triggers the verification of an account holder even if the checks are not yet required for the volume that they are currently processing.
    /// </remarks>
    public Task<GenericResponse> PostCheckAccountHolder(PostCheckAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/checkAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostCheckAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete bank accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteBankAccountsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes bank accounts associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteBankAccounts(PostDeleteBankAccountsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/deleteBankAccounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteBankAccountsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete legal arrangements
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteLegalArrangementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes legal arrangements and/or legal arrangement entities associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteLegalArrangements(PostDeleteLegalArrangementsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/deleteLegalArrangements"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteLegalArrangementsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete payout methods
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeletePayoutMethodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes payout methods associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeletePayoutMethods(PostDeletePayoutMethodsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/deletePayoutMethods"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeletePayoutMethodsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete shareholders
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteShareholdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes shareholders associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteShareholders(PostDeleteShareholdersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/deleteShareholders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteShareholdersError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete signatories
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteSignatoriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes signatories associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteSignatories(PostDeleteSignatoriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/deleteSignatories"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteSignatoriesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get documents
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetUploadedDocumentsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetUploadedDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns documents that were previously uploaded for an account holder. Adyen uses the documents during the <see href="https://docs.adyen.com/classic-platforms/verification-process">verification process</see>.
    /// </remarks>
    public Task<GetUploadedDocumentsResponse> PostGetUploadedDocuments(PostGetUploadedDocumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/getUploadedDocuments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetUploadedDocumentsResponse>(),
            PostGetUploadedDocumentsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Upload a document
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUploadDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a document for an account holder. Adyen uses the documents during the <see href="https://docs.adyen.com/classic-platforms/verification-process">verification process</see>.
    /// </remarks>
    public Task<UpdateAccountHolderResponse> PostUploadDocument(PostUploadDocumentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/uploadDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateAccountHolderResponse>(),
            PostUploadDocumentError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}
