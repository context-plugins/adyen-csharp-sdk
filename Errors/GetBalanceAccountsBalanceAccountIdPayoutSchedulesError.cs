using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse : IErrorResponse<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError>
{
    public static GetBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse Instance { get; } = new();

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse()
    {
    }

    public Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBalanceAccountsBalanceAccountIdPayoutSchedulesError.Create(response, ct);
}
