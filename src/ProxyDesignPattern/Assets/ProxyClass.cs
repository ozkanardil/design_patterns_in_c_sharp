using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Assets
{
    public class ProxyClass : Subject
    {
        Subject cs;
        public override void DoSomeWork()
        {
            Console.WriteLine("Proxy call happening now...");
            //Lazy initialization:We'll not instantiate until the method is 
            //called
            if (cs == null)
            {
                cs = new ConcreteSubject();
            }
            cs.DoSomeWork();
        }
    }
}
