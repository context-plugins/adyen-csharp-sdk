using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostIdealProfileAuthLinkError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostIdealProfileAuthLinkError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostIdealProfileAuthLinkError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostIdealProfileAuthLinkError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostIdealProfileAuthLinkError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostIdealProfileAuthLinkErrorResponse : IErrorResponse<PostIdealProfileAuthLinkError>
{
    public static PostIdealProfileAuthLinkErrorResponse Instance { get; } = new();

    private PostIdealProfileAuthLinkErrorResponse()
    {
    }

    public Task<PostIdealProfileAuthLinkError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostIdealProfileAuthLinkError.Create(response, ct);
}
