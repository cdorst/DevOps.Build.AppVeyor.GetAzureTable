using Microsoft.WindowsAzure.Storage.Table;
using System.Threading.Tasks;
using static Azure.Storage.Table.GetAzureTable.AzureTableGetter;

namespace DevOps.Build.AppVeyor.GetAzureTable
{
    /// <summary>Function returns an Azure CloudTable reference for a table named appveyor</summary>
    public static class AzureTableGetter
    {
        private const string appveyor = nameof(appveyor);

        /// <summary>Returns an Azure CloudTable reference for a table named "appveyor" in the storage account for the connection string stored in the environment</summary>
        public static async Task<CloudTable> GetTable() => await AzureTable(appveyor);
    }
}
