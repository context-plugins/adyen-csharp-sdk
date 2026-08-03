using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchTerminalsTerminalIdTerminalSettingsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchTerminalsTerminalIdTerminalSettingsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchTerminalsTerminalIdTerminalSettingsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchTerminalsTerminalIdTerminalSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PatchTerminalsTerminalIdTerminalSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchTerminalsTerminalIdTerminalSettingsErrorResponse : IErrorResponse<PatchTerminalsTerminalIdTerminalSettingsError>
{
    public static PatchTerminalsTerminalIdTerminalSettingsErrorResponse Instance { get; } = new();

    private PatchTerminalsTerminalIdTerminalSettingsErrorResponse()
    {
    }

    public Task<PatchTerminalsTerminalIdTerminalSettingsError> Map(HttpResponseMessage response,
        CancellationToken ct) => PatchTerminalsTerminalIdTerminalSettingsError.Create(response, ct);
}
