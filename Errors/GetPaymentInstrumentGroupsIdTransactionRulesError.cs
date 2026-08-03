using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetPaymentInstrumentGroupsIdTransactionRulesError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetPaymentInstrumentGroupsIdTransactionRulesError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetPaymentInstrumentGroupsIdTransactionRulesError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetPaymentInstrumentGroupsIdTransactionRulesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetPaymentInstrumentGroupsIdTransactionRulesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentInstrumentGroupsIdTransactionRulesErrorResponse : IErrorResponse<GetPaymentInstrumentGroupsIdTransactionRulesError>
{
    public static GetPaymentInstrumentGroupsIdTransactionRulesErrorResponse Instance { get; } = new();

    private GetPaymentInstrumentGroupsIdTransactionRulesErrorResponse()
    {
    }

    public Task<GetPaymentInstrumentGroupsIdTransactionRulesError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetPaymentInstrumentGroupsIdTransactionRulesError.Create(response, ct);
}
