using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsIdTransferLimitsError : ApiError
{
    private readonly Optional<BalancePlatformsTransferLimits404Error1> _balancePlatformsTransferLimits404Error1Value;

    private readonly Optional<BalancePlatformsTransferLimits422Error1> _balancePlatformsTransferLimits422Error1Value;

    private GetBalancePlatformsIdTransferLimitsError(Optional<BalancePlatformsTransferLimits404Error1> balancePlatformsTransferLimits404Error1Value,
        Optional<BalancePlatformsTransferLimits422Error1> balancePlatformsTransferLimits422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balancePlatformsTransferLimits404Error1Value = balancePlatformsTransferLimits404Error1Value;
        _balancePlatformsTransferLimits422Error1Value = balancePlatformsTransferLimits422Error1Value;
    }

    private static GetBalancePlatformsIdTransferLimitsError AsBalancePlatformsTransferLimits404Error1(BalancePlatformsTransferLimits404Error1 value) =>
        new(Optional<BalancePlatformsTransferLimits404Error1>.Some(value), default, default);

    private static GetBalancePlatformsIdTransferLimitsError AsBalancePlatformsTransferLimits422Error1(BalancePlatformsTransferLimits422Error1 value) =>
        new(default, Optional<BalancePlatformsTransferLimits422Error1>.Some(value), default);

    private static GetBalancePlatformsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetBalancePlatformsTransferLimits404Error1(out BalancePlatformsTransferLimits404Error1 value) =>
        _balancePlatformsTransferLimits404Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsTransferLimits422Error1(out BalancePlatformsTransferLimits422Error1 value) =>
        _balancePlatformsTransferLimits422Error1Value.TryGetValue(out value);

    internal static Task<GetBalancePlatformsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<BalancePlatformsTransferLimits404Error1>(response, ct).As(AsBalancePlatformsTransferLimits404Error1),
            422 => FromJson<BalancePlatformsTransferLimits422Error1>(response, ct).As(AsBalancePlatformsTransferLimits422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsIdTransferLimitsErrorResponse : IErrorResponse<GetBalancePlatformsIdTransferLimitsError>
{
    public static GetBalancePlatformsIdTransferLimitsErrorResponse Instance { get; } = new();

    private GetBalancePlatformsIdTransferLimitsErrorResponse()
    {
    }

    public Task<GetBalancePlatformsIdTransferLimitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetBalancePlatformsIdTransferLimitsError.Create(response, ct);
}
