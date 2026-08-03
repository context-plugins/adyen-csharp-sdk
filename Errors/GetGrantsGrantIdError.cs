using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetGrantsGrantIdError : ApiError
{
    private readonly Optional<Grants404Error1> _grants404Error1Value;

    private readonly Optional<Grants422Error1> _grants422Error1Value;

    private GetGrantsGrantIdError(Optional<Grants404Error1> grants404Error1Value,
        Optional<Grants422Error1> grants422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _grants404Error1Value = grants404Error1Value;
        _grants422Error1Value = grants422Error1Value;
    }

    private static GetGrantsGrantIdError AsGrants404Error1(Grants404Error1 value) =>
        new(Optional<Grants404Error1>.Some(value), default, default);

    private static GetGrantsGrantIdError AsGrants422Error1(Grants422Error1 value) =>
        new(default, Optional<Grants422Error1>.Some(value), default);

    private static GetGrantsGrantIdError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGrants404Error1(out Grants404Error1 value) =>
        _grants404Error1Value.TryGetValue(out value);

    public bool TryGetGrants422Error1(out Grants422Error1 value) =>
        _grants422Error1Value.TryGetValue(out value);

    internal static Task<GetGrantsGrantIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Grants404Error1>(response, ct).As(AsGrants404Error1),
            422 => FromJson<Grants422Error1>(response, ct).As(AsGrants422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGrantsGrantIdErrorResponse : IErrorResponse<GetGrantsGrantIdError>
{
    public static GetGrantsGrantIdErrorResponse Instance { get; } = new();

    private GetGrantsGrantIdErrorResponse()
    {
    }

    public Task<GetGrantsGrantIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGrantsGrantIdError.Create(response, ct);
}
