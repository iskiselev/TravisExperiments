namespace TravisExperiments
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Microsoft").CreateSubKey("FSharp").CreateSubKey("3.1")
                .CreateSubKey("Runtime")
                .CreateSubKey("v4.0")
                .SetValue(String.Empty, @"blah!");
            var str = File.ReadAllText(@"/tmp/test/LocalMachine/software/microsoft/fsharp/3.1/runtime/v4.0/values.xml");
            Console.WriteLine(str);
        }
    }
}
