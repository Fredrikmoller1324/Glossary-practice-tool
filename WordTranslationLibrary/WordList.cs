using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordTranslationLibrary
{
    public class WordList
    {
        //private static List<string> translations = new List<string>();

        private List<Word> words = new List<Word>();

        //namnet på listan
        public string Name { get; }

        //namnet på språken
        public string[] Languages { get; }


        public WordList()
        {

        }
        //konstruktor sätter properties Name och Languages till parametrarnas värde
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        //returnerar array med namn på alla listor som är lagrade utan filändelse
        //directory.getfiles returnerar alla filer i en specifik sökväg
        public static string[] GetLists()
        {
            string[] allFilesInGlossaryAcademy = Directory.GetFiles(FilePaths.ListPath);
            return allFilesInGlossaryAcademy;
        }

        //Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList. 
        //hämtar fil med filnamn + språk samt allt innehåll i filen(words)
        public static WordList LoadList(string name)
        {
            if (File.Exists(FilePaths.ListPath + name + ".dat"))
            {
                using (StreamReader sr = new StreamReader(FilePaths.ListPath + name + ".dat"))
                {
                    string[] languages = sr.ReadLine().TrimEnd(';').Split(';');
                    WordList wordList = new WordList(name, languages);
                    while (!sr.EndOfStream)
                    {
                        string[] translations = sr.ReadLine().TrimEnd(';').Split(';');
                        wordList.Add(translations);
                    }
                    return wordList;
                }
            }
            else
            {
                throw new ArgumentException("No File with that name exists");
            }
        }

        //Sparar listan till en fil med samma namn som listan och filändelse .dat 
        public void Save()
        {
            string nameOfFile = Name;

            string WriteInThisFile = nameOfFile += ".dat";

            using (StreamWriter sw = new StreamWriter(FilePaths.ListPath + WriteInThisFile))
            {
                foreach (var language in Languages)
                {
                    sw.Write(language + ";");
                }

                foreach (Word word in words)
                {
                    sw.WriteLine("");

                    foreach (var translations in word.Translations)
                    {

                        sw.Write(translations + ";");
                    }
                }
                sw.Close();
            }
        }

        //Lägger till ord i listan. Kasta ArgumentException om det är fel antal translations. 
        public void Add(params string[] translations)
        {
            if (translations.Length % Languages.Length != 0)
            {
                throw new ArgumentException("You have not entered correct amount of translations for you word");
            }
            else
            {
                for (int i = 0; i < translations.Length; i += Languages.Length)
                {
                    string[] wordBuffer = new string[Languages.Length];

                    for (int j = 0; j < Languages.Length; j++)
                    {
                        wordBuffer[j] = translations[i + j];
                    }
                    words.Add(new Word(wordBuffer));
                }
            }
        }

        /*
        wordList.Languages har index för vilket språk som ligger på vilken position.
        int translation ger index för språk som ska gås igenom.
        foreach Word i WordList List<Word> om word.Translation[i] == word, list.RemoveAt(i).
        */

        //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if(words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);

                    return true;
                }
            }

            return false;
        }

        //Räknar och returnerar antal ord i listan.
        public int count()
        {
            return words.Count;

        }

        //sortByTranslation = Vilket språk listan ska sorteras på.
        //showTranslations = Callback som anropas för varje ord i listan.
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<string[]> wordsInList = new List<string[]>();

            foreach (Word item in words)
            {
                wordsInList.Add(item.Translations);
            }

            List<string[]> wordListInOrder = wordsInList.OrderBy(language => language[sortByTranslation]).ToList();

            foreach (string[] word in wordListInOrder)
            {
                showTranslations.Invoke(word);
            }

        }

        //Returnerar slumpmässigt Word från listan, med slumpmässigt valda
        //FromLanguage och ToLanguage(dock inte samma). 
        public Word GetWordToPractice()
        {
            Random r = new Random();

            int randomWordIndex = r.Next(words.Count);

            var randomWord = words[randomWordIndex];

            int fromLanguages = r.Next(0, Languages.Length);

            int toLanguages = r.Next(0, Languages.Length);
            
            while(fromLanguages == toLanguages)
            {
                toLanguages = r.Next(Languages.Length);
            }

            Word practiveWord = new Word(fromLanguages,toLanguages,randomWord.Translations);

            return practiveWord;
        }      
    }
}
