namespace TravisExperiments
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && string.Concat(args).Contains("blahhhhh"))
            {
                Console.WriteLine("Hura!");
            }

            var p = new Process
            {
                StartInfo =
                {
                    FileName = "fsc.exe",
                    //UseShellExecute = false
                }
            };
            p.Start();
            p.WaitForExit();
            Console.WriteLine(p.ExitCode);
        }
    }
}
