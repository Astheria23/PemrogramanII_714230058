using P4_01_71420058;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_01_714230058
{
    public class DVD_714230058 : Product_714230058
    {
        protected string duration;

        public DVD_714230058(string title,string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("Ini dari Class DVD");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, duration);
        }
    }
}
