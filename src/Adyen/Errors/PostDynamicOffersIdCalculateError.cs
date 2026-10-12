using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostDynamicOffersIdCalculateError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostDynamicOffersIdCalculateError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostDynamicOffersIdCalculateError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostDynamicOffersIdCalculateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    private static Task<PostDynamicOffersIdCalculateError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            422 => response.Json<DefaultErrorResponseEntity>().As(AsDefaultErrorResponseEntity),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostDynamicOffersIdCalculateError> Response { get; } = new(Create);
}
