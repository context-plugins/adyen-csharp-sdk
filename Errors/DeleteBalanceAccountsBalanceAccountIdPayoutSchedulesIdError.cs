using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse : IErrorResponse<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError>
{
    public static DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse Instance { get; } = new();

    private DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse()
    {
    }

    public Task<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.Create(response, ct);
}
