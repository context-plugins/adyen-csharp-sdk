using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostIdealProfileAuthenticateError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostIdealProfileAuthenticateError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostIdealProfileAuthenticateError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostIdealProfileAuthenticateError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostIdealProfileAuthenticateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostIdealProfileAuthenticateErrorResponse : IErrorResponse<PostIdealProfileAuthenticateError>
{
    public static PostIdealProfileAuthenticateErrorResponse Instance { get; } = new();

    private PostIdealProfileAuthenticateErrorResponse()
    {
    }

    public Task<PostIdealProfileAuthenticateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostIdealProfileAuthenticateError.Create(response, ct);
}
