using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetNetworkTokensNetworkTokenIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetNetworkTokensNetworkTokenIdError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetNetworkTokensNetworkTokenIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetNetworkTokensNetworkTokenIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetNetworkTokensNetworkTokenIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetNetworkTokensNetworkTokenIdErrorResponse : IErrorResponse<GetNetworkTokensNetworkTokenIdError>
{
    public static GetNetworkTokensNetworkTokenIdErrorResponse Instance { get; } = new();

    private GetNetworkTokensNetworkTokenIdErrorResponse()
    {
    }

    public Task<GetNetworkTokensNetworkTokenIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetNetworkTokensNetworkTokenIdError.Create(response, ct);
}
