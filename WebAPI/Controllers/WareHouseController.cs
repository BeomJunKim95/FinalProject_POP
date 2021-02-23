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
    [RoutePrefix("api/WareHouse")]
    public class WareHouseController : ApiController
    {
        [Route("WH/{Code}")]
        public IHttpActionResult GetSelectWareHouse(string Code)
        {
            ApiMessage<ViewWareHouseVO> msg = new ApiMessage<ViewWareHouseVO>();

            WareHouseDAC uDac = new WareHouseDAC();
            msg.Data = uDac.SelectWareHouse(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("detail/{Code}")]
        public IHttpActionResult GetViewWareHouseDetail(string Code)
        {
            ApiMessage<List<View_WareHouseDetailVO>> msg = new ApiMessage<List<View_WareHouseDetailVO>>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.GetView_WareHouseDetail(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
