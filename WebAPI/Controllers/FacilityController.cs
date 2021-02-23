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
    [RoutePrefix("api/Facility")]
    public class FacilityController : ApiController
    {
        [Route("{Code}")]
        public IHttpActionResult GetEmpLogin(string Code)
        {
            ApiMessage<FacilityVO> msg = new ApiMessage<FacilityVO>();

            FacilityDAC uDac = new FacilityDAC();
            msg.Data = uDac.SelectFacility(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
