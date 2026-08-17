using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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
