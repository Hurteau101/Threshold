using System.Configuration;

namespace Perimeter_Threshold
{
    class ConnectionLoader
    {
        /// <summary>
        /// Load the SQL Connection
        /// </summary>
        /// <param name="connectionName"></param>
        /// <returns></returns>
        public static string ConnectionString(string connectionName)
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
    }
}
