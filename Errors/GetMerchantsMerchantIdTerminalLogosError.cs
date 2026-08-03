using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdTerminalLogosError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdTerminalLogosError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdTerminalLogosError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdTerminalLogosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdTerminalLogosError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdTerminalLogosErrorResponse : IErrorResponse<GetMerchantsMerchantIdTerminalLogosError>
{
    public static GetMerchantsMerchantIdTerminalLogosErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdTerminalLogosErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdTerminalLogosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetMerchantsMerchantIdTerminalLogosError.Create(response, ct);
}
