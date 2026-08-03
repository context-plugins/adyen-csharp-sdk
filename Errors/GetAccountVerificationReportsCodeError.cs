using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetAccountVerificationReportsCodeError : ApiError
{
    private readonly Optional<AccountVerificationReports400Error1> _accountVerificationReports400Error1Value;

    private readonly Optional<AccountVerificationReports401Error1> _accountVerificationReports401Error1Value;

    private readonly Optional<AccountVerificationReports404Error1> _accountVerificationReports404Error1Value;

    private readonly Optional<AccountVerificationReports422Error1> _accountVerificationReports422Error1Value;

    private readonly Optional<AccountVerificationReports429Error1> _accountVerificationReports429Error1Value;

    private readonly Optional<AccountVerificationReports500Error1> _accountVerificationReports500Error1Value;

    private GetAccountVerificationReportsCodeError(Optional<AccountVerificationReports400Error1> accountVerificationReports400Error1Value,
        Optional<AccountVerificationReports401Error1> accountVerificationReports401Error1Value,
        Optional<AccountVerificationReports404Error1> accountVerificationReports404Error1Value,
        Optional<AccountVerificationReports422Error1> accountVerificationReports422Error1Value,
        Optional<AccountVerificationReports429Error1> accountVerificationReports429Error1Value,
        Optional<AccountVerificationReports500Error1> accountVerificationReports500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _accountVerificationReports400Error1Value = accountVerificationReports400Error1Value;
        _accountVerificationReports401Error1Value = accountVerificationReports401Error1Value;
        _accountVerificationReports404Error1Value = accountVerificationReports404Error1Value;
        _accountVerificationReports422Error1Value = accountVerificationReports422Error1Value;
        _accountVerificationReports429Error1Value = accountVerificationReports429Error1Value;
        _accountVerificationReports500Error1Value = accountVerificationReports500Error1Value;
    }

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports400Error1(AccountVerificationReports400Error1 value) =>
        new(Optional<AccountVerificationReports400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports401Error1(AccountVerificationReports401Error1 value) =>
        new(default,
            Optional<AccountVerificationReports401Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports404Error1(AccountVerificationReports404Error1 value) =>
        new(default,
            default,
            Optional<AccountVerificationReports404Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports422Error1(AccountVerificationReports422Error1 value) =>
        new(default,
            default,
            default,
            Optional<AccountVerificationReports422Error1>.Some(value),
            default,
            default,
            default);

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports429Error1(AccountVerificationReports429Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<AccountVerificationReports429Error1>.Some(value),
            default,
            default);

    private static GetAccountVerificationReportsCodeError AsAccountVerificationReports500Error1(AccountVerificationReports500Error1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<AccountVerificationReports500Error1>.Some(value),
            default);

    private static GetAccountVerificationReportsCodeError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetAccountVerificationReports400Error1(out AccountVerificationReports400Error1 value) =>
        _accountVerificationReports400Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationReports401Error1(out AccountVerificationReports401Error1 value) =>
        _accountVerificationReports401Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationReports404Error1(out AccountVerificationReports404Error1 value) =>
        _accountVerificationReports404Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationReports422Error1(out AccountVerificationReports422Error1 value) =>
        _accountVerificationReports422Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationReports429Error1(out AccountVerificationReports429Error1 value) =>
        _accountVerificationReports429Error1Value.TryGetValue(out value);

    public bool TryGetAccountVerificationReports500Error1(out AccountVerificationReports500Error1 value) =>
        _accountVerificationReports500Error1Value.TryGetValue(out value);

    internal static Task<GetAccountVerificationReportsCodeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<AccountVerificationReports400Error1>(response, ct).As(AsAccountVerificationReports400Error1),
            401 => FromJson<AccountVerificationReports401Error1>(response, ct).As(AsAccountVerificationReports401Error1),
            404 => FromJson<AccountVerificationReports404Error1>(response, ct).As(AsAccountVerificationReports404Error1),
            422 => FromJson<AccountVerificationReports422Error1>(response, ct).As(AsAccountVerificationReports422Error1),
            429 => FromJson<AccountVerificationReports429Error1>(response, ct).As(AsAccountVerificationReports429Error1),
            500 => FromJson<AccountVerificationReports500Error1>(response, ct).As(AsAccountVerificationReports500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAccountVerificationReportsCodeErrorResponse : IErrorResponse<GetAccountVerificationReportsCodeError>
{
    public static GetAccountVerificationReportsCodeErrorResponse Instance { get; } = new();

    private GetAccountVerificationReportsCodeErrorResponse()
    {
    }

    public Task<GetAccountVerificationReportsCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAccountVerificationReportsCodeError.Create(response, ct);
}
