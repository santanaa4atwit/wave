using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wave2.DataStructure
{
    class SongNode
    {
        public string Name;
        public string Address;
        public SongNode Next;

        public SongNode(string info)
        {
            this.Address = info;
            this.Name = Path.GetFileName(info);
            this.Next = null;
        }
    }
}
