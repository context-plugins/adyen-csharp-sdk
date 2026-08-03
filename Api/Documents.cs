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

public sealed class Documents
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Documents(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-documents-id
    /// </summary>
    /// <param name="id">The unique identifier of the document to be deleted.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a document.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task DeleteDocumentsId(string id, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/documents/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteDocumentsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-documents-id
    /// </summary>
    /// <param name="id">The unique identifier of the document.</param>
    /// <param name="skipContent">Do not load document content while fetching the document.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Document"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a document.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<Document> GetDocumentsId(string id,
        bool? skipContent,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/documents/{id}"),
            [new TemplateParam("id", id)],
            [new Param("skipContent", skipContent)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Document>(),
            GetDocumentsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-documents-id
    /// </summary>
    /// <param name="id">The unique identifier of the document to be updated.</param>
    /// <param name="xRequestedVerificationCode">Use the requested verification code 0_0001 to resolve any suberrors associated with the document. Requested verification codes can only be used in your test environment.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Document"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchDocumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a document.
    /// <para>
    ///  &gt;You can upload a maximum of 15 pages for photo IDs.
    /// </para>
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<Document> PatchDocumentsId(string id,
        string? xRequestedVerificationCode,
        Document? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/documents/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("x-requested-verification-code", xRequestedVerificationCode),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Document>(),
            PatchDocumentsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-documents
    /// </summary>
    /// <param name="xRequestedVerificationCode">Use a suberror code as your requested verification code. You can include one code at a time in your request header. Requested verification codes can only be used in your test environment.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Document"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDocumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads a document for verification checks.
    /// <para>
    ///  Adyen uses the information from the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities">legal entity</see> to run automated verification checks. If these checks fail, you will be notified to provide additional documents.
    /// </para>
    /// <para>
    ///  You should only upload documents when Adyen requests additional information for the legal entity.
    /// </para>
    /// <para>
    ///  &gt;You can upload a maximum of 15 pages for photo IDs.
    /// </para>
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<Document> PostDocuments(string? xRequestedVerificationCode,
        Document? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/documents"),
            [],
            [],
            [new HeaderParam("x-requested-verification-code", xRequestedVerificationCode),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Document>(),
            PostDocumentsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
