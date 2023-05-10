using LocationSystemServer.Models.Users;
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
    public class SystemController : ControllerBase
    {
        [HttpPost]
        //login页面 
        public ActionResult<IEnumerable<string>> AllList()
        {
            return new string[0];
        }
        [HttpGet]
        public IActionResult DepartMentList()
        {
            var department = new
            {
                deptName = "无",
                color = "",
                num = 1
            };

            return Ok(department);
        }
        [HttpPost]
        //login页面 
        public ActionResult<IEnumerable<string>> GetParameterList()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "parameterList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpGet]
        //login页面 
        public ActionResult<IEnumerable<string>> GetParameterLists()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "parameterList.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public IActionResult GetLiveNvrMonitor()
        {
            var department = new
            {
                liveNvrHost = "http://10.59.30.132:10800",
                nvrDeviceId = "",
                isUseNvs = "0",
                isStart = "1",
                token = ""
            };

            return Ok(department);
        }

        [HttpPost] 
        public IActionResult GetWarnTypeName()
        {
            var department = new Dictionary<int, string>
            {
                { 1, "禁区告警-区域" },
                { 2, "超员告警-区域" },
                { 3, "滞留告警-区域" },
                { 4, "区域过短-区域" },
                { 5, "静止超时-区域" },
                { 6, "SOS" },
                { 7, "闯入告警-围栏" },
                { 8, "脱岗告警-围栏" },
                { 13, "车辆超速" },
                { 14, "人员卡充电告警" },
                { 15, "缺员告警-区域" },
                { 16, "脱岗告警-区域" },
                { 17, "车辆路线偏移" },
                { 18, "违停告警" },
                { 19, "二道门离厂超时告警" }
            };
            return Ok(department);
        }
        [HttpGet]
        public IActionResult GetPixiBagImg()
        {
            var department = new
        {
            Id = 4,
            PicNo = "uploadImages/7702975773049725462",
            PicName = "uploadImages/7702975773049725462.jpg",
            PicH = 4539,
            PicW = 7671,
            PicAddr = "uploadImages/7702975773049725462.jpg",
            PicLevel = "",
            LastTime = "2022-05-27 15:51:24",
            Remarks = "",
            BasementImg = "",
            LabelFactoryCode = "",
            ThreeFileName ="" ,
            MinPicAddr = "uploadImages/5625861550127098308.png",
            SubPicAddr = ""
        };
            return Ok(department);
        }
        [HttpPost]
        public IActionResult GetPixiBagImgs()
        {
            var department = new
            {
                Id = 4,
                PicNo = "uploadImages/7702975773049725462",
                PicName = "uploadImages/7702975773049725462.jpg",
                PicH = 4539,
                PicW = 7671,
                PicAddr = "uploadImages/7702975773049725462.jpg",
                Piclevel = "",
                Lasttime = "2022-05-27 15:51:24",
                Remarks = "",
                Basementimg = "",
                LabelFactoryCode = "",
                Threefilename = "",
                MinPicAddr = "uploadImages/5625861550127098308.png",
                SubPicAddr = ""
            };
            return Ok(department);
        }
        [HttpGet]
        public void GetParameterTableList()
        {

        }
    }
}
