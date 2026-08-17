using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsConfirmError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostPaymentsConfirmError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostPaymentsConfirmError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostPaymentsConfirmError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostPaymentsConfirmError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsConfirmErrorResponse : IErrorResponse<PostPaymentsConfirmError>
{
    public static PostPaymentsConfirmErrorResponse Instance { get; } = new();

    private PostPaymentsConfirmErrorResponse()
    {
    }

    public Task<PostPaymentsConfirmError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsConfirmError.Create(response, ct);
}
