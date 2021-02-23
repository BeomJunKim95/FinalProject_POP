using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;
using WebAPI.DAC;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Employees")]
    public class EmployeesController : ApiController
    {
        [Route("{Code}")]
        public IHttpActionResult GetEmpLogin(string Code)
        {
            ApiMessage<EmployeesVO> msg = new ApiMessage<EmployeesVO>();

            EmployeesDAC uDac = new EmployeesDAC();
            msg.Data = uDac.EmpLogin(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
