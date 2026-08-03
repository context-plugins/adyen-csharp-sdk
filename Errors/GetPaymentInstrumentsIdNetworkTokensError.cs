using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetPaymentInstrumentsIdNetworkTokensError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetPaymentInstrumentsIdNetworkTokensError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetPaymentInstrumentsIdNetworkTokensError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetPaymentInstrumentsIdNetworkTokensError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetPaymentInstrumentsIdNetworkTokensError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentInstrumentsIdNetworkTokensErrorResponse : IErrorResponse<GetPaymentInstrumentsIdNetworkTokensError>
{
    public static GetPaymentInstrumentsIdNetworkTokensErrorResponse Instance { get; } = new();

    private GetPaymentInstrumentsIdNetworkTokensErrorResponse()
    {
    }

    public Task<GetPaymentInstrumentsIdNetworkTokensError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPaymentInstrumentsIdNetworkTokensError.Create(response, ct);
}
