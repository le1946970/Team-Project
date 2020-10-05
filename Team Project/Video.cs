using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    //  Class Video derives from parent class Media
    class Video : Media
    {
        public Video() : base()
        {
            //  Declared as empty strings
            Director = "";
            Producer = "";
        }
        public string Director { get; set; }
        public string Producer { get; set; }
    }
}
