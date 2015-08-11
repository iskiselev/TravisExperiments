namespace TravisExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\FSharp\3.1\Runtime\v4.0", null, @".");
        }
    }
}
