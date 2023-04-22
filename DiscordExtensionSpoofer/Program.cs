using CommandDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordExtensionSpoofer
{
    public class Program
    {
        static int Main(string[] args)
        {
          
            return new AppRunner<Program>().Run(args);
        }

        public void Spoof(string filepath, string extension,bool removePeriod = false)
        {
            string spoofed = Extension(filepath, extension.Replace(".",""), Path.GetExtension(filepath).Replace(".", ""), removePeriod);
            File.Copy(filepath,Path.Combine(Environment.CurrentDirectory, spoofed));
        }
        private static string Extension(string file, string spoofextension, string realextension,bool remove)
        {
            string consoleout;
            if (remove)
            {
                consoleout = $"{Path.GetFileNameWithoutExtension(file)}‪⁯‮{realextension.Replace(".", "")}.{spoofextension}";
              
            }
            else
            {
                consoleout = $"{Path.GetFileNameWithoutExtension(file)}.‪⁯‮{realextension.Replace(".", "")}.{spoofextension}";

                
            }
            Console.WriteLine($"Spoofed Filename!");
            return consoleout;
        }
    }
}
