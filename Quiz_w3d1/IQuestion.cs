using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_w3d1
{
    interface IQuestion
    {
        string Vraag { get; set; }
        string Antwoord { get; set; }
        int Graad { get; set; }
        string Categorie { get; set; }

        void CheckAnswer(string input);
        void DisplayQuestion();

    }
}
