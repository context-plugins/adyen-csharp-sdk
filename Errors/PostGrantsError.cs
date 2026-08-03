using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostGrantsError : ApiError
{
    private readonly Optional<Grants422Error1> _grants422Error1Value;

    private PostGrantsError(Optional<Grants422Error1> grants422Error1Value, Optional<RawError> fallback) : base(fallback)
    {
        _grants422Error1Value = grants422Error1Value;
    }

    private static PostGrantsError AsGrants422Error1(Grants422Error1 value) =>
        new(Optional<Grants422Error1>.Some(value), default);

    private static PostGrantsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetGrants422Error1(out Grants422Error1 value) =>
        _grants422Error1Value.TryGetValue(out value);

    internal static Task<PostGrantsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromJson<Grants422Error1>(response, ct).As(AsGrants422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostGrantsErrorResponse : IErrorResponse<PostGrantsError>
{
    public static PostGrantsErrorResponse Instance { get; } = new();

    private PostGrantsErrorResponse()
    {
    }

    public Task<PostGrantsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostGrantsError.Create(response, ct);
}
