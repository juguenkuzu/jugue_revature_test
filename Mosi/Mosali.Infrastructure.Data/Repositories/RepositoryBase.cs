using Mosali.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mosali.Infrastructure.Data.Repositories
{
    public class RepositoryBase : IDisposable
    {
        protected MosaliContext _dbContext;
        public RepositoryBase()
        {
            _dbContext = new MosaliContext();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
