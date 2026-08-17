using Adyen.Core.Models;

namespace Adyen.Servers;

public class Default1Options
{
    public TestOptions Test { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Test.BaseUrl, path, []));

    public class TestOptions
    {
        public string BaseUrl { get; set; } = "https://pal-test.adyen.com/pal/servlet/Payment/v68";
    }
}
