using System;
using System.Reflection;

namespace take1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ass = typeof(Program).Assembly;

            Console.WriteLine("Assembly.GetName().Version: {0}", ass.GetName().Version);
         //   Console.WriteLine("AssemblyVersionAttribute: {0}", ((AssemblyVersionAttribute) ass.GetCustomAttribute(typeof(AssemblyVersionAttribute)))?.Version);
            Console.WriteLine("AssemblyFileVersionAttribute: {0}", ((AssemblyFileVersionAttribute) ass.GetCustomAttribute(typeof(AssemblyFileVersionAttribute)))?.Version);
        }
    }
}