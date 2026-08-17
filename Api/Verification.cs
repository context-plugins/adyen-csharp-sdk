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
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCheckAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Triggers the verification of an account holder even if the checks are not yet required for the volume that they are currently processing.
    /// </remarks>
    public Task<GenericResponse> PostCheckAccountHolder(PerformVerificationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/checkAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostCheckAccountHolderErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete bank accounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteBankAccountsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes bank accounts associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteBankAccounts(DeleteBankAccountRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/deleteBankAccounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteBankAccountsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete legal arrangements
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteLegalArrangementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes legal arrangements and/or legal arrangement entities associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteLegalArrangements(DeleteLegalArrangementRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/deleteLegalArrangements"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteLegalArrangementsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete payout methods
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeletePayoutMethodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes payout methods associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeletePayoutMethods(DeletePayoutMethodRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/deletePayoutMethods"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeletePayoutMethodsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete shareholders
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteShareholdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes shareholders associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteShareholders(DeleteShareholderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/deleteShareholders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteShareholdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete signatories
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteSignatoriesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes signatories associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostDeleteSignatories(DeleteSignatoriesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/deleteSignatories"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteSignatoriesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get documents
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetUploadedDocumentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetUploadedDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns documents that were previously uploaded for an account holder. Adyen uses the documents during the <see href="https://docs.adyen.com/classic-platforms/verification-process">verification process</see>.
    /// </remarks>
    public Task<GetUploadedDocumentsResponse> PostGetUploadedDocuments(GetUploadedDocumentsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/getUploadedDocuments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetUploadedDocumentsResponse>(),
            PostGetUploadedDocumentsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Upload a document
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateAccountHolderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostUploadDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a document for an account holder. Adyen uses the documents during the <see href="https://docs.adyen.com/classic-platforms/verification-process">verification process</see>.
    /// </remarks>
    public Task<UpdateAccountHolderResponse> PostUploadDocument(UploadDocumentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default10("/uploadDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateAccountHolderResponse>(),
            PostUploadDocumentErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
