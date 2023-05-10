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

    public class UserController : ControllerBase
    {

        [HttpPost]
        public ActionResult<IEnumerable<string>> Get2([FromBody] UserInPara model)
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public IActionResult Get3([FromBody] UserInPara model)
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "json1.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }


        [HttpGet]
        public IActionResult Login()
        {
            var json1 = System.IO.File.ReadAllText(Path.Combine("app_data", "login.json"), encoding: System.Text.UTF8Encoding.UTF8);
            return new JsonResult(JObject.Parse(json1));
        }
        [HttpPost]
        public void Logoff()
        {

        }
    }
}
