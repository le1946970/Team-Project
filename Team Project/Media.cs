using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Media : Files
    {
        public Media() : base()
        {
            Title = "";
            Length = 0;
            Rating = "";
        }
        public string Title { get; set; }
        public double Length { get; set; }
        public string Rating { get; set; }
    }
}
