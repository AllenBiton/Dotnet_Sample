using System;
using System.Collections;
using System.Diagnostics;

namespace Dotnet_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);

            Process[] prl = Process.GetProcesses();
            foreach (Process tp in prl)
                Console.WriteLine("Process: {0} ID: {1}", tp.ProcessName, tp.Id);
        }
    }
}
