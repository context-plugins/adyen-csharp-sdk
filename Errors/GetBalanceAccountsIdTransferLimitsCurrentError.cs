using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsIdTransferLimitsCurrentError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceAccountsIdTransferLimitsCurrentError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceAccountsIdTransferLimitsCurrentError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceAccountsIdTransferLimitsCurrentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceAccountsIdTransferLimitsCurrentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsIdTransferLimitsCurrentErrorResponse : IErrorResponse<GetBalanceAccountsIdTransferLimitsCurrentError>
{
    public static GetBalanceAccountsIdTransferLimitsCurrentErrorResponse Instance { get; } = new();

    private GetBalanceAccountsIdTransferLimitsCurrentErrorResponse()
    {
    }

    public Task<GetBalanceAccountsIdTransferLimitsCurrentError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBalanceAccountsIdTransferLimitsCurrentError.Create(response, ct);
}
