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
    [RoutePrefix("api/WorkRecord")]
    public class WorkRecordController : ApiController
    {
        [Route("StartWork/{Code}/{wirter}")]
        public IHttpActionResult GetSP_StartWorkRecord(string Code,string wirter)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            WorkRecordDAC uDac = new WorkRecordDAC();
            msg.Data = uDac.SP_StartWorkRecord(Code, wirter);
            msg.ResultCode = (msg.Data == false) ? "F" : "S";
            msg.ResultMessage = (msg.Data == false) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("WorkQuantity/{Code}/{BadQuantity}/{GoodsQuantity}/{writer}")]
        public IHttpActionResult GetWorkQuantityInput(string Code,int BadQuantity,int GoodsQuantity, string writer)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            WorkRecordDAC uDac = new WorkRecordDAC();
            msg.Data = uDac.WorkQuantityInput(Code, BadQuantity, GoodsQuantity, writer);
            msg.ResultCode = (msg.Data == false) ? "F" : "S";
            msg.ResultMessage = (msg.Data == false) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

    }
}
