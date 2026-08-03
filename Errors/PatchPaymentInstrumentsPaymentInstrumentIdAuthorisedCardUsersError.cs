using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError : ApiError
{
    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers400Error1> _paymentInstrumentsAuthorisedCardUsers400Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> _paymentInstrumentsAuthorisedCardUsers401Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> _paymentInstrumentsAuthorisedCardUsers403Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers422Error1> _paymentInstrumentsAuthorisedCardUsers422Error1Value;

    private PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError(Optional<PaymentInstrumentsAuthorisedCardUsers400Error1> paymentInstrumentsAuthorisedCardUsers400Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> paymentInstrumentsAuthorisedCardUsers401Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> paymentInstrumentsAuthorisedCardUsers403Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers422Error1> paymentInstrumentsAuthorisedCardUsers422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentInstrumentsAuthorisedCardUsers400Error1Value = paymentInstrumentsAuthorisedCardUsers400Error1Value;
        _paymentInstrumentsAuthorisedCardUsers401Error1Value = paymentInstrumentsAuthorisedCardUsers401Error1Value;
        _paymentInstrumentsAuthorisedCardUsers403Error1Value = paymentInstrumentsAuthorisedCardUsers403Error1Value;
        _paymentInstrumentsAuthorisedCardUsers422Error1Value = paymentInstrumentsAuthorisedCardUsers422Error1Value;
    }

    private static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers400Error1(PaymentInstrumentsAuthorisedCardUsers400Error1 value) =>
        new(Optional<PaymentInstrumentsAuthorisedCardUsers400Error1>.Some(value), default, default, default, default);

    private static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers401Error1(PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        new(default, Optional<PaymentInstrumentsAuthorisedCardUsers401Error1>.Some(value), default, default, default);

    private static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers403Error1(PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        new(default, default, Optional<PaymentInstrumentsAuthorisedCardUsers403Error1>.Some(value), default, default);

    private static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers422Error1(PaymentInstrumentsAuthorisedCardUsers422Error1 value) =>
        new(default, default, default, Optional<PaymentInstrumentsAuthorisedCardUsers422Error1>.Some(value), default);

    private static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers400Error1(out PaymentInstrumentsAuthorisedCardUsers400Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers400Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers401Error1(out PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers401Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers403Error1(out PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers403Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers422Error1(out PaymentInstrumentsAuthorisedCardUsers422Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers422Error1Value.TryGetValue(out value);

    internal static Task<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<PaymentInstrumentsAuthorisedCardUsers400Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers400Error1),
            401 => FromJson<PaymentInstrumentsAuthorisedCardUsers401Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers401Error1),
            403 => FromJson<PaymentInstrumentsAuthorisedCardUsers403Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers403Error1),
            422 => FromJson<PaymentInstrumentsAuthorisedCardUsers422Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse : IErrorResponse<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>
{
    public static PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse Instance { get; } = new();

    private PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse()
    {
    }

    public Task<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Create(response, ct);
}
