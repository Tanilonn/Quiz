using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_w3d1
{
    class Program
    {
        static List<IQuestion> Questions = new List<IQuestion>();

        static void Main(string[] args)
        {
            InitializeQuestions();
            TakeQuiz(Questions);
            //herhaal de moeilijkste vragen
            TakeQuiz(AlleenDezeGraad(3));
            Console.ReadLine();
        }

        static void InitializeQuestions()
        {
            Questions.Add(new OpenQuestion() { Vraag = "Wat is 1 + 1", Antwoord = "2", Categorie = "Rekenen", Graad = 1 });
            Questions.Add(new OpenQuestion() { Vraag = "Hoeveel botten heeft een mens", Antwoord = "206", Categorie = "Biologie", Graad = 2 });
            Questions.Add(new OpenQuestion() { Vraag = "Vertaal 'large'", Antwoord = "groot", Categorie = "Engels", Graad = 1 });
            Questions.Add(new OpenQuestion() { Vraag = "Welk celonderdeel zorgt ervoor dat een plant z'n eigen voedsel kan maken?", Antwoord = "bladgroenkorrels", Categorie = "Biologie", Graad = 3 });
            ChoiceQuestion choices = new ChoiceQuestion() { Vraag = "Give a synonym of large (geef het nummer van het juiste antwoord)", Antwoord = "2", Categorie = "Engels", Graad = 2 };
            choices.AddChoice("Small", false);
            choices.AddChoice("Big", true);
            choices.AddChoice("Weird", false);
            choices.AddChoice("Tiny", false);
            Questions.Add(choices);

        }

        static void TakeQuiz(List<IQuestion> list)
        {
            foreach (IQuestion question in list)
            {
                question.DisplayQuestion();
                question.CheckAnswer(Console.ReadLine());
            }
        }

        //Gebruik LINQ om de vragen te sorteren van gemakkelijk naar moeilijk of op category. Maak hiervoor gebruik van het keyword var.
        static List<IQuestion> OrderQuestionsByGraad()
        {
            var MakNaarMoei = (from q in Questions
                               orderby q.Graad
                               select q).ToList();
            return MakNaarMoei;
        }
        static List<IQuestion> OrderQuestionsByCategory()
        {
            var OpCategorie = (from q in Questions
                               orderby q.Categorie
                               select q).ToList();
            return OpCategorie;
        }

        //Gebruik LINQ om alleen de vragen te stellen van een bepaalde moeilijkheidsgraad of van een bepaalde category.Maak hiervoor geen gebruik van het keyword var.
        static List<IQuestion> AlleenDezeGraad(int Moeilijkheid)
        {
            List<IQuestion> VragenvanGraad = (from q in Questions
                                  where q.Graad == Moeilijkheid
                                  select q).ToList();
            return VragenvanGraad;
        }
        static List<IQuestion> AlleenDezeCategorie(string Cat)
        {
            List<IQuestion> VragenvanCat = (from q in Questions
                                                  where q.Categorie == Cat
                                                  select q).ToList();
            return VragenvanCat;
        }
    }
}
