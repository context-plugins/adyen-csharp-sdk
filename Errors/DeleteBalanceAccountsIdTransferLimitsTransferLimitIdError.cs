using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteBalanceAccountsIdTransferLimitsTransferLimitIdErrorResponse : IErrorResponse<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError>
{
    public static DeleteBalanceAccountsIdTransferLimitsTransferLimitIdErrorResponse Instance { get; } = new();

    private DeleteBalanceAccountsIdTransferLimitsTransferLimitIdErrorResponse()
    {
    }

    public Task<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError.Create(response, ct);
}
