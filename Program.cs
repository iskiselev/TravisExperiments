namespace TravisExperiments
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\FSharp\3.1\Runtime\v4.0", null, null));
        }
    }
}
