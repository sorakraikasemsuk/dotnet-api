using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string Hello(){
            return "Hello";
        }
        [HttpPost]
        //Content-Type: x-www-form-urlencoded
        public IActionResult Add([FromForm]string name,string lastname){
            return Ok($"Add Name: {name} LastName: {lastname}");
        }
        [HttpPost]
        //Content-Type: application/json
        public IActionResult Edit(string name,string lastname){
            return Ok($"Edit Name: {name} LastName: {lastname}");
        }
        [HttpPost]
        //Content-Type: application/json
        public IActionResult EditModel([FromBody]Param data){
            return Ok($"Edit Name: {data.name} LastName: {data.lastname}");
        }
    }
    public class Param{
        public string name { get; set; }
        public string lastname { get; set; }
    }
}
