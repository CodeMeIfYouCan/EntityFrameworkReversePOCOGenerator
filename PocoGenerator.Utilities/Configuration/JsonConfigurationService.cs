using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PocoGenerator.Utilities.Configuration
{
    public class JsonConfigurationService : IJsonConfigurationService
    {
        public DbConnectionDetail GetDbConnection(string fullPath, string connectionCode)
        {
            string fileContent = GetFileContext(fullPath, connectionCode);
            DbConnectionInfo dbConnection = JsonConvert.DeserializeObject<DbConnectionInfo>(fileContent);
            if (dbConnection == null)
            {
                throw new Exception(string.Format("DbConnection is not found in json file:{0})", fullPath));
            }
            foreach (var item in dbConnection.DbConnectionDetails)
            {
                if(item.Code == connectionCode)
                {
                    return item;
                }
            }
            throw new Exception(string.Format("Connection Code :{0} is not found in json file:{1})", connectionCode, fullPath));
        }
        string GetFileContext(string fullPath, string connectionCode)
        {
            string result = string.Empty;
            using (StreamReader r = new StreamReader(fullPath))
            {
                result = r.ReadToEnd();
            }
            return result;
        }
    }
}
