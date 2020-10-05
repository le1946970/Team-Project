using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    //  Class Media derives from parent class Files
    class Media : Files
    {
        public Media() : base()
        {
            //  Default value declared as empty strings and 0
            Title = "";
            Length = 0;
            Rating = "";
        }
        public string Title { get; set; }
        public double Length { get; set; }
        public string Rating { get; set; }
    }
}
