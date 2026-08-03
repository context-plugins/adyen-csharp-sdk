using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesErrorResponse : IErrorResponse<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError>
{
    public static PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesErrorResponse Instance { get; } = new();

    private PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesErrorResponse()
    {
    }

    public Task<PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError.Create(response, ct);
}
