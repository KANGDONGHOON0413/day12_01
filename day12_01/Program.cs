using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var myche = new Mycache();
            myche.Add("ItemId","1100");
            var t1 = myche.getItem("Debug");
            myche.setItem("ItemId", "1200");
            var t2 = myche.getItem("ItemId");
            
            //인덱서 활용 부분
            myche["Debug"] = "true";
            var t3 = myche["Debug"];
            
            Console.WriteLine(t1 + "\t" + t2 + "\t" + t3);
        }
    }
}
