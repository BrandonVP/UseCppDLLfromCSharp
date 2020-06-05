using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace UseCppDLLfromCSharp
{
    class Program
    {
        [DllImport("C:\\Users\\bvanpelt\\source\\repos\\UseCppDLLfromCSharp\\UseCppDLLfromCSharp\\shared_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void pipecommand(string str);
      
        [DllImport("C:\\Users\\bvanpelt\\source\\repos\\UseCppDLLfromCSharp\\UseCppDLLfromCSharp\\shared_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int add(int a, int b);
     

        static void Main(string[] args)
        {
            int c = add(25, 25);
            Console.WriteLine("c=" + c);
            StringBuilder sb = new StringBuilder();
      
            pipecommand(@"dir c:\");
            Console.ReadLine();

        }
    }
}
