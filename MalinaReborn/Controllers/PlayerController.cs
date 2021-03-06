﻿using MalinaReborn.Core.Players;
using Microsoft.AspNetCore.Mvc;

namespace MalinaReborn.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayer _player;

        public PlayerController(IPlayer player)
        {
            _player = player;
        }

        [HttpPost, Route("play")]
        public void Play(string path)
        {
            _player.Play(path);
        }

        [HttpPost, Route("pause")]
        public void Pause()
        {
            _player.Pause();
        }

        [HttpPost, Route("stop")]
        public void Stop()
        {
            _player.Stop();
        }
    }
}