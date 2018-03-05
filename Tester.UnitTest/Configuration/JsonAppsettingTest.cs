using Newtonsoft.Json;
using NUnit.Framework;
using PocoGenerator.Utilities.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tester.UnitTest.Core.Configuration
{
    class JsonAppsettingTest
    {

        [TestCase(@"C:\TfsOnline\PocoGenerator\EFPocoGenerator\EF.Reverse.POCO.Generator\EF.Reverse.POCO.Generator\pocodbconfiguration.json", "MyDbContext")]
        public void TestConnectionString(string path, string connectionStringCode)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            JsonConfigurationService jsonConfiguration = new JsonConfigurationService();
            var result = jsonConfiguration.GetDbConnection(path, connectionStringCode);
            Assert.AreEqual(result.Code, connectionStringCode);
        }

    }
}
