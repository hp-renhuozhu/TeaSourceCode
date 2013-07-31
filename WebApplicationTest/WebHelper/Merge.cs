using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHelper
{
   public  class Merge
    {
       public bool DealWithConflict() 
       {
           return true;
       }

       public string GetValue() 
       {
           return "val";
       }

       public bool SetValue() 
       {
           return false;
       }

       public object GetObj() 
       {
           return new { customer = "dsa" };
       }
    }
}
