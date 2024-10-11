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
        public IEnumerable<Event> _event = new Event[]{
                new Event(){
                    EventID = 1
                },
                new Event(){
                    EventID = 2
                }
            };

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> Get(int id)
        {
            return _event.Where(e => e.EventID== id);
        }
    }
}
