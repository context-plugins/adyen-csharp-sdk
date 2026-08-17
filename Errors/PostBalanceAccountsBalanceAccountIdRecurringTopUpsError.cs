using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsBalanceAccountIdRecurringTopUpsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostBalanceAccountsBalanceAccountIdRecurringTopUpsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostBalanceAccountsBalanceAccountIdRecurringTopUpsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostBalanceAccountsBalanceAccountIdRecurringTopUpsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse : IErrorResponse<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError>
{
    public static PostBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse Instance { get; } = new();

    private PostBalanceAccountsBalanceAccountIdRecurringTopUpsErrorResponse()
    {
    }

    public Task<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostBalanceAccountsBalanceAccountIdRecurringTopUpsError.Create(response, ct);
}
