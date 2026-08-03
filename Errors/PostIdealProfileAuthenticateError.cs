using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostIdealProfileAuthenticateError : ApiError
{
    private readonly Optional<IdealProfileAuthenticate400Error1> _idealProfileAuthenticate400Error1Value;

    private readonly Optional<IdealProfileAuthenticate422Error1> _idealProfileAuthenticate422Error1Value;

    private readonly Optional<IdealProfileAuthenticate500Error1> _idealProfileAuthenticate500Error1Value;

    private PostIdealProfileAuthenticateError(Optional<IdealProfileAuthenticate400Error1> idealProfileAuthenticate400Error1Value,
        Optional<IdealProfileAuthenticate422Error1> idealProfileAuthenticate422Error1Value,
        Optional<IdealProfileAuthenticate500Error1> idealProfileAuthenticate500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _idealProfileAuthenticate400Error1Value = idealProfileAuthenticate400Error1Value;
        _idealProfileAuthenticate422Error1Value = idealProfileAuthenticate422Error1Value;
        _idealProfileAuthenticate500Error1Value = idealProfileAuthenticate500Error1Value;
    }

    private static PostIdealProfileAuthenticateError AsIdealProfileAuthenticate400Error1(IdealProfileAuthenticate400Error1 value) =>
        new(Optional<IdealProfileAuthenticate400Error1>.Some(value), default, default, default);

    private static PostIdealProfileAuthenticateError AsIdealProfileAuthenticate422Error1(IdealProfileAuthenticate422Error1 value) =>
        new(default, Optional<IdealProfileAuthenticate422Error1>.Some(value), default, default);

    private static PostIdealProfileAuthenticateError AsIdealProfileAuthenticate500Error1(IdealProfileAuthenticate500Error1 value) =>
        new(default, default, Optional<IdealProfileAuthenticate500Error1>.Some(value), default);

    private static PostIdealProfileAuthenticateError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetIdealProfileAuthenticate400Error1(out IdealProfileAuthenticate400Error1 value) =>
        _idealProfileAuthenticate400Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileAuthenticate422Error1(out IdealProfileAuthenticate422Error1 value) =>
        _idealProfileAuthenticate422Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileAuthenticate500Error1(out IdealProfileAuthenticate500Error1 value) =>
        _idealProfileAuthenticate500Error1Value.TryGetValue(out value);

    internal static Task<PostIdealProfileAuthenticateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<IdealProfileAuthenticate400Error1>(response, ct).As(AsIdealProfileAuthenticate400Error1),
            422 => FromJson<IdealProfileAuthenticate422Error1>(response, ct).As(AsIdealProfileAuthenticate422Error1),
            500 => FromJson<IdealProfileAuthenticate500Error1>(response, ct).As(AsIdealProfileAuthenticate500Error1),
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
