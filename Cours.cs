using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAssuranceQualite
{
    // Classe pour représenter un cours
    public class Cours
    {
        // Propriétés du cours
        public int NumeroCours { get; set; } // Identifiant unique du cours
        public string Code { get; set; } // Code du cours
        public string Titre { get; set; } // Titre du cours

        // Constructeur de la classe Cours
        public Cours(int numeroCours, string code, string titre)
        {
            this.NumeroCours = numeroCours; // Initialisation du numéro du cours
            this.Code = code; // Initialisation du code du cours
            this.Titre = titre; // Initialisation du titre du cours
        }
    }

}
