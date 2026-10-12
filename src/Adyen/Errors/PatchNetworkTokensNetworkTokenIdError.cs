using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchNetworkTokensNetworkTokenIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchNetworkTokensNetworkTokenIdError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchNetworkTokensNetworkTokenIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchNetworkTokensNetworkTokenIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) => _restServiceErrorValue.TryGetValue(out value);

    private static Task<PatchNetworkTokensNetworkTokenIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            401 or 403 or 422 or 500 => response.Json<RestServiceError>().As(AsRestServiceError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PatchNetworkTokensNetworkTokenIdError> Response { get; } = new(Create);
}
