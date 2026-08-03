using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsConfirmError : ApiError
{
    private readonly Optional<PaymentsConfirm400Error1> _paymentsConfirm400Error1Value;

    private readonly Optional<PaymentsConfirm401Error1> _paymentsConfirm401Error1Value;

    private readonly Optional<PaymentsConfirm422Error1> _paymentsConfirm422Error1Value;

    private readonly Optional<PaymentsConfirm500Error1> _paymentsConfirm500Error1Value;

    private PostPaymentsConfirmError(Optional<PaymentsConfirm400Error1> paymentsConfirm400Error1Value,
        Optional<PaymentsConfirm401Error1> paymentsConfirm401Error1Value,
        Optional<PaymentsConfirm422Error1> paymentsConfirm422Error1Value,
        Optional<PaymentsConfirm500Error1> paymentsConfirm500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentsConfirm400Error1Value = paymentsConfirm400Error1Value;
        _paymentsConfirm401Error1Value = paymentsConfirm401Error1Value;
        _paymentsConfirm422Error1Value = paymentsConfirm422Error1Value;
        _paymentsConfirm500Error1Value = paymentsConfirm500Error1Value;
    }

    private static PostPaymentsConfirmError AsPaymentsConfirm400Error1(PaymentsConfirm400Error1 value) =>
        new(Optional<PaymentsConfirm400Error1>.Some(value), default, default, default, default);

    private static PostPaymentsConfirmError AsPaymentsConfirm401Error1(PaymentsConfirm401Error1 value) =>
        new(default, Optional<PaymentsConfirm401Error1>.Some(value), default, default, default);

    private static PostPaymentsConfirmError AsPaymentsConfirm422Error1(PaymentsConfirm422Error1 value) =>
        new(default, default, Optional<PaymentsConfirm422Error1>.Some(value), default, default);

    private static PostPaymentsConfirmError AsPaymentsConfirm500Error1(PaymentsConfirm500Error1 value) =>
        new(default, default, default, Optional<PaymentsConfirm500Error1>.Some(value), default);

    private static PostPaymentsConfirmError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentsConfirm400Error1(out PaymentsConfirm400Error1 value) =>
        _paymentsConfirm400Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsConfirm401Error1(out PaymentsConfirm401Error1 value) =>
        _paymentsConfirm401Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsConfirm422Error1(out PaymentsConfirm422Error1 value) =>
        _paymentsConfirm422Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsConfirm500Error1(out PaymentsConfirm500Error1 value) =>
        _paymentsConfirm500Error1Value.TryGetValue(out value);

    internal static Task<PostPaymentsConfirmError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PaymentsConfirm400Error1>(response, ct).As(AsPaymentsConfirm400Error1),
            401 => FromJson<PaymentsConfirm401Error1>(response, ct).As(AsPaymentsConfirm401Error1),
            422 => FromJson<PaymentsConfirm422Error1>(response, ct).As(AsPaymentsConfirm422Error1),
            500 => FromJson<PaymentsConfirm500Error1>(response, ct).As(AsPaymentsConfirm500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsConfirmErrorResponse : IErrorResponse<PostPaymentsConfirmError>
{
    public static PostPaymentsConfirmErrorResponse Instance { get; } = new();

    private PostPaymentsConfirmErrorResponse()
    {
    }

    public Task<PostPaymentsConfirmError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsConfirmError.Create(response, ct);
}
