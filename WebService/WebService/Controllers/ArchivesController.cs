using Infrastructure.Dao;
using Infrastructure.DbModels;
using Newtonsoft.Json;
using SqlSugar;
using SyntacticSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.App_Start;

namespace WebService.Controllers
{
    public class ArchivesController : BaseController
    {
        public static string ConnectionString = ConfigSugar.GetConfigString("DefaultConnection");

        public ArchivesController() : base(ConnectionString) { }

        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            var getSome = new List<Archives>();
            //调用服务,传入参数：服务对象，数据库对象
            _service.Command<ArchivesOutsourcing>((db, o) =>
            {
                getSome = db.Queryable<Archives>().Where(it => it.ID == id).ToList();
            });


            return Json(getSome);
        }


    }
}
