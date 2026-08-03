using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchTransactionRulesTransactionRuleIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchTransactionRulesTransactionRuleIdError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchTransactionRulesTransactionRuleIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchTransactionRulesTransactionRuleIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PatchTransactionRulesTransactionRuleIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchTransactionRulesTransactionRuleIdErrorResponse : IErrorResponse<PatchTransactionRulesTransactionRuleIdError>
{
    public static PatchTransactionRulesTransactionRuleIdErrorResponse Instance { get; } = new();

    private PatchTransactionRulesTransactionRuleIdErrorResponse()
    {
    }

    public Task<PatchTransactionRulesTransactionRuleIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchTransactionRulesTransactionRuleIdError.Create(response, ct);
}
