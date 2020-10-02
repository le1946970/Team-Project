using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Image : Files
    {
        public Image() : base()
        {
            Width = 0;
            Height = 0;
            Resolution = 0;
        }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public double Resolution { get; set; }
    }
}
