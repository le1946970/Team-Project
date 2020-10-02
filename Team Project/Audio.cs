using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Audio : Media
    {
        public Audio() : base()
        {
            Artist = "";
            BitRate = 0;
        }
        public string Artist { get; set; }
        public int BitRate { get; set; }
    }
}
