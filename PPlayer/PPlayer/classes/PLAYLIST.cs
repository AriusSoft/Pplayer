using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPlayer
{
    public class PLAYLIST
    {
        private List<string> Songs = new List<string>();

        public string this[int i]
        {
            get { return Songs[i]; }
        }

        public int Count()
        {
            return Songs.Count;
        }

        public PLAYLIST(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path, Encoding.Default))
                {

                    string line;
                    int lineCount = 0;


                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineCount == 0 && line != "#EXTM3U")
                            new M3U_Exception("M3U header is missing.");

                        if (line.StartsWith("#EXTINF:"))
                        {
                            string[] temp_m3u_line = line.Substring(8, line.Length - 8).Split(new[] { ',' }, 2);

                            if (temp_m3u_line.Length != 2)
                                new M3U_Exception("Invalid track information.");

                            int seconds;
                            if (!int.TryParse(temp_m3u_line[0], out seconds))
                                new M3U_Exception("Invalid track duration.");
                            


                        }

                        else if (!line.StartsWith("#"))
                        {

                            Uri tpath;
                            if (!Uri.TryCreate(line, UriKind.RelativeOrAbsolute, out tpath))
                                new M3U_Exception("Invalid music path.");

                            Songs.Add(line);

                        }

                        lineCount++;
                    }
                }
            }
            catch
            {
               
            }
        }

       
        
    }
}
