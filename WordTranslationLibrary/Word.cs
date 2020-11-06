namespace WordTranslationLibrary
{
    //klassen används för att lagra ett enskilt ord
    public class Word
    {
        //lagrar översättningarna. En för varje språk
        public string[] Translations { get; }

        //vid practice väljs FRÅN vilket språk som ordet ska översättas
        public int FromLanguage { get; }

        //vid practice väljs vilket språk ordet ska översättas TILL
        public int ToLanguage { get; }

        
        // initialiserar "Translations" med data som skickas in som "translations"
        public Word(params string[] translations)
        {
            Translations = translations;
        }

        // initialiserar "Translations" med data som skickas in som "translations" fast sätter även FromLanguage och ToLanguage

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }

    }
}
