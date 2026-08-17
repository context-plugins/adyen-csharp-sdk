using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsBalanceAccountIdRecurringTopUpsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceAccountsBalanceAccountIdRecurringTopUpsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceAccountsBalanceAccountIdRecurringTopUpsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceAccountsBalanceAccountIdRecurringTopUpsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse : IErrorResponse<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError>
{
    public static GetBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse Instance { get; } = new();

    private GetBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse()
    {
    }

    public Task<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBalanceAccountsBalanceAccountIdRecurringTopUpsError.Create(response, ct);
}
