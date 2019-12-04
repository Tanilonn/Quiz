using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_w3d1
{
    class ChoiceQuestion : IQuestion
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public int Graad { get; set; }
        public string Categorie { get; set; }
        public List<string> keuzes = new List<string>();

        public void AddChoice(string keuze, bool correct)
        {
            keuzes.Add(keuze);
            if (correct)
            {
                Antwoord = keuzes.Count.ToString();
            }
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Vraag);
            int nummer = 0;
            foreach(string keuze in keuzes)
            {
                nummer += 1;
                Console.WriteLine(nummer + ". " + keuze);
            }
        }

        public void CheckAnswer(string input)
        {
            if (input == Antwoord)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Fout! Het antwoord was: " + Antwoord);
            }
        }
    }
}
