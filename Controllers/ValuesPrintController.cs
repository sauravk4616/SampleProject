using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesPrintController : ControllerBase
    {
        [HttpGet]
        [Route("getVal")]

        public string getdetails()
        {
            return "My name Is Saurav";
        }
    }
}
