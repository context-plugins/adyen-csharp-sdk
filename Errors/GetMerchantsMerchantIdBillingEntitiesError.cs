using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdBillingEntitiesError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdBillingEntitiesError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdBillingEntitiesError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdBillingEntitiesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdBillingEntitiesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdBillingEntitiesErrorResponse : IErrorResponse<GetMerchantsMerchantIdBillingEntitiesError>
{
    public static GetMerchantsMerchantIdBillingEntitiesErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdBillingEntitiesErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdBillingEntitiesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetMerchantsMerchantIdBillingEntitiesError.Create(response, ct);
}
