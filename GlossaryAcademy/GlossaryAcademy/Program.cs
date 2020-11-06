using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WordTranslationLibrary;

namespace GlossaryAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            FilePaths.CreateMap();

            if (args.Length == 0)
            {
                Console.WriteLine("You need to enter a valid argument");
                Menue.MenueChoice();
            }
            if (args.Length > 0)
            {
                if (args[0] == "-lists")
                {
                    foreach (var file in WordList.GetLists())
                    {
                        Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                    }
                    Console.WriteLine("");
                }
                if (args[0] == "-new")
                {
                    if (args.Length == 1)
                    {
                        Console.WriteLine("you have not entered a Listname or any languages");
                        Menue.MenueChoice();
                    }
                    else if (args.Length == 2 || args.Length == 3)
                    {
                        Console.WriteLine("You need to enter atleast two Languages");
                        Menue.MenueChoice();
                    }
                    else if (args.Length >= 4)
                    {
                        string nameofFile = args[1];
                        string[] translationswords = new string[args.Length - 2];

                        for (int i = 0; i < translationswords.Length; i++)
                        {
                            translationswords[i] = args[i + 2];
                        }

                        WordList wordList = new WordList(nameofFile, translationswords);
                        wordList.Save();

                        int counter = 0;
                        string word;
                        List<string> newWords = new List<string>();
                        do
                        {
                            Console.WriteLine($"Enter a {wordList.Languages[counter]} word");
                            counter++;
                            word = Console.ReadLine();
                            if (word == "") { break; }
                            newWords.Add(word);
                            if (counter == wordList.Languages.Length) { counter = 0; }

                        } while (word != "");

                        int removalOfWords = newWords.Count % wordList.Languages.Length;

                        if (newWords.Count % wordList.Languages.Length != 0)
                        {
                            var fixedList = newWords.Take(newWords.Count - removalOfWords).ToArray();
                            wordList.Add(fixedList);
                        }
                        else
                        {
                            wordList.Add(newWords.ToArray());
                        }
                        wordList.Save();
                    }
                }
                if (args[0] == "-add")
                {
                    if (args.Length == 1)
                    {
                        Console.WriteLine("You need to enter a List name");
                        Menue.MenueChoice();
                    }
                    else if (args.Length > 2)
                    {
                        Console.WriteLine("You can only enter one List name");
                        Menue.MenueChoice();
                    }
                    else
                    {
                        WordList retrievedList = WordList.LoadList(args[1]);
                        int counter = 0;
                        string word;
                        List<string> newWords = new List<string>();
                        do
                        {
                            Console.WriteLine($"Enter a {retrievedList.Languages[counter]} word");
                            counter++;
                            word = Console.ReadLine();
                            if (word == "") { break; }
                            newWords.Add(word);
                            if (counter == retrievedList.Languages.Length) { counter = 0; }

                        } while (word != "");

                        int removalOfWords = newWords.Count % retrievedList.Languages.Length;

                        if (newWords.Count % retrievedList.Languages.Length != 0)
                        {
                            var fixedList = newWords.Take(newWords.Count - removalOfWords).ToArray();
                            retrievedList.Add(fixedList);
                        }
                        else { retrievedList.Add(newWords.ToArray()); }
                        retrievedList.Save();
                    }
                }
                if (args[0] == "-count")
                {
                    if (args.Length == 1)
                    {
                        Console.WriteLine("You need to enter a List name");
                        Menue.MenueChoice();
                    }
                    else if (args.Length > 2)
                    {
                        Console.WriteLine("You can only enter one List name");
                        Menue.MenueChoice();
                    }
                    else
                    {
                        WordList listToCountWords = WordList.LoadList(args[1]);
                        Console.WriteLine("");
                        Console.WriteLine($" The wordlist contains {listToCountWords.count()} words");
                        Console.WriteLine("");
                    }
                }
                if (args[0] == "-remove")
                {
                    WordList removeFromThisList = WordList.LoadList(args[1]);
                    int languageIndex = 0;
                    for (int i = 0; i < removeFromThisList.Languages.Length; i++)
                    {
                        if (args[2] == removeFromThisList.Languages[i])
                        {
                            languageIndex = i;

                            for (int j = 0; j < args.Length - 3; j++)
                            {
                                string word = args[3 + j];
                                if (removeFromThisList.Remove(languageIndex, word))
                                {
                                    Console.WriteLine($"-{word} was removed");
                                }
                                else { Console.WriteLine($"The word '{word}' does not exist in the glossary"); }
                                Console.WriteLine("");
                                removeFromThisList.Save();
                            }
                        }
                    }
                }
                if (args[0] == "-words")
                {
                    if (args.Length < 2) { Console.WriteLine("You need to enter a [command] and a listname (Language is optional)"); }

                    if (args.Length == 2)
                    {
                        WordList allWords = WordList.LoadList(args[1]);

                        for (int i = 0; i < allWords.Languages.Length; i++)
                        {
                            Console.Write($"{allWords.Languages[i],-20}");
                        }
                        Console.WriteLine("");
                        int changeRow = 0;
                        Action<string[]> sendToMethod = stringInput =>
                        {
                            if (changeRow == allWords.Languages.Length)
                            {
                                Console.WriteLine();
                                changeRow = 0;
                            }
                            foreach (var word in stringInput)
                            {
                                Console.Write($"{word,-20}");
                                changeRow++;
                            }
                        };

                        allWords.List(0, sendToMethod);
                    }
                    if (args.Length == 3)
                    {
                        WordList allWords = WordList.LoadList(args[1]);

                        int languageIndex = 0;

                        for (int i = 0; i < allWords.Languages.Length; i++)
                        {
                            if (args[2] == allWords.Languages[i])
                            {
                                languageIndex = i;
                            }
                        }
                        for (int i = 0; i < allWords.Languages.Length; i++)
                        {
                            Console.Write($"{allWords.Languages[i],-20}");
                        }
                        int changeRow = 0;
                        Console.WriteLine("");
                        Action<string[]> sendToMethod = stringInput =>
                        {
                            foreach (var word in stringInput)
                            {
                                Console.Write($"{word,-20}");
                                changeRow++;
                                if (changeRow == allWords.Languages.Length)
                                {
                                    Console.WriteLine("");
                                    changeRow = 0;
                                }
                            }
                        };
                        allWords.List(languageIndex, sendToMethod);
                    }
                    if (args.Length > 3)
                    {
                        Console.WriteLine("You can only order you words by one Language a time!");
                    }
                }
                if (args[0] == "-practice")
                {
                    if (args.Length < 2)
                    {
                        Console.WriteLine("You have to enter an existing listname");
                    }
                    if (args.Length > 2)
                    {
                        Console.WriteLine("You can only run one list at a time");
                    }
                    if (args.Length == 2)
                    {
                        var practiceList = WordList.LoadList(args[1]);
                        int correctGuesses = 0;
                        int totalAmountOfGuesses = 0;
                        bool loop = true;
                        do
                        {
                            Word practiceWord = practiceList.GetWordToPractice();
                            Console.WriteLine($"Translate {practiceWord.Translations[practiceWord.FromLanguage]} to " +
                                $"{practiceList.Languages[practiceWord.ToLanguage]}");

                            string userInputTranslation = Console.ReadLine();
                            totalAmountOfGuesses++;
                            if (userInputTranslation == "")
                            {
                                loop = false;
                            }
                            if (userInputTranslation == practiceWord.Translations[practiceWord.ToLanguage])
                            {
                                Console.Clear();
                                correctGuesses++;
                                Console.WriteLine("Your answer is correct!");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Your answer is wrong!");
                            }
                        } while (loop);

                        Console.WriteLine($"You guessed right {correctGuesses} times out of {totalAmountOfGuesses - 1} guesses." +
                            $" right answer frequency: {(Decimal)correctGuesses / (Decimal)(totalAmountOfGuesses - 1) * 100} %");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Menue.MenueChoice();
                }
            }
            Console.ReadKey();
        }
    }
}

