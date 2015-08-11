namespace TravisExperiments
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("FSharp").OpenSubKey("3.1")
                .OpenSubKey("Runtime")
                .OpenSubKey("v4.0")
                .GetValue(String.Empty));
        }
    }
}
