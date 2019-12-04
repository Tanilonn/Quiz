using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_w3d1
{
    class OpenQuestion : IQuestion
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public int Graad { get; set; }
        public string Categorie { get; set; }

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
