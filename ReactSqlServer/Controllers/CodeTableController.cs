using ReactSqlServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReactSqlServer.Controllers
{
    [RoutePrefix("Api/CodeTable")]
    public class CodeTableController : ApiController
    {
        ReactDBEntities1 objEntity = new ReactDBEntities1();

        [HttpGet]
        [Route("GetCodeTables")]
        public IQueryable<CodeTable> GetCodeTables()
        {
            try
            {
                return objEntity.CodeTable;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}