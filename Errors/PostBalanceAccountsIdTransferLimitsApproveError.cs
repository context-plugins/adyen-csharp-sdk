using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsIdTransferLimitsApproveError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostBalanceAccountsIdTransferLimitsApproveError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostBalanceAccountsIdTransferLimitsApproveError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostBalanceAccountsIdTransferLimitsApproveError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostBalanceAccountsIdTransferLimitsApproveError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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
