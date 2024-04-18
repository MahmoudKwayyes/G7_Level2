using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Example.Extensions
{
    public static class Exensionsssssss
    {
        public static void print(int y, this product p, int x)
        {

        }
        public static void p(this string s)
        {

        }
    }

    public class Demo
    {
        void main()
        {
            product p = new product();
            p.print();

            string x = "ddd";
            x.p();

        }
    }

    public class product
    {
        public product()
        {

        }
    }
}
