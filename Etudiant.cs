using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAssuranceQualite
{
    // Classe pour représenter un étudiant
    public class Etudiant
    {
        // Propriétés de l'étudiant
        public int NumeroEtudiant { get; set; } // Identifiant unique de l'étudiant
        public string Nom { get; set; } // Nom de l'étudiant
        public string Prenom { get; set; } // Prénom de l'étudiant

        // Constructeur de la classe Etudiant
        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            this.NumeroEtudiant = numeroEtudiant; // Initialisation du numéro d'étudiant
            this.Nom = nom; // Initialisation du nom
            this.Prenom = prenom; // Initialisation du prénom
        }
    }

}
