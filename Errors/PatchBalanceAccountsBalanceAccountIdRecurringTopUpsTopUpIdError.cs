using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError : ApiError
{
    private readonly Optional<BalanceAccountsRecurringTopUps400Error1> _balanceAccountsRecurringTopUps400Error1Value;

    private readonly Optional<BalanceAccountsRecurringTopUps401Error1> _balanceAccountsRecurringTopUps401Error1Value;

    private readonly Optional<BalanceAccountsRecurringTopUps403Error1> _balanceAccountsRecurringTopUps403Error1Value;

    private readonly Optional<BalanceAccountsRecurringTopUps422Error1> _balanceAccountsRecurringTopUps422Error1Value;

    private PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError(Optional<BalanceAccountsRecurringTopUps400Error1> balanceAccountsRecurringTopUps400Error1Value,
        Optional<BalanceAccountsRecurringTopUps401Error1> balanceAccountsRecurringTopUps401Error1Value,
        Optional<BalanceAccountsRecurringTopUps403Error1> balanceAccountsRecurringTopUps403Error1Value,
        Optional<BalanceAccountsRecurringTopUps422Error1> balanceAccountsRecurringTopUps422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsRecurringTopUps400Error1Value = balanceAccountsRecurringTopUps400Error1Value;
        _balanceAccountsRecurringTopUps401Error1Value = balanceAccountsRecurringTopUps401Error1Value;
        _balanceAccountsRecurringTopUps403Error1Value = balanceAccountsRecurringTopUps403Error1Value;
        _balanceAccountsRecurringTopUps422Error1Value = balanceAccountsRecurringTopUps422Error1Value;
    }

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsBalanceAccountsRecurringTopUps400Error1(BalanceAccountsRecurringTopUps400Error1 value) =>
        new(Optional<BalanceAccountsRecurringTopUps400Error1>.Some(value), default, default, default, default);

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsBalanceAccountsRecurringTopUps401Error1(BalanceAccountsRecurringTopUps401Error1 value) =>
        new(default, Optional<BalanceAccountsRecurringTopUps401Error1>.Some(value), default, default, default);

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsBalanceAccountsRecurringTopUps403Error1(BalanceAccountsRecurringTopUps403Error1 value) =>
        new(default, default, Optional<BalanceAccountsRecurringTopUps403Error1>.Some(value), default, default);

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsBalanceAccountsRecurringTopUps422Error1(BalanceAccountsRecurringTopUps422Error1 value) =>
        new(default, default, default, Optional<BalanceAccountsRecurringTopUps422Error1>.Some(value), default);

    private static PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsRecurringTopUps400Error1(out BalanceAccountsRecurringTopUps400Error1 value) =>
        _balanceAccountsRecurringTopUps400Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsRecurringTopUps401Error1(out BalanceAccountsRecurringTopUps401Error1 value) =>
        _balanceAccountsRecurringTopUps401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsRecurringTopUps403Error1(out BalanceAccountsRecurringTopUps403Error1 value) =>
        _balanceAccountsRecurringTopUps403Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsRecurringTopUps422Error1(out BalanceAccountsRecurringTopUps422Error1 value) =>
        _balanceAccountsRecurringTopUps422Error1Value.TryGetValue(out value);

    internal static Task<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<BalanceAccountsRecurringTopUps400Error1>(response, ct).As(AsBalanceAccountsRecurringTopUps400Error1),
            401 => FromJson<BalanceAccountsRecurringTopUps401Error1>(response, ct).As(AsBalanceAccountsRecurringTopUps401Error1),
            403 => FromJson<BalanceAccountsRecurringTopUps403Error1>(response, ct).As(AsBalanceAccountsRecurringTopUps403Error1),
            422 => FromJson<BalanceAccountsRecurringTopUps422Error1>(response, ct).As(AsBalanceAccountsRecurringTopUps422Error1),
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
