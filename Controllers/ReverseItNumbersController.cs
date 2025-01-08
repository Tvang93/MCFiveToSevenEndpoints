using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCFiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersServices _reverseItNumbersServices;

        public ReverseItNumbersController(ReverseItNumbersServices reverseItNumbersServices)
        {
            _reverseItNumbersServices = reverseItNumbersServices;
        }

        [HttpGet]
        [Route("ReverseItNumbers/{stringNum}")]
        public string ReverseItNumbers(string stringNum)
        {
            return _reverseItNumbersServices.ReverseItNumbers(stringNum);
        }
    }
}