using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCloseAccountError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostCloseAccountError(Optional<ServiceError1> serviceError1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostCloseAccountError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostCloseAccountError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    private static Task<PostCloseAccountError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<ServiceError1>().As(AsServiceError1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostCloseAccountError> Response { get; } = new(Create);
}
