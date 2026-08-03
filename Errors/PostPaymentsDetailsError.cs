using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsDetailsError : ApiError
{
    private readonly Optional<PaymentsDetails400Error1> _paymentsDetails400Error1Value;

    private readonly Optional<PaymentsDetails422Error1> _paymentsDetails422Error1Value;

    private readonly Optional<PaymentsDetails500Error1> _paymentsDetails500Error1Value;

    private PostPaymentsDetailsError(Optional<PaymentsDetails400Error1> paymentsDetails400Error1Value,
        Optional<PaymentsDetails422Error1> paymentsDetails422Error1Value,
        Optional<PaymentsDetails500Error1> paymentsDetails500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentsDetails400Error1Value = paymentsDetails400Error1Value;
        _paymentsDetails422Error1Value = paymentsDetails422Error1Value;
        _paymentsDetails500Error1Value = paymentsDetails500Error1Value;
    }

    private static PostPaymentsDetailsError AsPaymentsDetails400Error1(PaymentsDetails400Error1 value) =>
        new(Optional<PaymentsDetails400Error1>.Some(value), default, default, default);

    private static PostPaymentsDetailsError AsPaymentsDetails422Error1(PaymentsDetails422Error1 value) =>
        new(default, Optional<PaymentsDetails422Error1>.Some(value), default, default);

    private static PostPaymentsDetailsError AsPaymentsDetails500Error1(PaymentsDetails500Error1 value) =>
        new(default, default, Optional<PaymentsDetails500Error1>.Some(value), default);

    private static PostPaymentsDetailsError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentsDetails400Error1(out PaymentsDetails400Error1 value) =>
        _paymentsDetails400Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsDetails422Error1(out PaymentsDetails422Error1 value) =>
        _paymentsDetails422Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsDetails500Error1(out PaymentsDetails500Error1 value) =>
        _paymentsDetails500Error1Value.TryGetValue(out value);

    internal static Task<PostPaymentsDetailsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PaymentsDetails400Error1>(response, ct).As(AsPaymentsDetails400Error1),
            422 => FromJson<PaymentsDetails422Error1>(response, ct).As(AsPaymentsDetails422Error1),
            500 => FromJson<PaymentsDetails500Error1>(response, ct).As(AsPaymentsDetails500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsDetailsErrorResponse : IErrorResponse<PostPaymentsDetailsError>
{
    public static PostPaymentsDetailsErrorResponse Instance { get; } = new();

    private PostPaymentsDetailsErrorResponse()
    {
    }

    public Task<PostPaymentsDetailsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsDetailsError.Create(response, ct);
}
