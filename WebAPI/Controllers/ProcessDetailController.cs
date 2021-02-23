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
    [RoutePrefix("api/ProcessDetail")]
    public class ProcessDetailController : ApiController
    {
        [Route("Prod/{Code}")]
        public IHttpActionResult GetView_ProcessForProductList(string Code)
        {
            ApiMessage<List<View_ProcessForProductVO>> msg = new ApiMessage<List<View_ProcessForProductVO>>();

            ProcessDetailDAC uDac = new ProcessDetailDAC();
            msg.Data = uDac.ProcessForProduct(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
