using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TestDocker.Services;
using Repository.Interfaces;
namespace TestDocker.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private IBuildVersionRepository service;

        public StatusController(IBuildVersionRepository service)
        {
            this.service = service;
        }
        [HttpGet()]
        public async Task<IActionResult> GetBuildVersion()
        {
            var hello = "Hello World";
            var res = await service.GetBuildVersion();
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(new { message = hello, DatabaseVersion = res });
            return Ok(result);
        }
 
    }
}
