using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError(Optional<ServiceError1> serviceError1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLegalEntitiesIdTermsOfServiceAcceptanceInfosErrorResponse : IErrorResponse<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError>
{
    public static GetLegalEntitiesIdTermsOfServiceAcceptanceInfosErrorResponse Instance { get; } = new();

    private GetLegalEntitiesIdTermsOfServiceAcceptanceInfosErrorResponse()
    {
    }

    public Task<GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError.Create(response, ct);
}
