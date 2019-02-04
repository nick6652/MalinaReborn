using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalinaReborn.Core.Players;
using Microsoft.AspNetCore.Mvc;

namespace MalinaReborn.Controllers
{
    [Produces("application/json")]
    [Route("api/streamlink")]
    public class StreamlinkController : PlayerController
    {
        public StreamlinkController(StreamlinkPlayer player) : base(player)
        {
        }
    }
}