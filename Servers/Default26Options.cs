using Adyen.Core.Models;

namespace Adyen.Servers;

public class Default26Options
{
    public TestOptions Test { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Test.BaseUrl, path, []));

    public class TestOptions
    {
        public string BaseUrl { get; set; } = "https://management-test.adyen.com/v1";
    }
}
