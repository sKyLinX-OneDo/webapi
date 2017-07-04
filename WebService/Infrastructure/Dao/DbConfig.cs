using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
namespace Infrastructure.Dao
{
    public class DbConfig
    {
        public static string _connectionString = ConfigSugar.GetConnectionString("DefaultConnection");
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
                reval.Ado.IsEnableLogEvent = true;
                reval.Ado.LogEventStarting = (sql, pars) =>
                {

                };
                return reval;
            }
            catch (Exception ex)
            {
                throw new Exception("连接数据库出错，请检查您的连接字符串，和网络。 ex:".AppendString(ex.Message));
            }
        }
    }
}