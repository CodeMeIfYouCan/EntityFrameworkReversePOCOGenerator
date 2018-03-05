using System;
using System.Collections.Generic;
using System.Text;

namespace PocoGenerator.Utilities.Configuration
{
    public interface IJsonConfigurationService
    {
        DbConnectionDetail GetDbConnection(string fullPath, string connectionCode);
    }
}
