using System;
using System.IO;

namespace Pragati_Judge
{
    class Log
    {
        public static void log(string args, String fileName)
        {
            StreamWriter fout = null;
            try
            {
                if (!File.Exists(fileName))
                    fout = File.CreateText(fileName);
                else
                    fout = File.AppendText(fileName);
                fout.WriteLine(args);                
                fout.Close();
            }
            catch (Exception) { Console.Write("Error Logging"); }
        }

    }
}
