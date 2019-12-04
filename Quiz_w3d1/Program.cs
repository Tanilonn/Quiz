using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_w3d1
{
    class Program
    {
        static List<IOpenQuestion> OpenQuestions = new List<IOpenQuestion>();

        static void Main(string[] args)
        {
            InitializeQuestions();
            TakeQuiz(OpenQuestions);
            //herhaal de moeilijkste vragen
            TakeQuiz(AlleenDezeGraad(3));
            Console.ReadLine();
        }

        static void InitializeQuestions()
        {
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Wat is 1 + 1", Antwoord = "2", Categorie = "Rekenen", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Hoeveel botten heeft een mens", Antwoord = "206", Categorie = "Biologie", Graad = 2 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Vertaal 'large'", Antwoord = "groot", Categorie = "Engels", Graad = 1 });
            OpenQuestions.Add(new OpenQuestion() { Vraag = "Welk celonderdeel zorgt ervoor dat een plant z'n eigen voedsel kan maken?", Antwoord = "bladgroenkorrels", Categorie = "Biologie", Graad = 3 });
        }

        static void TakeQuiz(List<IOpenQuestion> list)
        {
            foreach (OpenQuestion question in list)
            {
                Console.WriteLine(question.Vraag);
                question.CheckAnswer(Console.ReadLine());
            }
        }

        //Gebruik LINQ om de vragen te sorteren van gemakkelijk naar moeilijk of op category. Maak hiervoor gebruik van het keyword var.
        static List<IOpenQuestion> OrderQuestionsByGraad()
        {
            var MakNaarMoei = (from q in OpenQuestions
                               orderby q.Graad
                               select q).ToList();
            return MakNaarMoei;
        }
        static List<IOpenQuestion> OrderQuestionsByCategory()
        {
            var OpCategorie = (from q in OpenQuestions
                               orderby q.Categorie
                               select q).ToList();
            return OpCategorie;
        }

        //Gebruik LINQ om alleen de vragen te stellen van een bepaalde moeilijkheidsgraad of van een bepaalde category.Maak hiervoor geen gebruik van het keyword var.
        static List<IOpenQuestion> AlleenDezeGraad(int Moeilijkheid)
        {
            List<IOpenQuestion> VragenvanGraad = (from q in OpenQuestions
                                  where q.Graad == Moeilijkheid
                                  select q).ToList();
            return VragenvanGraad;
        }
        static List<IOpenQuestion> AlleenDezeCategorie(string Cat)
        {
            List<IOpenQuestion> VragenvanCat = (from q in OpenQuestions
                                                  where q.Categorie == Cat
                                                  select q).ToList();
            return VragenvanCat;
        }
    }
}
