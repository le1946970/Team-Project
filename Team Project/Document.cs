using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Document
    {
        public Document()
        {
            NumPages = 0;
            NumWords = 0;
            DocSubject = "";
        }
        public int NumPages { get; set; }
        public int NumWords { get; set; }
        public string DocSubject { get; set; }
    }
}
