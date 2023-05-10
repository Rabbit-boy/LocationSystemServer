using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace LocationSystemServer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("AllowAllOrigins")]
    public class WorkController : ControllerBase
    {
        [HttpPost]
        //获取区域名称列表数据
        public IActionResult GetWorkshopList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "workshoplist.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }


        [HttpPost]
        //获取区域名称列表数据
        public IActionResult WarnVoiceList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "warnvoicelist.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetWarnWorkShopcy()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "warnworkshopcy.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult Emplist()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "emplist.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult Imgurl()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "imgurl.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetElectronNoByParam()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "electronNoByParam.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult Getpointlist()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "pointlist.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult Getsignnamelist()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "signnamelist.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Areabyimg()
        {
            return new string[0];
        }
        [HttpPost]
        public IActionResult GetColorSet()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "colorSet.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        
        [HttpPost]
        public IActionResult GetAllColorFile()
        {
            var department = new
            {
                IsOk = true,
                Msg = "",
                Cause = "",
                Code = "200",
                Data = new List<string>
            {
                "0051FF.png",
                "1E90FF.png",
                "808080.png",
                "888600.png",
                "FF0000.png",
                "FF004D.png",
                "FF00FB.png",
                "FFFEF6.png"
            }
            };

            return Ok(department);
        }
        [HttpPost]
        public IActionResult GetNewPointElectronByOther()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "NewPointElectronByOther.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetAreaPoint()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "AreaPoint.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetPointMuster()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "PointMuster.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetAllCameraPlane()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "AllCameraPlane.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetPointMaterialAllInfo()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "PointMaterialAllInfo.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetPointLonLat()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "PointLonLat.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult UploadColorImg()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "colorImg.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult Geallshop()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "geallshop.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetStatisticalList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "StatisticalList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetStatisticalLine()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "StatisticalLine.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult Monitorgetemp()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "Monitorgetemp.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JArray.Parse(json1));
        }
        [HttpPost]
        public IActionResult Factoryarea()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "Factoryarea.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult WarnDetailList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "WarnDetailList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetRangeIoList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "RangeIoList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetWarnDetailList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "WarnDetailList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult daycount()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "daycount.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetAreaIoInfoDate()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "AreaIoInfoDate.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        public IActionResult GetHistoricalTrack()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "HistoricalTrack.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
    }
}
