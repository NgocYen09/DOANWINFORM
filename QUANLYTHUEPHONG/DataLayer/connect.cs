using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class connect
    {
        public string getConnect()
        {
            SqlConnectionStringBuilder sqlConnectBuiler = new SqlConnectionStringBuilder();
            sqlConnectBuiler.DataSource = @"DESKTOP-MLT7I76\SQLEXPRESS";
            sqlConnectBuiler.InitialCatalog = "HOTELS";
            sqlConnectBuiler.PersistSecurityInfo = true;
            sqlConnectBuiler.UserID = "sa";
            sqlConnectBuiler.Password = "2802";
            sqlConnectBuiler.MultipleActiveResultSets = true;
            sqlConnectBuiler.ApplicationName = "EntityFramework";
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectBuiler.ConnectionString;
            entityBuilder.Metadata = @"res://*/KHACHSAN.csdl|res://*/KHACHSAN.ssdl|res://*/KHACHSAN.msl";

            return entityBuilder.ConnectionString;
        }
    }
}
