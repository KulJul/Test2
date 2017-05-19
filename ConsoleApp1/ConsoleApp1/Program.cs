using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x2 = 0;
            int x3 = 0;
        }

        string First()
        {
            return "One";
        }
        static string FirstStatic()
        {
            return "One";
        }
    }

    public class Program2
    {

        public string First()
        {
            return "One";
        }
        public static string FirstStatic()
        {
            return "One";
        }
    }

    public class Program4
    {

        public string First4()
        {
            return "One";
        }
        public static string FirstStatic4()
        {
            return "One";
        }
    }
}
