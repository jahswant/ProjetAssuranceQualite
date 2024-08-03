using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetAssuranceQualite
{
    // Classe pour représenter une note attribuée à un étudiant pour un cours
    public class Notes
    {
        // Propriétés de la note
        public int NumeroEtudiant { get; set; } // Numéro d'étudiant
        public int NumeroCours { get; set; } // Numéro du cours
        public float Note { get; set; } // La note obtenue

        // Constructeur de la classe Notes
        public Notes(int numeroEtudiant, int numeroCours, float note)
        {
            this.NumeroEtudiant = numeroEtudiant; // Initialisation du numéro d'étudiant
            this.NumeroCours = numeroCours; // Initialisation du numéro du cours
            this.Note = note; // Initialisation de la note
        }
    }
}
