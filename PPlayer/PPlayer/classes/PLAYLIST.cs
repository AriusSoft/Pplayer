using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPlayer.classes
{
    class PLAYLIST
    {
        private string name;
        private List<string> Songs = new List<string>();
        private uint count_of_songs;

        public string this[int i]
        {
            get { return Songs[i]; }
        }

        PLAYLIST(string _name_)
        {
            name = _name_;
            count_of_songs = 0;
        }

        PLAYLIST(string path, string _name_)
        {
            
            
        }
        
    }
}
