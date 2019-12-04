using System;
using System.Collections.Generic;

namespace Quiz_w3d1
{
    class Program
    {
        static List<IOpenQuestion> OpenQuestions = new List<IOpenQuestion>();

        static void Main(string[] args)
        {
            InitializeQuestions();
            TakeQuiz();
            Console.ReadLine();
        }

        static void InitializeQuestions()
        {
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Wat is 1 + 1", Antwoord = "2", Categorie = "Rekenen", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Hoeveel botten heeft een mens", Antwoord = "206", Categorie = "Biologie", Graad = 2 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Vertaal 'large'", Antwoord = "groot", Categorie = "Engels", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Welk celonderdeel zorgt ervoor dat een plant z'n eigen voedsel kan maken?", Antwoord = "bladgroenkorrels", Categorie = "Biologie", Graad = 3 });
        }

        static void TakeQuiz()
        {
            foreach(OpenQuestion question in OpenQuestions)
            {
                Console.WriteLine(question.Vraag);
                question.CheckAnswer(Console.ReadLine());
            }
        }
        //Gebruik LINQ om de vragen te sorteren van gemakkelijk naar moeilijk of op category. Maak hiervoor gebruik van het keyword var.
        static void OrderQuestions()
        {

        }
        //Gebruik LINQ om alleen de vragen te stellen van een bepaalde moeilijkheidsgraad of van een bepaalde category.Maak hiervoor geen gebruik van het keyword var.
        static void SelectQuestions()
        {

        }
    }
}
