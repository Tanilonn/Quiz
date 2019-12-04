using System;
using System.Collections.Generic;

namespace Quiz_w3d1
{
    class Program
    {
        static List<IOpenQuestion> OpenQuestions = new List<IOpenQuestion>();

        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }

        static void InitializeQuestions()
        {
            OpenQuestions.Add(new OpenQuestion() { Vraag = "wat is 1 + 1", Antwoord = "2", Categorie = "Rekenen", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "hoeveel botten heeft een mens", Antwoord = "206", Categorie = "Biologie", Graad = 2 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "vertaal 'large'", Antwoord = "groot", Categorie = "Engels", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "welk celonderdeel zorgt ervoor dat een plant z'n eigen voedsel kan maken?", Antwoord = "bladgroenkorrels", Categorie = "Biologie", Graad = 3 });
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
