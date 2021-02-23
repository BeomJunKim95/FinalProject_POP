using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Liberary
{
    public class CommonUtil
    {

        #region 이미지타입을 바이트타입으로 변환하는 메서드
        /// <summary>
        /// 이미지를 바이트타입으로 형변환해줌
        /// </summary>
        /// <param name="img">이미지타입</param>
        /// <returns>이미지값</returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter(); // 이미지를 바이트로 형변환 하기위해 converter 생성
            return (byte[])converter.ConvertTo(img, typeof(byte[])); // 이미지를 바이트타입으로 형변환
        }
        #endregion

        #region 바이트타입을 이미지타입으로 형변환해주는 메서드
        /// <summary>
        /// 바이트타입의 이미지를 이미지타입으로 형변환해줌
        /// </summary>
        /// <param name="data">바이트타입</param>
        /// <returns>이미지값</returns>
        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap)); // 형변환을 하기위한 tc 생성
            return (Bitmap)(tc.ConvertFrom(data)); // 바이트타입 데이터를 이미지타입으로 형변환
        }
        #endregion
    }
}

