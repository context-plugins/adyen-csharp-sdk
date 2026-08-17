using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse : IErrorResponse<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError>
{
    public static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse Instance { get; } = new();

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse()
    {
    }

    public Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.Create(response, ct);
}
