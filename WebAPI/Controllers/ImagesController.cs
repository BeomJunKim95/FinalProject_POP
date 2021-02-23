using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.UI;
using VO;
using WebAPI.Liberary;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Images")]
    public class ImagesController : ApiController
    {
        [Route("Download/{file}/{ex}")]
        public IHttpActionResult GetIamge(string file,string ex)
        {
            //string pasth = HttpContext.Current.Server.MapPath("~/Images/" + file + "." + ex);
            string ImagePase =  Url.Content("/Images/" +file + "." + ex);
            ApiMessage<string> msg = new ApiMessage<string>();
            msg.Data = ImagePase;
            msg.ResultCode = (msg.Data == null) ? "F" : "S";
            msg.ResultMessage = (msg.Data == null) ? "해당하는 정보가 없습니다." : "OK";

            return Ok(msg);
        }
        [HttpPost]
        [Route("Upload")]
        public IHttpActionResult PostUpload(Imagedata data)
        {
            ApiMessage msg = new ApiMessage();
            Image image = CommonUtil.ByteToImage(data.image);
            string pasth = HttpContext.Current.Server.MapPath("~/Images");
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(pasth);
            if (!di.Exists) { di.Create(); }
            System.IO.File.Delete(di.FullName + "/" + data.filename);

            image.Save(di.FullName+ "/" + data.filename);
            msg.ResultCode = "S";
            msg.ResultMessage = "이미지 추가";

            return Ok(msg);
        }
    }

}
