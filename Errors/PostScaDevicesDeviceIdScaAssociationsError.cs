using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostScaDevicesDeviceIdScaAssociationsError : ApiError
{
    private readonly Optional<ScaDevicesScaAssociations400Error1> _scaDevicesScaAssociations400Error1Value;

    private readonly Optional<ScaDevicesScaAssociations401Error1> _scaDevicesScaAssociations401Error1Value;

    private readonly Optional<ScaDevicesScaAssociations403Error1> _scaDevicesScaAssociations403Error1Value;

    private readonly Optional<ScaDevicesScaAssociations404Error1> _scaDevicesScaAssociations404Error1Value;

    private readonly Optional<ScaDevicesScaAssociations422Error1> _scaDevicesScaAssociations422Error1Value;

    private readonly Optional<ScaDevicesScaAssociations500Error1> _scaDevicesScaAssociations500Error1Value;

    private PostScaDevicesDeviceIdScaAssociationsError(Optional<ScaDevicesScaAssociations400Error1> scaDevicesScaAssociations400Error1Value,
        Optional<ScaDevicesScaAssociations401Error1> scaDevicesScaAssociations401Error1Value,
        Optional<ScaDevicesScaAssociations403Error1> scaDevicesScaAssociations403Error1Value,
        Optional<ScaDevicesScaAssociations404Error1> scaDevicesScaAssociations404Error1Value,
        Optional<ScaDevicesScaAssociations422Error1> scaDevicesScaAssociations422Error1Value,
        Optional<ScaDevicesScaAssociations500Error1> scaDevicesScaAssociations500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _scaDevicesScaAssociations400Error1Value = scaDevicesScaAssociations400Error1Value;
        _scaDevicesScaAssociations401Error1Value = scaDevicesScaAssociations401Error1Value;
        _scaDevicesScaAssociations403Error1Value = scaDevicesScaAssociations403Error1Value;
        _scaDevicesScaAssociations404Error1Value = scaDevicesScaAssociations404Error1Value;
        _scaDevicesScaAssociations422Error1Value = scaDevicesScaAssociations422Error1Value;
        _scaDevicesScaAssociations500Error1Value = scaDevicesScaAssociations500Error1Value;
    }

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations400Error1(ScaDevicesScaAssociations400Error1 value) =>
        new(Optional<ScaDevicesScaAssociations400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations401Error1(ScaDevicesScaAssociations401Error1 value) =>
        new(default,
            Optional<ScaDevicesScaAssociations401Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations403Error1(ScaDevicesScaAssociations403Error1 value) =>
        new(default,
            default,
            Optional<ScaDevicesScaAssociations403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations404Error1(ScaDevicesScaAssociations404Error1 value) =>
        new(default,
            default,
            default,
            Optional<ScaDevicesScaAssociations404Error1>.Some(value),
            default,
            default,
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations422Error1(ScaDevicesScaAssociations422Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<ScaDevicesScaAssociations422Error1>.Some(value),
            default,
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsScaDevicesScaAssociations500Error1(ScaDevicesScaAssociations500Error1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<ScaDevicesScaAssociations500Error1>.Some(value),
            default);

    private static PostScaDevicesDeviceIdScaAssociationsError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetScaDevicesScaAssociations400Error1(out ScaDevicesScaAssociations400Error1 value) =>
        _scaDevicesScaAssociations400Error1Value.TryGetValue(out value);

    public bool TryGetScaDevicesScaAssociations401Error1(out ScaDevicesScaAssociations401Error1 value) =>
        _scaDevicesScaAssociations401Error1Value.TryGetValue(out value);

    public bool TryGetScaDevicesScaAssociations403Error1(out ScaDevicesScaAssociations403Error1 value) =>
        _scaDevicesScaAssociations403Error1Value.TryGetValue(out value);

    public bool TryGetScaDevicesScaAssociations404Error1(out ScaDevicesScaAssociations404Error1 value) =>
        _scaDevicesScaAssociations404Error1Value.TryGetValue(out value);

    public bool TryGetScaDevicesScaAssociations422Error1(out ScaDevicesScaAssociations422Error1 value) =>
        _scaDevicesScaAssociations422Error1Value.TryGetValue(out value);

    public bool TryGetScaDevicesScaAssociations500Error1(out ScaDevicesScaAssociations500Error1 value) =>
        _scaDevicesScaAssociations500Error1Value.TryGetValue(out value);

    internal static Task<PostScaDevicesDeviceIdScaAssociationsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ScaDevicesScaAssociations400Error1>(response, ct).As(AsScaDevicesScaAssociations400Error1),
            401 => FromJson<ScaDevicesScaAssociations401Error1>(response, ct).As(AsScaDevicesScaAssociations401Error1),
            403 => FromJson<ScaDevicesScaAssociations403Error1>(response, ct).As(AsScaDevicesScaAssociations403Error1),
            404 => FromJson<ScaDevicesScaAssociations404Error1>(response, ct).As(AsScaDevicesScaAssociations404Error1),
            422 => FromJson<ScaDevicesScaAssociations422Error1>(response, ct).As(AsScaDevicesScaAssociations422Error1),
            500 => FromJson<ScaDevicesScaAssociations500Error1>(response, ct).As(AsScaDevicesScaAssociations500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostScaDevicesDeviceIdScaAssociationsErrorResponse : IErrorResponse<PostScaDevicesDeviceIdScaAssociationsError>
{
    public static PostScaDevicesDeviceIdScaAssociationsErrorResponse Instance { get; } = new();

    private PostScaDevicesDeviceIdScaAssociationsErrorResponse()
    {
    }

    public Task<PostScaDevicesDeviceIdScaAssociationsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostScaDevicesDeviceIdScaAssociationsError.Create(response, ct);
}
