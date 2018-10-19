using System;
using System.Globalization;
using System.Collections.Generic;
namespace GuessTheNumber
{
    class Question
    {
        public string question;
        public string tooMuch;
        public string tooLess;
        public string prize;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Czesc do wychwytywania jezyka systemu
            CultureInfo cultureInfo = CultureInfo.InstalledUICulture;
            string language = cultureInfo.TwoLetterISOLanguageName;
            switch (language)
            {
                case ("pl"):
                    Console.WriteLine("Wykryłem język polski: ");
                    break;
                case ("de"):
                    Console.WriteLine("Ich habe Deutsch entdeckt");
                    break;
                case ("en"):
                    Console.WriteLine("I detected English language");
                    break;

            }
            Dictionary<string, Question> questions = new Dictionary<string, Question>()
            {
                {"pl",new Question(){question="Podaj liczbe: ",tooLess="Za mało!",tooMuch="Za dużo!",prize="Wygrałeś!"}},
                {"en",new Question(){question="Give a number: ",tooLess="To less!",tooMuch="Too much!", prize="Congratulations, You Won!"}},
                {"de",new Question(){question="Geben Sie die Nummer ein :",tooLess="Zu viel!",tooMuch="Nicht genug!",prize="Won!"}}

            };
            string question = "", tooMuch = "", tooLess = "", prize = "";

            if (questions.ContainsKey(language))
            {
                question = questions[language].question;
                tooMuch = questions[language].tooMuch;
                tooLess = questions[language].tooLess;
                prize = questions[language].prize;
            }
            
            //koniec czesci do wychwytywania jezyka systemu
            Random r = new Random();
            int n = r.Next(100);

            bool w = false;

            do
            {
                Console.Write(question);
                string s = Console.ReadLine();

                int l = int.Parse(s);

                if (l > n)
                {
                    Console.WriteLine(tooMuch);
                }
                else if (l < n)
                {
                    Console.WriteLine(tooLess);
                }
                else
                {
                    Console.WriteLine(prize);
                    w = true;
                }

            }
            while (w == false);
         
        }
    }
}
