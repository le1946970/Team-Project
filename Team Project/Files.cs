using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Project
{
    class Files
    {
        public Files()
        {
            Name = "";
            Type = "";
            Size = 0;
            LastModification = 0;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Size { get; set; }
        public int LastModification { get; set; }
    }
}
