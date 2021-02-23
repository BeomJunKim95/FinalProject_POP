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
    [RoutePrefix("api/WorkOrder")]
    public class WorkOrderController : ApiController
    {
        [Route("Teams/{Code}")]
        public IHttpActionResult GetTeamFormEmp(string Code)
        {
            ApiMessage<List<SP_WorkOrderSherchTeamVO>> msg = new ApiMessage<List<SP_WorkOrderSherchTeamVO>>();

            WorkOrderDAC uDac = new WorkOrderDAC();
            msg.Data = uDac.SP_WorkOrderSherchTeam(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("Start/{Code}/{Writer}")]
        public IHttpActionResult GetStartWorkFromCode(string Code,string Writer)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            WorkOrderDAC uDac = new WorkOrderDAC();
            msg.Data = uDac.StartWorkFromCode(Code);
            if (msg.Data)
            {
                WorkRecordDAC Dac = new WorkRecordDAC();
                msg.Data = Dac.SP_StartWorkRecord(Code, Writer);
                msg.ResultCode = (msg.Data == false) ? "F" : "S";
                msg.ResultMessage = (msg.Data == false) ? "해당하는 정보가 없습니다." : "OK";
            }
            else
            {
                msg.ResultCode = "F";
                msg.ResultMessage = "해당하는 정보가 없습니다.";
            }

            return Ok(msg);
        }

        [Route("Stop/{Code}")]
        public IHttpActionResult GetStopWorkFromCode(string Code)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            WorkOrderDAC uDac = new WorkOrderDAC();
            msg.Data = uDac.StopWorkFromCode(Code);
            msg.ResultCode = (!msg.Data) ? "F" : "S";
            msg.ResultMessage = (!msg.Data) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("End/{Code}")]
        public IHttpActionResult GetEndWorkFromCode(string Code)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            WorkOrderDAC uDac = new WorkOrderDAC();
            msg.Data = uDac.EndWorkFromCode(Code);
            msg.ResultCode = (!msg.Data) ? "F" : "S";
            msg.ResultMessage = (!msg.Data) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
