using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsIdTransferLimitsError : ApiError
{
    private readonly Optional<BalanceAccountsTransferLimits400Error1> _balanceAccountsTransferLimits400Error1Value;

    private readonly Optional<BalanceAccountsTransferLimits401Error1> _balanceAccountsTransferLimits401Error1Value;

    private readonly Optional<BalanceAccountsTransferLimits422Error1> _balanceAccountsTransferLimits422Error1Value;

    private PostBalanceAccountsIdTransferLimitsError(Optional<BalanceAccountsTransferLimits400Error1> balanceAccountsTransferLimits400Error1Value,
        Optional<BalanceAccountsTransferLimits401Error1> balanceAccountsTransferLimits401Error1Value,
        Optional<BalanceAccountsTransferLimits422Error1> balanceAccountsTransferLimits422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsTransferLimits400Error1Value = balanceAccountsTransferLimits400Error1Value;
        _balanceAccountsTransferLimits401Error1Value = balanceAccountsTransferLimits401Error1Value;
        _balanceAccountsTransferLimits422Error1Value = balanceAccountsTransferLimits422Error1Value;
    }

    private static PostBalanceAccountsIdTransferLimitsError AsBalanceAccountsTransferLimits400Error1(BalanceAccountsTransferLimits400Error1 value) =>
        new(Optional<BalanceAccountsTransferLimits400Error1>.Some(value), default, default, default);

    private static PostBalanceAccountsIdTransferLimitsError AsBalanceAccountsTransferLimits401Error1(BalanceAccountsTransferLimits401Error1 value) =>
        new(default, Optional<BalanceAccountsTransferLimits401Error1>.Some(value), default, default);

    private static PostBalanceAccountsIdTransferLimitsError AsBalanceAccountsTransferLimits422Error1(BalanceAccountsTransferLimits422Error1 value) =>
        new(default, default, Optional<BalanceAccountsTransferLimits422Error1>.Some(value), default);

    private static PostBalanceAccountsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsTransferLimits400Error1(out BalanceAccountsTransferLimits400Error1 value) =>
        _balanceAccountsTransferLimits400Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimits401Error1(out BalanceAccountsTransferLimits401Error1 value) =>
        _balanceAccountsTransferLimits401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimits422Error1(out BalanceAccountsTransferLimits422Error1 value) =>
        _balanceAccountsTransferLimits422Error1Value.TryGetValue(out value);

    internal static Task<PostBalanceAccountsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<BalanceAccountsTransferLimits400Error1>(response, ct).As(AsBalanceAccountsTransferLimits400Error1),
            401 => FromJson<BalanceAccountsTransferLimits401Error1>(response, ct).As(AsBalanceAccountsTransferLimits401Error1),
            422 => FromJson<BalanceAccountsTransferLimits422Error1>(response, ct).As(AsBalanceAccountsTransferLimits422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalanceAccountsIdTransferLimitsErrorResponse : IErrorResponse<PostBalanceAccountsIdTransferLimitsError>
{
    public static PostBalanceAccountsIdTransferLimitsErrorResponse Instance { get; } = new();

    private PostBalanceAccountsIdTransferLimitsErrorResponse()
    {
    }

    public Task<PostBalanceAccountsIdTransferLimitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostBalanceAccountsIdTransferLimitsError.Create(response, ct);
}
