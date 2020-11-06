using System;
using System.Dynamic;
using System.IO;


namespace WordTranslationLibrary
{

    public static class FilePaths
    {
        public static string ListPath { get; set; }

        public static void CreateMap()
        {
            string projectName = Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location).ToString();

            string GlossaryAcademy = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), projectName + "\\");
            Directory.CreateDirectory(GlossaryAcademy);

            ListPath = GlossaryAcademy;
        }
    }
}
