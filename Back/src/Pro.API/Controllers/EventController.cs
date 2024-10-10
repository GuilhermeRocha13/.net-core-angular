using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pro.API.Models;

namespace Pro.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
       [HttpGet]
       public Event Get(){
            return new Event(){
                EventID = 1
            };
       }
    }
}
