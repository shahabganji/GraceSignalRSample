using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace GraceSignalRSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHubContext<ChatHub, IChatClient> _hubContext;

        public ValuesController(IHubContext<ChatHub,IChatClient> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new[] {"Shahab", "Mansooreh"};
        }
        
        // GET api/values
        [HttpPost]
        public IActionResult Post(string message)
        {
            _hubContext.Clients.All.MessagereceivedAsync(message);
            return Ok();
        }
    }
}
