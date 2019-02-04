using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MalinaReborn.Core.Players;
using Microsoft.AspNetCore.Mvc;

namespace MalinaReborn.Controllers
{
    [Produces("application/json")]
    [Route("api/OmxPlayer")]
    public class OmxPlayerController : PlayerController
    {
        public OmxPlayerController(OmxPlayer player) : base(player)
        {
        }
    }
}