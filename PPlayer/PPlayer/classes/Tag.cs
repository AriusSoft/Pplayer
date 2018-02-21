using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;


namespace PPlayer
{
    public class Tag
    {
        public int Bitrate;
        public int HG;
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;

        Dictionary<int, string> D_Channels = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo"}
        };

        public Tag(string file_path)
        {
            TAG_INFO tag_INFO = new TAG_INFO();
            tag_INFO = BassTags.BASS_TAG_GetFromFile(file_path);
            Bitrate = tag_INFO.bitrate;
            HG = tag_INFO.channelinfo.freq;
            Channels = D_Channels[tag_INFO.channelinfo.chans];
            Artist = tag_INFO.artist;
            Album = tag_INFO.album;
            Year = tag_INFO.year;

            Title = (tag_INFO.title == "") ? Main.GetFileName(file_path) : tag_INFO.title;
            
                
            
    }
    }
}
