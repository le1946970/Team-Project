using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    //  class Document derives from parent class Files
    class DocumentFile : GenericFile
    {
        //  Default values declared as empty string and 0's
        public DocumentFile() : base()
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
