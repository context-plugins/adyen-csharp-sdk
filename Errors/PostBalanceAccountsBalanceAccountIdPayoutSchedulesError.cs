using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsBalanceAccountIdPayoutSchedulesError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostBalanceAccountsBalanceAccountIdPayoutSchedulesError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostBalanceAccountsBalanceAccountIdPayoutSchedulesError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostBalanceAccountsBalanceAccountIdPayoutSchedulesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse : IErrorResponse<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError>
{
    public static PostBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse Instance { get; } = new();

    private PostBalanceAccountsBalanceAccountIdPayoutSchedulesErrorResponse()
    {
    }

    public Task<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostBalanceAccountsBalanceAccountIdPayoutSchedulesError.Create(response, ct);
}
