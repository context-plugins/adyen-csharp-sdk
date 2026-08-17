using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdErrorResponse : IErrorResponse<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError>
{
    public static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdErrorResponse Instance { get; } = new();

    private PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdErrorResponse()
    {
    }

    public Task<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.Create(response, ct);
}
