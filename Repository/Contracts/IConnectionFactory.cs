using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repository.Repositories
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
