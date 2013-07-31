using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHelper
{
    public class Helper
    {
        public string Name { get; set; }

        public int Value{get;set;}

        public void Test() 
        {
            string val = "";
        }

        public object getObj() 
        {
            return new { zhurenhuo = "liudehua" };
        }
    }
}
