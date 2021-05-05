using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{string")]
        public static string Explode(string s)
        {
            var explodeStr = "";
            for (var i = 0; i < s.Length; i++)
            {
                var numChar = s[i].ToString();
                var num = Int32.Parse(numChar);
                for (var j = 0; j < num; j++)
                {
                    explodeStr = explodeStr + numChar;
                }
            }
            return $"The new string is {explodeStr}";
        }
    }
}