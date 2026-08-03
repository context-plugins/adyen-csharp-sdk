using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceTransfersError : ApiError
{
    private readonly Optional<BalanceTransfers401Error1> _balanceTransfers401Error1Value;

    private readonly Optional<BalanceTransfers422Error1> _balanceTransfers422Error1Value;

    private PostBalanceTransfersError(Optional<BalanceTransfers401Error1> balanceTransfers401Error1Value,
        Optional<BalanceTransfers422Error1> balanceTransfers422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceTransfers401Error1Value = balanceTransfers401Error1Value;
        _balanceTransfers422Error1Value = balanceTransfers422Error1Value;
    }

    private static PostBalanceTransfersError AsBalanceTransfers401Error1(BalanceTransfers401Error1 value) =>
        new(Optional<BalanceTransfers401Error1>.Some(value), default, default);

    private static PostBalanceTransfersError AsBalanceTransfers422Error1(BalanceTransfers422Error1 value) =>
        new(default, Optional<BalanceTransfers422Error1>.Some(value), default);

    private static PostBalanceTransfersError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceTransfers401Error1(out BalanceTransfers401Error1 value) =>
        _balanceTransfers401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceTransfers422Error1(out BalanceTransfers422Error1 value) =>
        _balanceTransfers422Error1Value.TryGetValue(out value);

    internal static Task<PostBalanceTransfersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceTransfers401Error1>(response, ct).As(AsBalanceTransfers401Error1),
            422 => FromJson<BalanceTransfers422Error1>(response, ct).As(AsBalanceTransfers422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostBalanceTransfersErrorResponse : IErrorResponse<PostBalanceTransfersError>
{
    public static PostBalanceTransfersErrorResponse Instance { get; } = new();

    private PostBalanceTransfersErrorResponse()
    {
    }

    public Task<PostBalanceTransfersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostBalanceTransfersError.Create(response, ct);
}
