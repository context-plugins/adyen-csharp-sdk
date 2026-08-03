using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetScaAssociationsError : ApiError
{
    private readonly Optional<ScaAssociations400Error1> _scaAssociations400Error1Value;

    private readonly Optional<ScaAssociations401Error1> _scaAssociations401Error1Value;

    private readonly Optional<ScaAssociations403Error1> _scaAssociations403Error1Value;

    private readonly Optional<ScaAssociations500Error1> _scaAssociations500Error1Value;

    private GetScaAssociationsError(Optional<ScaAssociations400Error1> scaAssociations400Error1Value,
        Optional<ScaAssociations401Error1> scaAssociations401Error1Value,
        Optional<ScaAssociations403Error1> scaAssociations403Error1Value,
        Optional<ScaAssociations500Error1> scaAssociations500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _scaAssociations400Error1Value = scaAssociations400Error1Value;
        _scaAssociations401Error1Value = scaAssociations401Error1Value;
        _scaAssociations403Error1Value = scaAssociations403Error1Value;
        _scaAssociations500Error1Value = scaAssociations500Error1Value;
    }

    private static GetScaAssociationsError AsScaAssociations400Error1(ScaAssociations400Error1 value) =>
        new(Optional<ScaAssociations400Error1>.Some(value), default, default, default, default);

    private static GetScaAssociationsError AsScaAssociations401Error1(ScaAssociations401Error1 value) =>
        new(default, Optional<ScaAssociations401Error1>.Some(value), default, default, default);

    private static GetScaAssociationsError AsScaAssociations403Error1(ScaAssociations403Error1 value) =>
        new(default, default, Optional<ScaAssociations403Error1>.Some(value), default, default);

    private static GetScaAssociationsError AsScaAssociations500Error1(ScaAssociations500Error1 value) =>
        new(default, default, default, Optional<ScaAssociations500Error1>.Some(value), default);

    private static GetScaAssociationsError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetScaAssociations400Error1(out ScaAssociations400Error1 value) =>
        _scaAssociations400Error1Value.TryGetValue(out value);

    public bool TryGetScaAssociations401Error1(out ScaAssociations401Error1 value) =>
        _scaAssociations401Error1Value.TryGetValue(out value);

    public bool TryGetScaAssociations403Error1(out ScaAssociations403Error1 value) =>
        _scaAssociations403Error1Value.TryGetValue(out value);

    public bool TryGetScaAssociations500Error1(out ScaAssociations500Error1 value) =>
        _scaAssociations500Error1Value.TryGetValue(out value);

    internal static Task<GetScaAssociationsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<ScaAssociations400Error1>(response, ct).As(AsScaAssociations400Error1),
            401 => FromJson<ScaAssociations401Error1>(response, ct).As(AsScaAssociations401Error1),
            403 => FromJson<ScaAssociations403Error1>(response, ct).As(AsScaAssociations403Error1),
            500 => FromJson<ScaAssociations500Error1>(response, ct).As(AsScaAssociations500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetScaAssociationsErrorResponse : IErrorResponse<GetScaAssociationsError>
{
    public static GetScaAssociationsErrorResponse Instance { get; } = new();

    private GetScaAssociationsErrorResponse()
    {
    }

    public Task<GetScaAssociationsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetScaAssociationsError.Create(response, ct);
}
