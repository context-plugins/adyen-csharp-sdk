using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse : IErrorResponse<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError>
{
    public static GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.Create(response, ct);
}
