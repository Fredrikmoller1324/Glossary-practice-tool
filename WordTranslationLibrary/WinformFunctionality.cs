using System;
using System.Collections.Generic;
using System.IO;

namespace WordTranslationLibrary
{
    public class WinformFunctionality
    {

        public static int CountWords(string selectedFile)
        {
            WordList loadedlist = WordList.LoadList(selectedFile);

            return loadedlist.count();
        }

        public static void DeleteList(string selectedFile)
        {
            File.Delete($"{FilePaths.ListPath}{selectedFile}.dat");
        }
        public WinformFunctionality()
        {

        }
        public WinformFunctionality(string name)
        {

        }
    }
}
