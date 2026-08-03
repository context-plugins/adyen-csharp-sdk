using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsCancelError : ApiError
{
    private readonly Optional<PaymentsCancel400Error1> _paymentsCancel400Error1Value;

    private readonly Optional<PaymentsCancel422Error1> _paymentsCancel422Error1Value;

    private readonly Optional<PaymentsCancel500Error1> _paymentsCancel500Error1Value;

    private PostPaymentsCancelError(Optional<PaymentsCancel400Error1> paymentsCancel400Error1Value,
        Optional<PaymentsCancel422Error1> paymentsCancel422Error1Value,
        Optional<PaymentsCancel500Error1> paymentsCancel500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentsCancel400Error1Value = paymentsCancel400Error1Value;
        _paymentsCancel422Error1Value = paymentsCancel422Error1Value;
        _paymentsCancel500Error1Value = paymentsCancel500Error1Value;
    }

    private static PostPaymentsCancelError AsPaymentsCancel400Error1(PaymentsCancel400Error1 value) =>
        new(Optional<PaymentsCancel400Error1>.Some(value), default, default, default);

    private static PostPaymentsCancelError AsPaymentsCancel422Error1(PaymentsCancel422Error1 value) =>
        new(default, Optional<PaymentsCancel422Error1>.Some(value), default, default);

    private static PostPaymentsCancelError AsPaymentsCancel500Error1(PaymentsCancel500Error1 value) =>
        new(default, default, Optional<PaymentsCancel500Error1>.Some(value), default);

    private static PostPaymentsCancelError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentsCancel400Error1(out PaymentsCancel400Error1 value) =>
        _paymentsCancel400Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsCancel422Error1(out PaymentsCancel422Error1 value) =>
        _paymentsCancel422Error1Value.TryGetValue(out value);

    public bool TryGetPaymentsCancel500Error1(out PaymentsCancel500Error1 value) =>
        _paymentsCancel500Error1Value.TryGetValue(out value);

    internal static Task<PostPaymentsCancelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PaymentsCancel400Error1>(response, ct).As(AsPaymentsCancel400Error1),
            422 => FromJson<PaymentsCancel422Error1>(response, ct).As(AsPaymentsCancel422Error1),
            500 => FromJson<PaymentsCancel500Error1>(response, ct).As(AsPaymentsCancel500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsCancelErrorResponse : IErrorResponse<PostPaymentsCancelError>
{
    public static PostPaymentsCancelErrorResponse Instance { get; } = new();

    private PostPaymentsCancelErrorResponse()
    {
    }

    public Task<PostPaymentsCancelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsCancelError.Create(response, ct);
}
