using Infrastructure.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebService.App_Start
{
    public class BaseController : ApiController
    {
        public DbService _service;

        public BaseController(string ConnectionString)
        {
            _service = new DbService(ConnectionString);
        }
    }
}