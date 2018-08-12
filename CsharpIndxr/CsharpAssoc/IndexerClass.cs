using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssoc
{
    class IndexerClass
    {
        public string[] name;
        internal int Id = 10;
        public int num = 20;

        public IndexerClass()
        {            
            name = new string[4];
        }

        public string this[int i]
        {
            get
            {
                return name[i];
            }

            set
            {
                name[i] = value;
            }
        }
    }
}
