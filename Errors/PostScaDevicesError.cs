using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostScaDevicesError : ApiError
{
    private readonly Optional<ScaDevices400Error1> _scaDevices400Error1Value;

    private readonly Optional<ScaDevices401Error1> _scaDevices401Error1Value;

    private readonly Optional<ScaDevices403Error1> _scaDevices403Error1Value;

    private readonly Optional<ScaDevices422Error1> _scaDevices422Error1Value;

    private readonly Optional<ScaDevices500Error1> _scaDevices500Error1Value;

    private PostScaDevicesError(Optional<ScaDevices400Error1> scaDevices400Error1Value,
        Optional<ScaDevices401Error1> scaDevices401Error1Value,
        Optional<ScaDevices403Error1> scaDevices403Error1Value,
        Optional<ScaDevices422Error1> scaDevices422Error1Value,
        Optional<ScaDevices500Error1> scaDevices500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _scaDevices400Error1Value = scaDevices400Error1Value;
        _scaDevices401Error1Value = scaDevices401Error1Value;
        _scaDevices403Error1Value = scaDevices403Error1Value;
        _scaDevices422Error1Value = scaDevices422Error1Value;
        _scaDevices500Error1Value = scaDevices500Error1Value;
    }

    private static PostScaDevicesError AsScaDevices400Error1(ScaDevices400Error1 value) =>
        new(Optional<ScaDevices400Error1>.Some(value), default, default, default, default, default);

    private static PostScaDevicesError AsScaDevices401Error1(ScaDevices401Error1 value) =>
        new(default, Optional<ScaDevices401Error1>.Some(value), default, default, default, default);

    private static PostScaDevicesError AsScaDevices403Error1(ScaDevices403Error1 value) =>
        new(default, default, Optional<ScaDevices403Error1>.Some(value), default, default, default);

    private static PostScaDevicesError AsScaDevices422Error1(ScaDevices422Error1 value) =>
        new(default, default, default, Optional<ScaDevices422Error1>.Some(value), default, default);

    private static PostScaDevicesError AsScaDevices500Error1(ScaDevices500Error1 value) =>
        new(default, default, default, default, Optional<ScaDevices500Error1>.Some(value), default);

    private static PostScaDevicesError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetScaDevices400Error1(out ScaDevices400Error1 value) =>
        _scaDevices400Error1Value.TryGetValue(out value);

    public bool TryGetScaDevices401Error1(out ScaDevices401Error1 value) =>
        _scaDevices401Error1Value.TryGetValue(out value);

    public bool TryGetScaDevices403Error1(out ScaDevices403Error1 value) =>
        _scaDevices403Error1Value.TryGetValue(out value);

    public bool TryGetScaDevices422Error1(out ScaDevices422Error1 value) =>
        _scaDevices422Error1Value.TryGetValue(out value);

    public bool TryGetScaDevices500Error1(out ScaDevices500Error1 value) =>
        _scaDevices500Error1Value.TryGetValue(out value);

    internal static Task<PostScaDevicesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ScaDevices400Error1>(response, ct).As(AsScaDevices400Error1),
            401 => FromJson<ScaDevices401Error1>(response, ct).As(AsScaDevices401Error1),
            403 => FromJson<ScaDevices403Error1>(response, ct).As(AsScaDevices403Error1),
            422 => FromJson<ScaDevices422Error1>(response, ct).As(AsScaDevices422Error1),
            500 => FromJson<ScaDevices500Error1>(response, ct).As(AsScaDevices500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostScaDevicesErrorResponse : IErrorResponse<PostScaDevicesError>
{
    public static PostScaDevicesErrorResponse Instance { get; } = new();

    private PostScaDevicesErrorResponse()
    {
    }

    public Task<PostScaDevicesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostScaDevicesError.Create(response, ct);
}
