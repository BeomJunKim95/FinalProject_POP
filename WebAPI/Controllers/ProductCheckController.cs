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
    [RoutePrefix("api/ProductCheck")]
    public class ProductCheckController : ApiController
    {
        [Route("Prod/{Code}")]
        public IHttpActionResult GETProductCheckFromProduct(string Code)
        {
            ApiMessage<List<ProductCheckVO>> msg = new ApiMessage<List<ProductCheckVO>>();

            ProductCheckDAC uDac = new ProductCheckDAC();
            msg.Data = uDac.ProductCheckFromProduct(Code);
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }

        [Route("Count/{Count}")]
        public IHttpActionResult GetSP_InsetProductWH(int Count)
        {
            ApiMessage<bool> msg = new ApiMessage<bool>();

            ViewDAC uDac = new ViewDAC();
            msg.Data = uDac.SP_InsetProductWH(Count);
            msg.ResultCode = (msg.Data == false) ? "F" : "S";
            msg.ResultMessage = (msg.Data == false) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
    }
}
