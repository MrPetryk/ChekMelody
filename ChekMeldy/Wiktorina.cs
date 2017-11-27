using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ChekMeldy
{
    static class Wiktorina
    {
        static public List<string> list = new List<string>();
        private static int i = 0;
        public static int gameDuration = 0;
        public static int musicDuration = 0;
        public static bool randomStart = false;
        public static string lastFolder = "";
        public static bool allDirectories=false;


        public static void readMusic()
        {
            string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3", allDirectories?SearchOption.AllDirectories:SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(musicFiles);
        }

        static string regIDName = "Software\\MyGame\\chekMeldy";

        public static void writeParameters()
        {
            RegistryKey registryKey = null;

            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(regIDName);
                if (registryKey == null) return;
                registryKey.SetValue("Last Folder", lastFolder);
                registryKey.SetValue("Random", randomStart);
                registryKey.SetValue("Game Duration", gameDuration);
                registryKey.SetValue("Music Duration", musicDuration);
                registryKey.SetValue("All Directoris", allDirectories);
            }
            finally
            {
                if (registryKey != null) registryKey.Close();
            }

        }

        public static void readParameters()
        {
            RegistryKey registryKey = null;

            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(regIDName);
                if (registryKey != null)
                {
                    lastFolder=(string)registryKey.GetValue("Last Folder");
                    randomStart=Convert.ToBoolean(registryKey.GetValue("Random"));
                    gameDuration=(int) registryKey.GetValue("Game Duration");
                    musicDuration=(int) registryKey.GetValue("Music Duration");
                    allDirectories=Convert.ToBoolean( registryKey.GetValue("All Directoris"));
                }

            }
            finally
            {
                if (registryKey != null) registryKey.Close();
            }
        }

        public static int I { get => i; set => i = value; }
    }
}
