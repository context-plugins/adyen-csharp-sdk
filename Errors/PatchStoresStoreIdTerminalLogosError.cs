using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchStoresStoreIdTerminalLogosError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchStoresStoreIdTerminalLogosError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchStoresStoreIdTerminalLogosError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchStoresStoreIdTerminalLogosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PatchStoresStoreIdTerminalLogosError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchStoresStoreIdTerminalLogosErrorResponse : IErrorResponse<PatchStoresStoreIdTerminalLogosError>
{
    public static PatchStoresStoreIdTerminalLogosErrorResponse Instance { get; } = new();

    private PatchStoresStoreIdTerminalLogosErrorResponse()
    {
    }

    public Task<PatchStoresStoreIdTerminalLogosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchStoresStoreIdTerminalLogosError.Create(response, ct);
}
