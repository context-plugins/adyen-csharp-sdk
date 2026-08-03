using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostRatesCalculateError : ApiError
{
    private readonly Optional<RatesCalculate401Error1> _ratesCalculate401Error1Value;

    private readonly Optional<RatesCalculate403Error1> _ratesCalculate403Error1Value;

    private readonly Optional<RatesCalculate422Error1> _ratesCalculate422Error1Value;

    private PostRatesCalculateError(Optional<RatesCalculate401Error1> ratesCalculate401Error1Value,
        Optional<RatesCalculate403Error1> ratesCalculate403Error1Value,
        Optional<RatesCalculate422Error1> ratesCalculate422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _ratesCalculate401Error1Value = ratesCalculate401Error1Value;
        _ratesCalculate403Error1Value = ratesCalculate403Error1Value;
        _ratesCalculate422Error1Value = ratesCalculate422Error1Value;
    }

    private static PostRatesCalculateError AsRatesCalculate401Error1(RatesCalculate401Error1 value) =>
        new(Optional<RatesCalculate401Error1>.Some(value), default, default, default);

    private static PostRatesCalculateError AsRatesCalculate403Error1(RatesCalculate403Error1 value) =>
        new(default, Optional<RatesCalculate403Error1>.Some(value), default, default);

    private static PostRatesCalculateError AsRatesCalculate422Error1(RatesCalculate422Error1 value) =>
        new(default, default, Optional<RatesCalculate422Error1>.Some(value), default);

    private static PostRatesCalculateError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetRatesCalculate401Error1(out RatesCalculate401Error1 value) =>
        _ratesCalculate401Error1Value.TryGetValue(out value);

    public bool TryGetRatesCalculate403Error1(out RatesCalculate403Error1 value) =>
        _ratesCalculate403Error1Value.TryGetValue(out value);

    public bool TryGetRatesCalculate422Error1(out RatesCalculate422Error1 value) =>
        _ratesCalculate422Error1Value.TryGetValue(out value);

    internal static Task<PostRatesCalculateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<RatesCalculate401Error1>(response, ct).As(AsRatesCalculate401Error1),
            403 => FromJson<RatesCalculate403Error1>(response, ct).As(AsRatesCalculate403Error1),
            422 => FromJson<RatesCalculate422Error1>(response, ct).As(AsRatesCalculate422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostRatesCalculateErrorResponse : IErrorResponse<PostRatesCalculateError>
{
    public static PostRatesCalculateErrorResponse Instance { get; } = new();

    private PostRatesCalculateErrorResponse()
    {
    }

    public Task<PostRatesCalculateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostRatesCalculateError.Create(response, ct);
}
