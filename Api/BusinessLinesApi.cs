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

public sealed class BusinessLinesApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BusinessLinesApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a business line
    /// </summary>
    /// <param name="id">The unique identifier of the business line to be deleted.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBusinessLinesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a business line.
    /// <para>
    ///  &gt;If you delete a business line linked to a <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">payment method</see>, it can affect your merchant account's ability to use the <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/_merchantId_/paymentMethodSettings">payment method</see>. The business line is removed from all linked merchant accounts.
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
    public Task DeleteBusinessLinesId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/businessLines/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteBusinessLinesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a business line
    /// </summary>
    /// <param name="id">The unique identifier of the business line.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BusinessLine"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBusinessLinesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the detail of a business line.
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
    public Task<BusinessLine> GetBusinessLinesId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/businessLines/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BusinessLine>(),
            GetBusinessLinesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update a business line
    /// </summary>
    /// <param name="id">The unique identifier of the business line.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BusinessLine"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBusinessLinesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a business line.
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
    public Task<BusinessLine> PatchBusinessLinesId(string id,
        BusinessLineInfoUpdate? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/businessLines/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<BusinessLine>(),
            PatchBusinessLinesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a business line
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BusinessLine"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBusinessLinesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a business line.
    /// <para>
    /// This resource contains information about your user's line of business, including their industry and their source of funds. Adyen uses this information to verify your users as required by payment industry regulations.Adyen informs you of the verification results through webhooks or API responses.
    /// </para>
    /// <para>
    /// You can create a maximum of 200 business lines per legal entity for payment processing.
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
    public Task<BusinessLine> PostBusinessLines(BusinessLineInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/businessLines"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BusinessLine>(),
            PostBusinessLinesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
