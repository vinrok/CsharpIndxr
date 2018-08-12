using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssoc
{
    class ExecIndexer
    {
        static void Main(string[] args)
        {
            var name = new IndexerClass();
            name[0] = "Vinay";
            name[1] = "Vishal";
            name[2] = "Viraj";
            name[3] = "luv";

            for (int i=0; i < 4; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
