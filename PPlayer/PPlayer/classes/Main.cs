using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPlayer
{
    public static class Main
    {
        public static Pplayer Link;

        // універсальний шлях програми
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

        // список шляхів
        public static List<string> Files = new List<string>();

        public static int CurTrackNumber;

        public static string GetFileName(string file)
        {
            string[] temp = file.Split('\\');
            return temp[temp.Length - 1];
        }

        public static void InputFormats()
        {
            Link.openFileDialog1.Filter = "All music formats|*.mp3; *.m4a; *.mp4; *tta; *alac; *wv; *wma; *flac|"+
                "Playlist format(*.m3u)|*.m3u";
        }
    }
}
