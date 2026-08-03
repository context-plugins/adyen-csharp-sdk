using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentErrorResponse : IErrorResponse<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError>
{
    public static PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentErrorResponse Instance { get; } = new();

    private PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentErrorResponse()
    {
    }

    public Task<PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostLegalEntitiesIdCheckTaxElectronicDeliveryConsentError.Create(response, ct);
}
