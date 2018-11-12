using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolderCompare
{
    public class FileItem
    {
        public string name { get; set; }
        public string  ext { get; set; }
        public long size { get; set; }
        public DateTime crttime { get; set; }

        public string fullpath { get; set; }



    }
}
