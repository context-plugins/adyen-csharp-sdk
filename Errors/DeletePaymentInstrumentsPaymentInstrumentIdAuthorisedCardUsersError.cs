using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError : ApiError
{
    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> _paymentInstrumentsAuthorisedCardUsers401Error1Value;

    private readonly Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> _paymentInstrumentsAuthorisedCardUsers403Error1Value;

    private DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError(Optional<PaymentInstrumentsAuthorisedCardUsers401Error1> paymentInstrumentsAuthorisedCardUsers401Error1Value,
        Optional<PaymentInstrumentsAuthorisedCardUsers403Error1> paymentInstrumentsAuthorisedCardUsers403Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _paymentInstrumentsAuthorisedCardUsers401Error1Value = paymentInstrumentsAuthorisedCardUsers401Error1Value;
        _paymentInstrumentsAuthorisedCardUsers403Error1Value = paymentInstrumentsAuthorisedCardUsers403Error1Value;
    }

    private static DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers401Error1(PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        new(Optional<PaymentInstrumentsAuthorisedCardUsers401Error1>.Some(value), default, default);

    private static DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsPaymentInstrumentsAuthorisedCardUsers403Error1(PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        new(default, Optional<PaymentInstrumentsAuthorisedCardUsers403Error1>.Some(value), default);

    private static DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers401Error1(out PaymentInstrumentsAuthorisedCardUsers401Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers401Error1Value.TryGetValue(out value);

    public bool TryGetPaymentInstrumentsAuthorisedCardUsers403Error1(out PaymentInstrumentsAuthorisedCardUsers403Error1 value) =>
        _paymentInstrumentsAuthorisedCardUsers403Error1Value.TryGetValue(out value);

    internal static Task<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<PaymentInstrumentsAuthorisedCardUsers401Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers401Error1),
            403 => FromJson<PaymentInstrumentsAuthorisedCardUsers403Error1>(response, ct).As(AsPaymentInstrumentsAuthorisedCardUsers403Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse : IErrorResponse<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>
{
    public static DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse Instance { get; } = new();

    private DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersErrorResponse()
    {
    }

    public Task<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.Create(response, ct);
}
