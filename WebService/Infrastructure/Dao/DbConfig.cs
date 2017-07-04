using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
namespace Infrastructure.Dao
{
    public class DbConfig
    {
        public static SqlSugarClient GetDbInstance(string Connectionstring)
        {
            try
            {
                var reval = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = Connectionstring,
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