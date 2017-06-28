using Newtonsoft.Json;
using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class ArchivesController : ApiController
    {

        public string Get()
        {
            return "test";
        }

        [HttpGet]
        public string Get(string id)
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigSugar.GetConnectionString("LocalSqlServer"),
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });

            var getSome = db.Queryable<Archives>().Where(it => it.ID == id).ToList();

            return JsonConvert.SerializeObject(getSome);

        }


    }
}
