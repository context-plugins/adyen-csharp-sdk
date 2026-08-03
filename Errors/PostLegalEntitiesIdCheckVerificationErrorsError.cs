using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostLegalEntitiesIdCheckVerificationErrorsError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostLegalEntitiesIdCheckVerificationErrorsError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostLegalEntitiesIdCheckVerificationErrorsError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostLegalEntitiesIdCheckVerificationErrorsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostLegalEntitiesIdCheckVerificationErrorsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostLegalEntitiesIdCheckVerificationErrorsErrorResponse : IErrorResponse<PostLegalEntitiesIdCheckVerificationErrorsError>
{
    public static PostLegalEntitiesIdCheckVerificationErrorsErrorResponse Instance { get; } = new();

    private PostLegalEntitiesIdCheckVerificationErrorsErrorResponse()
    {
    }

    public Task<PostLegalEntitiesIdCheckVerificationErrorsError> Map(HttpResponseMessage response,
        CancellationToken ct) => PostLegalEntitiesIdCheckVerificationErrorsError.Create(response, ct);
}
