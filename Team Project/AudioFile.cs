using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    //  class Audio derives from parent class Media
    class AudioFile : MediaFile
    {
        public AudioFile() : base()
        {
            //  Default values declared as empty string and 0
            Artist = "";
            BitRate = 0;
        }
        public string Artist { get; set; }
        public int BitRate { get; set; }
    }
}
