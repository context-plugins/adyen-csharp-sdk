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

public sealed class Capital
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Capital(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-grants-id
    /// </summary>
    /// <param name="id">The unique identifier of the grant.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CapitalGrant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetGrantsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a capital account specified in the path.
    /// </remarks>
    public Task<CapitalGrant> GetGrantsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/grants/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CapitalGrant>(),
            GetGrantsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}
