using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError : ApiError
{
    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> _paymentInstrumentsAuthorisedCardUsers401Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> _paymentInstrumentsAuthorisedCardUsers403Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers404Error1> _paymentInstrumentsAuthorisedCardUsers404Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers422Error1> _paymentInstrumentsAuthorisedCardUsers422Error1Value;

    private GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError(Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> paymentInstrumentsAuthorisedCardUsers401Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> paymentInstrumentsAuthorisedCardUsers403Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers404Error1> paymentInstrumentsAuthorisedCardUsers404Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers422Error1> paymentInstrumentsAuthorisedCardUsers422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentInstrumentsAuthorisedCardUsers401Error1Value = paymentInstrumentsAuthorisedCardUsers401Error1Value;
        _paymentInstrumentsAuthorisedCardUsers403Error1Value = paymentInstrumentsAuthorisedCardUsers403Error1Value;
        _paymentInstrumentsAuthorisedCardUsers404Error1Value = paymentInstrumentsAuthorisedCardUsers404Error1Value;
        _paymentInstrumentsAuthorisedCardUsers422Error1Value = paymentInstrumentsAuthorisedCardUsers422Error1Value;
    }

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers401Error1(PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        new(Optional<PaymentInstrumentsAuthorisedCardUsers401Error1>.Some(value), default, default, default, default);

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers403Error1(PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        new(default, Optional<PaymentInstrumentsAuthorisedCardUsers403Error1>.Some(value), default, default, default);

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers404Error1(PaymentInstrumentsAuthorisedCardUsers404Error1 value) =>
        new(default, default, Optional<PaymentInstrumentsAuthorisedCardUsers404Error1>.Some(value), default, default);

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers422Error1(PaymentInstrumentsAuthorisedCardUsers422Error1 value) =>
        new(default, default, default, Optional<PaymentInstrumentsAuthorisedCardUsers422Error1>.Some(value), default);

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers401Error1(out PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers401Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers403Error1(out PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers403Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers404Error1(out PaymentInstrumentsAuthorisedCardUsers404Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers404Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers422Error1(out PaymentInstrumentsAuthorisedCardUsers422Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers422Error1Value.TryGetValue(out value);

    internal static Task<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<PaymentInstrumentsAuthorisedCardUsers401Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers401Error1),
            403 => FromJson<PaymentInstrumentsAuthorisedCardUsers403Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers403Error1),
            404 => FromJson<PaymentInstrumentsAuthorisedCardUsers404Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers404Error1),
            422 => FromJson<PaymentInstrumentsAuthorisedCardUsers422Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse : IErrorResponse<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>
{
    public static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse Instance { get; } = new();

    private GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse()
    {
    }

    public Task<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Create(response, ct);
}
