using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCashoutsError : ApiError
{
    private readonly Optional<Cashouts400Error1> _cashouts400Error1Value;

    private readonly Optional<Cashouts401Error1> _cashouts401Error1Value;

    private readonly Optional<Cashouts403Error1> _cashouts403Error1Value;

    private readonly Optional<Cashouts404Error1> _cashouts404Error1Value;

    private readonly Optional<Cashouts422Error1> _cashouts422Error1Value;

    private readonly Optional<Cashouts429Error1> _cashouts429Error1Value;

    private readonly Optional<Cashouts500Error1> _cashouts500Error1Value;

    private PostCashoutsError(Optional<Cashouts400Error1> cashouts400Error1Value,
        Optional<Cashouts401Error1> cashouts401Error1Value,
        Optional<Cashouts403Error1> cashouts403Error1Value,
        Optional<Cashouts404Error1> cashouts404Error1Value,
        Optional<Cashouts422Error1> cashouts422Error1Value,
        Optional<Cashouts429Error1> cashouts429Error1Value,
        Optional<Cashouts500Error1> cashouts500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _cashouts400Error1Value = cashouts400Error1Value;
        _cashouts401Error1Value = cashouts401Error1Value;
        _cashouts403Error1Value = cashouts403Error1Value;
        _cashouts404Error1Value = cashouts404Error1Value;
        _cashouts422Error1Value = cashouts422Error1Value;
        _cashouts429Error1Value = cashouts429Error1Value;
        _cashouts500Error1Value = cashouts500Error1Value;
    }

    private static PostCashoutsError AsCashouts400Error1(Cashouts400Error1 value) =>
        new(Optional<Cashouts400Error1>.Some(value), default, default, default, default, default, default, default);

    private static PostCashoutsError AsCashouts401Error1(Cashouts401Error1 value) =>
        new(default, Optional<Cashouts401Error1>.Some(value), default, default, default, default, default, default);

    private static PostCashoutsError AsCashouts403Error1(Cashouts403Error1 value) =>
        new(default, default, Optional<Cashouts403Error1>.Some(value), default, default, default, default, default);

    private static PostCashoutsError AsCashouts404Error1(Cashouts404Error1 value) =>
        new(default, default, default, Optional<Cashouts404Error1>.Some(value), default, default, default, default);

    private static PostCashoutsError AsCashouts422Error1(Cashouts422Error1 value) =>
        new(default, default, default, default, Optional<Cashouts422Error1>.Some(value), default, default, default);

    private static PostCashoutsError AsCashouts429Error1(Cashouts429Error1 value) =>
        new(default, default, default, default, default, Optional<Cashouts429Error1>.Some(value), default, default);

    private static PostCashoutsError AsCashouts500Error1(Cashouts500Error1 value) =>
        new(default, default, default, default, default, default, Optional<Cashouts500Error1>.Some(value), default);

    private static PostCashoutsError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetCashouts400Error1(out Cashouts400Error1 value) =>
        _cashouts400Error1Value.TryGetValue(out value);

    public bool TryGetCashouts401Error1(out Cashouts401Error1 value) =>
        _cashouts401Error1Value.TryGetValue(out value);

    public bool TryGetCashouts403Error1(out Cashouts403Error1 value) =>
        _cashouts403Error1Value.TryGetValue(out value);

    public bool TryGetCashouts404Error1(out Cashouts404Error1 value) =>
        _cashouts404Error1Value.TryGetValue(out value);

    public bool TryGetCashouts422Error1(out Cashouts422Error1 value) =>
        _cashouts422Error1Value.TryGetValue(out value);

    public bool TryGetCashouts429Error1(out Cashouts429Error1 value) =>
        _cashouts429Error1Value.TryGetValue(out value);

    public bool TryGetCashouts500Error1(out Cashouts500Error1 value) =>
        _cashouts500Error1Value.TryGetValue(out value);

    internal static Task<PostCashoutsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Cashouts400Error1>(response, ct).As(AsCashouts400Error1),
            401 => FromJson<Cashouts401Error1>(response, ct).As(AsCashouts401Error1),
            403 => FromJson<Cashouts403Error1>(response, ct).As(AsCashouts403Error1),
            404 => FromJson<Cashouts404Error1>(response, ct).As(AsCashouts404Error1),
            422 => FromJson<Cashouts422Error1>(response, ct).As(AsCashouts422Error1),
            429 => FromJson<Cashouts429Error1>(response, ct).As(AsCashouts429Error1),
            500 => FromJson<Cashouts500Error1>(response, ct).As(AsCashouts500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCashoutsErrorResponse : IErrorResponse<PostCashoutsError>
{
    public static PostCashoutsErrorResponse Instance { get; } = new();

    private PostCashoutsErrorResponse()
    {
    }

    public Task<PostCashoutsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCashoutsError.Create(response, ct);
}
