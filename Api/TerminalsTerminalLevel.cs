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

public sealed class TerminalsTerminalLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalsTerminalLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of terminals
    /// </summary>
    /// <param name="searchQuery">Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored.</param>
    /// <param name="otpQuery">Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored.</param>
    /// <param name="countries">Returns terminals located in the countries specified by their <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">two-letter country code</see>.</param>
    /// <param name="merchantIds">Returns terminals that belong to the merchant accounts specified by their unique merchant account ID.</param>
    /// <param name="storeIds">Returns terminals that are assigned to the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores">stores</see> specified by their unique store ID.</param>
    /// <param name="brandModels">Returns terminals of the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels">models</see> specified in the format *brand.model*.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTerminalsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminals that the API credential has access to and that match the query parameters.
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API — Terminal actions read
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListTerminalsResponse> GetTerminals(string? searchQuery,
        string? otpQuery,
        string? countries,
        string? merchantIds,
        string? storeIds,
        string? brandModels,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/terminals"),
            [],
            [new Param("searchQuery", searchQuery),
                new Param("otpQuery", otpQuery),
                new Param("countries", countries),
                new Param("merchantIds", merchantIds),
                new Param("storeIds", storeIds),
                new Param("brandModels", brandModels),
                new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTerminalsResponse>(),
            GetTerminalsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Reassign a terminal
    /// </summary>
    /// <param name="terminalId">The unique identifier of the payment terminal.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTerminalsTerminalIdReassignError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reassigns a payment terminal to a company account, merchant account, merchant account inventory, or a store.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Assign Terminal
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task PostTerminalsTerminalIdReassign(string terminalId,
        TerminalReassignmentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/terminals/{terminalId}/reassign"),
            [new TemplateParam("terminalId", terminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            VoidResponse.Instance,
            PostTerminalsTerminalIdReassignErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
