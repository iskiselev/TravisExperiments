namespace TravisExperiments
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//arguments//");
            foreach (var s in args)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("//endarguments//");
            if (args.Length > 0 && string.Concat(args).Contains("blahhhhh"))
            {
                Console.WriteLine("Hura!");
            }

            var p = new Process
            {
                StartInfo =
                {
                    FileName = "mono",
                    Arguments = "./FSharp.Compiler.Tools/tools/fsc.exe",
                    UseShellExecute = false
                }
            };
            p.Start();
            p.WaitForExit();
            Console.WriteLine(p.ExitCode);
        }
    }
}
