using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Assets
{
    public class Product
    {
        // We can use any data structure that you prefer e.g.List<string> etc.
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string part)
        {
            //Adding parts
            parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below :");
            foreach (string part in parts)
                Console.WriteLine(part);
            Console.WriteLine("\n");
        }
    }
}
