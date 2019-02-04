using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MalinaReborn.Core.Players
{
    public class StreamlinkPlayer : OmxPlayer
    {
        public override Process StartProcess(string path)
        {
            var processStartInfo = new ProcessStartInfo("streamlink", $"-p \"omxplayer --win '30 20 1250 700' --timeout 20\" --player-fifo {path} 480p");
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardInput = true;
            var process = Process.Start(processStartInfo);
            process.StandardInput.AutoFlush = true;
            return process;
        }
    }
}
