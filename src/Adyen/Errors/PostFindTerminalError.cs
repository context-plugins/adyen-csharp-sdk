using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostFindTerminalError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostFindTerminalError(Optional<ServiceError1> serviceError1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostFindTerminalError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostFindTerminalError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    private static Task<PostFindTerminalError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<ServiceError1>().As(AsServiceError1),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostFindTerminalError> Response { get; } = new(Create);
}
