using System;
using System.Collections.Generic;
using System.Text;

namespace PocoGenerator.Utilities.Configuration
{
    public class DbConnectionDetail
    {
        public string Code { get; set; }
        public string ProviderName { get; set; }
        public string ConnectionString { get; set; }
    }
}
