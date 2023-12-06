using NUnit.Framework;

using static VSATemplate.Application.IntegrationTests.Testing;

namespace VSATemplate.Application.IntegrationTests;
public class TestBase
{
    [SetUp]
    public async Task TestSetUp()
    {
        await ResetState();
    }
}
