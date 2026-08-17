using Adyen.Core.Models;

namespace Adyen.Servers;

public class Default16Options
{
    public TestOptions Test { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Test.BaseUrl, path, []));

    public class TestOptions
    {
        public string BaseUrl { get; set; } = "https://cal-test.adyen.com/cal/services/Fund/v6";
    }
}
