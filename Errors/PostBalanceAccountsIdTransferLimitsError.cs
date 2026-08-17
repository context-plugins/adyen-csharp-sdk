using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostBalanceAccountsIdTransferLimitsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostBalanceAccountsIdTransferLimitsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostBalanceAccountsIdTransferLimitsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostBalanceAccountsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostBalanceAccountsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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
