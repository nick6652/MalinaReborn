﻿using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MalinaReborn.Core.Models;

namespace MalinaReborn.Core.Players
{
    public class OmxPlayer : IPlayer
    {
        private readonly OmxPlayerOptions _options;
        private Process _process;

        public OmxPlayer(IOptions<OmxPlayerOptions> options)
        {
            _options = options.Value;
        }

        protected OmxPlayer()
        {

        }

        public void Play(string path)
        {
            if (_process == null)
            {
                _process = StartProcess(path);
            }
        }

        public virtual Process StartProcess(string path)
        {
            var processStartInfo = new ProcessStartInfo("omxplayer", string.Join(" ", _options.Arguments, path));
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardInput = true;
            var process = Process.Start(processStartInfo);
            process.StandardInput.AutoFlush = true;
            return process;
        }

        public void Pause()
        {
            if (_process == null)
                return;

            SendCommand('p');
        }

        public void Stop()
        {
            if (_process == null)
                return;

            SendCommand('q');
            _process.WaitForExit();
            _process.Dispose();
            _process = null;
        }

        private void SendCommand(char command)
        {
            _process.StandardInput.Write(command);
        }
    }
}
