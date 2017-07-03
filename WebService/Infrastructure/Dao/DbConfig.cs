using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
namespace Infrastructure.Dao
{
    public class DbConfig
    {
        public static string _connectionString = ConfigSugar.GetConfigString("DefaultConnection");
        public static SqlSugarClient GetDbInstance()
        {
            try
            {
                var reval = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = _connectionString,
                    DbType = DbType.SqlServer,
                    IsAutoCloseConnection = true
                });
                return reval;
            }
            catch (Exception ex)
            {
                throw new Exception("连接数据库出错，请检查您的连接字符串，和网络。 ex:".AppendString(ex.Message));
            }
        }
    }
}