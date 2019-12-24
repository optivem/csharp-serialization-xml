using Microsoft.Extensions.DependencyInjection;
using Optivem.Framework.Test.EntityFrameworkCore;
using Optivem.Framework.Test.MicrosoftExtensions.Configuration;
using Optivem.Demo.Core.Application.Customers;
using Optivem.Demo.Core.Application.Orders;
using Optivem.Demo.Core.Application.Products;
using Optivem.Demo.DependencyInjection;
using Optivem.Demo.Infrastructure.Persistence;
using System;

namespace Optivem.Demo.Core.Application.IntegrationTest.Fixtures
{
    public class ServiceFixture : IDisposable
    {
        public ServiceFixture()
        {
            var configuration = ConfigurationRootFactory.Create();
            var services = new ServiceCollection();
            services.AddModules(configuration);

            Db = DbTestClientFactory.Create<DatabaseContext>(ConfigurationKeys.DatabaseConnectionKey, e => new DatabaseContext(e), ConfigurationKeys.SqlServerOptionsAction);

            ServiceProvider = services.BuildServiceProvider();

            Customers = GetService<ICustomerService>();
            Orders = GetService<IOrderService>();
            Products = GetService<IProductService>();
        }

        public DbTestClient<DatabaseContext> Db { get; }

        protected ServiceProvider ServiceProvider { get; }

        protected TService GetService<TService>()
        {
            return ServiceProvider.GetService<TService>();
        }

        public ICustomerService Customers { get; }

        public IOrderService Orders { get; }

        public IProductService Products { get; }

        public void Dispose()
        {
            ServiceProvider.Dispose();
        }
    }
}