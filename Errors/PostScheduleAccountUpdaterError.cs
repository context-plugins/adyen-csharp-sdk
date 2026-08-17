using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostScheduleAccountUpdaterError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostScheduleAccountUpdaterError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostScheduleAccountUpdaterError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostScheduleAccountUpdaterError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostScheduleAccountUpdaterError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostScheduleAccountUpdaterErrorResponse : IErrorResponse<PostScheduleAccountUpdaterError>
{
    public static PostScheduleAccountUpdaterErrorResponse Instance { get; } = new();

    private PostScheduleAccountUpdaterErrorResponse()
    {
    }

    public Task<PostScheduleAccountUpdaterError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostScheduleAccountUpdaterError.Create(response, ct);
}
