using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tool_ffmpeg
{
    class ffmpeghandler
    {
        public static bool openFFMPEG(string arguments)
        {
            string ffmpeg = $@"/k ffmpeg.exe {arguments}";
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = ffmpeg;

                process.Start();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error ", e);
            }

            return true;
        }

        public static bool openYTDLP(string arguments)
        {
            string yt_dlp = $@"/k yt-dlp.exe {arguments}";
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = yt_dlp;
                //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ", e);
            }

            return true;
        }
    }
}
