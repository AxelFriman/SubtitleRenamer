using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SubtitleRenamer
{
    class Program
    {
        static void Main(string[] args) //TODO: параметры запуска, ручной ввод параметров
        {
            string extVid = ".mkv";
            string extSub = ".ass";
            string dir = @"\";

            string[] videos = Directory.GetFiles(dir, "*" + extVid);
            string[] subtitles = Directory.GetFiles(dir, "*" + extSub);

            for (int i = 0; i < Math.Min(videos.Length, subtitles.Length); i++)
            {
                File.Move(videos[i], subtitles[i].Replace(extSub, extVid));
            }
        }
    }
}
