﻿using Optivem.Framework.Core.Application;
using Optivem.Framework.Core.Domain;
using Optivem.Framework.Infrastructure.EntityFrameworkCore;

namespace Optivem.Demo.Infrastructure.Persistence
{
    public class UnitOfWork : UnitOfWork<DatabaseContext>, IUnitOfWork
    {
        public UnitOfWork(DatabaseContext context, IRequestHandler requestHandler, bool disposeContext = false)
            : base(context, disposeContext)
        {
        }
    }
}