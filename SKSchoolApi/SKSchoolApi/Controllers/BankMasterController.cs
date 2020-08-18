using SKSchoolApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SKSchoolApi.Controllers
{
    public class BankMasterController : ApiController
    {
        Database.DB record = new Database.DB();
        public DataSet Get(string command, string intSchool_id)
        {
            BankMaster bankMaster = new BankMaster();
            bankMaster.intSchool_id = Convert.ToInt32(intSchool_id);
            DataSet ds = record.BankMaster(command, bankMaster);
            return ds;
        }
     }
}
