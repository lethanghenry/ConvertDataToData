using BackEnd2.AdapterFolder;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }   
        public Adapter adapter = new Adapter();

        [HttpPost("EncodeToByte")]
        public ActionResult<string> EncodeToByte(string request,string inputData)
        {
            return adapter.Encode(request, inputData);
        }
        [HttpPost("DecodeToData")]

        public ActionResult<string> DecodeToData(string request,  string outputData)
        {
            return adapter.Decode(request, outputData);
        }
    }
}
