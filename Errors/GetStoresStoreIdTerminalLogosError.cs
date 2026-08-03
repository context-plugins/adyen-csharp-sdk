using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetStoresStoreIdTerminalLogosError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetStoresStoreIdTerminalLogosError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetStoresStoreIdTerminalLogosError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetStoresStoreIdTerminalLogosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetStoresStoreIdTerminalLogosError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetStoresStoreIdTerminalLogosErrorResponse : IErrorResponse<GetStoresStoreIdTerminalLogosError>
{
    public static GetStoresStoreIdTerminalLogosErrorResponse Instance { get; } = new();

    private GetStoresStoreIdTerminalLogosErrorResponse()
    {
    }

    public Task<GetStoresStoreIdTerminalLogosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetStoresStoreIdTerminalLogosError.Create(response, ct);
}
