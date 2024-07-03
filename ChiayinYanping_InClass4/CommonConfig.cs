using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiayinYanping_InClass4
{
    internal class CommonConfig
    {
        public CommonConfig() { }
        public void getFilesPath(string emoji)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                // get basic path
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

                DirectoryInfo directory = new DirectoryInfo(projectDirectory);
                while (directory.Name != "bin")
                {
                    directory = directory.Parent;
                }
                string fullName = directory.Parent.Parent.FullName;
                Console.WriteLine("fullName:  " + fullName);

                // get file path
                player.SoundLocation = Path.Combine(fullName, "SoundFiles", emoji);
                Console.WriteLine("soundFilePath:  " + player.SoundLocation);
                player.Play();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
