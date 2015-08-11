namespace TravisExperiments
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Microsoft").CreateSubKey("FSharp").CreateSubKey("3.1")
                .CreateSubKey("Runtime")
                .CreateSubKey("v4.0")
                .SetValue(String.Empty, @".");
        }
    }
}
