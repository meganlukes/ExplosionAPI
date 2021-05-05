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
    public class ReverseStringController : ControllerBase
    {
        [HttpGet("{string")]
        public static string StringReverser(string str)
        {
            char[] oldStringArray = str.ToCharArray();
            string newString = "";
            int arraylength = oldStringArray.Length - 1;
            for (int i = arraylength; i > -1; i--)
            {
                newString = newString + oldStringArray[i];
            }
            return $"The new string is {newString}.";
        }
    }
}