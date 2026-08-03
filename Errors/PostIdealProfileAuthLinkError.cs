using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostIdealProfileAuthLinkError : ApiError
{
    private readonly Optional<IdealProfileAuthLink400Error1> _idealProfileAuthLink400Error1Value;

    private readonly Optional<IdealProfileAuthLink422Error1> _idealProfileAuthLink422Error1Value;

    private readonly Optional<IdealProfileAuthLink500Error1> _idealProfileAuthLink500Error1Value;

    private PostIdealProfileAuthLinkError(Optional<IdealProfileAuthLink400Error1> idealProfileAuthLink400Error1Value,
        Optional<IdealProfileAuthLink422Error1> idealProfileAuthLink422Error1Value,
        Optional<IdealProfileAuthLink500Error1> idealProfileAuthLink500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _idealProfileAuthLink400Error1Value = idealProfileAuthLink400Error1Value;
        _idealProfileAuthLink422Error1Value = idealProfileAuthLink422Error1Value;
        _idealProfileAuthLink500Error1Value = idealProfileAuthLink500Error1Value;
    }

    private static PostIdealProfileAuthLinkError AsIdealProfileAuthLink400Error1(IdealProfileAuthLink400Error1 value) =>
        new(Optional<IdealProfileAuthLink400Error1>.Some(value), default, default, default);

    private static PostIdealProfileAuthLinkError AsIdealProfileAuthLink422Error1(IdealProfileAuthLink422Error1 value) =>
        new(default, Optional<IdealProfileAuthLink422Error1>.Some(value), default, default);

    private static PostIdealProfileAuthLinkError AsIdealProfileAuthLink500Error1(IdealProfileAuthLink500Error1 value) =>
        new(default, default, Optional<IdealProfileAuthLink500Error1>.Some(value), default);

    private static PostIdealProfileAuthLinkError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetIdealProfileAuthLink400Error1(out IdealProfileAuthLink400Error1 value) =>
        _idealProfileAuthLink400Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileAuthLink422Error1(out IdealProfileAuthLink422Error1 value) =>
        _idealProfileAuthLink422Error1Value.TryGetValue(out value);

    public bool TryGetIdealProfileAuthLink500Error1(out IdealProfileAuthLink500Error1 value) =>
        _idealProfileAuthLink500Error1Value.TryGetValue(out value);

    internal static Task<PostIdealProfileAuthLinkError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<IdealProfileAuthLink400Error1>(response, ct).As(AsIdealProfileAuthLink400Error1),
            422 => FromJson<IdealProfileAuthLink422Error1>(response, ct).As(AsIdealProfileAuthLink422Error1),
            500 => FromJson<IdealProfileAuthLink500Error1>(response, ct).As(AsIdealProfileAuthLink500Error1),
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
