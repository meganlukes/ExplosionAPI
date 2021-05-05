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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{string}")]
        public static string Mumble(string s)
        {
            var mumbleStr = "";
            var charList = new List<char>(s);
            for (var i = 0; i < charList.Count; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        mumbleStr = mumbleStr + char.ToUpper(charList[i]);
                    }
                    else
                    {
                        mumbleStr = mumbleStr + char.ToLower(charList[i]);
                    }
                }
                if (i != charList.Count - 1)
                {
                    mumbleStr += "-";
                }
            }
            return $"The new string is {mumbleStr}";
        }
    }

}