using Adyen.Core.Models;

namespace Adyen.Servers;

public class Default23Options
{
    public TestOptions Test { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Test.BaseUrl, path, []));

    public class TestOptions
    {
        public string BaseUrl { get; set; } = "https://balanceplatform-api-test.adyen.com/btl/api/v4";
    }
}
