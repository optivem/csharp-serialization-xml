using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace Optivem.Demo.DependencyInjection
{
    public static class ConfigurationKeys
    {
        public const string DatabaseConnectionKey = "DefaultConnection";

        public static Action<SqlServerDbContextOptionsBuilder> SqlServerOptionsAction = b => b.MigrationsAssembly("Optivem.Demo.Tools.Migrator");
    }
}