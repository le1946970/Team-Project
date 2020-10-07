using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class MediaFile : GenericFile
    {
        public MediaFile() : base()
        {
            Title = "";
            Length = 0;
            Rating = 0;
        }
        public string Title { get; set; }
        public double Length { get; set; }
        public int Rating { get; set; }
    }
}
