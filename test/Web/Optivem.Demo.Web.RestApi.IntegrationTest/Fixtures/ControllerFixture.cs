using Optivem.Framework.Test.AspNetCore;
using Optivem.Framework.Test.EntityFrameworkCore;
using Optivem.Demo.DependencyInjection;
using Optivem.Demo.Infrastructure.Persistence;
using Optivem.Demo.Web.RestClient;
using Optivem.Demo.Web.RestClient.Interface;

namespace Optivem.Demo.Web.RestApi.IntegrationTest.Fixtures
{
    public class ControllerFixture
    {
        public ControllerFixture()
        {
            Web = WebTestClientFactory.Create<Startup>();
            Db = DbTestClientFactory.Create<DatabaseContext>(ConfigurationKeys.DatabaseConnectionKey, e => new DatabaseContext(e), ConfigurationKeys.SqlServerOptionsAction);

            Api = new ApiHttpService(Web.ControllerClientFactory);
        }

        public WebTestClient Web { get; }

        public DbTestClient<DatabaseContext> Db { get; }

        public IApiHttpService Api { get; }
    }
}