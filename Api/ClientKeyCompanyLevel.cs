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

public sealed class ClientKeyCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClientKeyCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// post-companies-companyId-apiCredentials-apiCredentialId-generateClientKey
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateClientKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a new <see href="https://docs.adyen.com/development-resources/client-side-authentication#how-it-works">client key</see> for the API credential identified in the path. You can use the new client key a few minutes after generating it. The old client key stops working 24 hours after generating a new one.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<GenerateClientKeyResponse> PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKey(string companyId,
        string apiCredentialId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/apiCredentials/{apiCredentialId}/generateClientKey"),
            [new TemplateParam("companyId", companyId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateClientKeyResponse>(),
            PostCompaniesCompanyIdApiCredentialsApiCredentialIdGenerateClientKeyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
