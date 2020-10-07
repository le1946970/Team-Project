using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class ImageFile : GenericFile
    {
        public ImageFile() : base()
        {
            Width = 0;
            Height = 0;
            Resolution = "";
        }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string Resolution { get; set; }
    }
}
