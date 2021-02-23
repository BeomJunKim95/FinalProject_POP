using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;
using WebAPI.DAC;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Route("GetOrders")]
        public IHttpActionResult GetView_Orders_CodeVO()
        {
            ApiMessage<List<View_ContractVO>> msg = new ApiMessage<List<View_ContractVO>>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.GetView_Orders_CodeVO();
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("GetOrderDetail/{ordercode}")]
        public IHttpActionResult GetView_OrdersDetail_CodeVO(string ordercode)
        {
            ApiMessage<List<View_ContractDetailVO>> msg = new ApiMessage<List<View_ContractDetailVO>>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.GetView_OrdersDetail_CodeVO(ordercode);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("GetOrder/Code/{code}")]
        public IHttpActionResult GetCodeView_Orders_CodeVO(string code)
        {
            ApiMessage<List<View_ContractVO>> msg = new ApiMessage<List<View_ContractVO>>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.GetCodeView_Orders_CodeVO(code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("OutToProduct/{Count}/{ProductCode}/{WH_Code}/{uid}/{Contract_Code}")]
        public IHttpActionResult GetSP_OutToProduct(int Count, string ProductCode,string WH_Code,string uid ,string Contract_Code)
        {
            ApiMessage <bool> msg = new ApiMessage<bool>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.SP_OutToProduct(Convert.ToDecimal(Count), ProductCode, WH_Code, uid, Contract_Code);
            msg.ResultCode = (msg.Data == false) ? "F" : "S";
            msg.ResultMessage = (msg.Data == false) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
