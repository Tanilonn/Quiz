using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz_w3d1
{
    class OpenQuestion : IOpenQuestion
    {
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public int Graad { get; set; }
        public string Categorie { get; set; }
    }
}
