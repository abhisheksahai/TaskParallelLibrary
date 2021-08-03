using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer.AdvancedTopic
{
    public class BaseLogical
    {
     
        public BaseLogical() : this(10)
        {
            Console.WriteLine("Executing Logical Ctor");
        }
        public BaseLogical(int num)
        {
            Console.WriteLine("Executing Logical Ctor");
        }
        public virtual void TestMe()
        {

        }
    }
}
