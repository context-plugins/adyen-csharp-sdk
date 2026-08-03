using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetLegalEntitiesIdError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private GetLegalEntitiesIdError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static GetLegalEntitiesIdError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static GetLegalEntitiesIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<GetLegalEntitiesIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLegalEntitiesIdErrorResponse : IErrorResponse<GetLegalEntitiesIdError>
{
    public static GetLegalEntitiesIdErrorResponse Instance { get; } = new();

    private GetLegalEntitiesIdErrorResponse()
    {
    }

    public Task<GetLegalEntitiesIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLegalEntitiesIdError.Create(response, ct);
}
