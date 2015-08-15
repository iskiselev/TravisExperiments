namespace TravisExperiments
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.ExpandEnvironmentVariables("cmd1.exe"));
        }
    }
}
