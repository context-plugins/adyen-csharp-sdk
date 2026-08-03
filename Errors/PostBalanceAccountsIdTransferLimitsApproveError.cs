using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsIdTransferLimitsApproveError : ApiError
{
    private readonly Optional<BalanceAccountsTransferLimitsApprove401Error1> _balanceAccountsTransferLimitsApprove401Error1Value;

    private readonly Optional<BalanceAccountsTransferLimitsApprove404Error1> _balanceAccountsTransferLimitsApprove404Error1Value;

    private readonly Optional<BalanceAccountsTransferLimitsApprove422Error1> _balanceAccountsTransferLimitsApprove422Error1Value;

    private PostBalanceAccountsIdTransferLimitsApproveError(Optional<BalanceAccountsTransferLimitsApprove401Error1> balanceAccountsTransferLimitsApprove401Error1Value,
        Optional<BalanceAccountsTransferLimitsApprove404Error1> balanceAccountsTransferLimitsApprove404Error1Value,
        Optional<BalanceAccountsTransferLimitsApprove422Error1> balanceAccountsTransferLimitsApprove422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsTransferLimitsApprove401Error1Value = balanceAccountsTransferLimitsApprove401Error1Value;
        _balanceAccountsTransferLimitsApprove404Error1Value = balanceAccountsTransferLimitsApprove404Error1Value;
        _balanceAccountsTransferLimitsApprove422Error1Value = balanceAccountsTransferLimitsApprove422Error1Value;
    }

    private static PostBalanceAccountsIdTransferLimitsApproveError AsBalanceAccountsTransferLimitsApprove401Error1(BalanceAccountsTransferLimitsApprove401Error1 value) =>
        new(Optional<BalanceAccountsTransferLimitsApprove401Error1>.Some(value), default, default, default);

    private static PostBalanceAccountsIdTransferLimitsApproveError AsBalanceAccountsTransferLimitsApprove404Error1(BalanceAccountsTransferLimitsApprove404Error1 value) =>
        new(default, Optional<BalanceAccountsTransferLimitsApprove404Error1>.Some(value), default, default);

    private static PostBalanceAccountsIdTransferLimitsApproveError AsBalanceAccountsTransferLimitsApprove422Error1(BalanceAccountsTransferLimitsApprove422Error1 value) =>
        new(default, default, Optional<BalanceAccountsTransferLimitsApprove422Error1>.Some(value), default);

    private static PostBalanceAccountsIdTransferLimitsApproveError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsTransferLimitsApprove401Error1(out BalanceAccountsTransferLimitsApprove401Error1 value) =>
        _balanceAccountsTransferLimitsApprove401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimitsApprove404Error1(out BalanceAccountsTransferLimitsApprove404Error1 value) =>
        _balanceAccountsTransferLimitsApprove404Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimitsApprove422Error1(out BalanceAccountsTransferLimitsApprove422Error1 value) =>
        _balanceAccountsTransferLimitsApprove422Error1Value.TryGetValue(out value);

    internal static Task<PostBalanceAccountsIdTransferLimitsApproveError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceAccountsTransferLimitsApprove401Error1>(response, ct).As(AsBalanceAccountsTransferLimitsApprove401Error1),
            404 => FromJson<BalanceAccountsTransferLimitsApprove404Error1>(response, ct).As(AsBalanceAccountsTransferLimitsApprove404Error1),
            422 => FromJson<BalanceAccountsTransferLimitsApprove422Error1>(response, ct).As(AsBalanceAccountsTransferLimitsApprove422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalanceAccountsIdTransferLimitsApproveErrorResponse : IErrorResponse<PostBalanceAccountsIdTransferLimitsApproveError>
{
    public static PostBalanceAccountsIdTransferLimitsApproveErrorResponse Instance { get; } = new();

    private PostBalanceAccountsIdTransferLimitsApproveErrorResponse()
    {
    }

    public Task<PostBalanceAccountsIdTransferLimitsApproveError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostBalanceAccountsIdTransferLimitsApproveError.Create(response, ct);
}
