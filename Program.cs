using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetAssuranceQualite
{
    internal static class Program
    {
        /// <summary>
        /// Le point d'entrée principal pour l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Active les styles visuels pour les contrôles Windows Forms
            Application.EnableVisualStyles();

            // Définit le rendu du texte compatible avec les styles visuels pour les contrôles Windows Forms
            Application.SetCompatibleTextRenderingDefault(false);

            // Lance l'application en affichant le formulaire principal
            Application.Run(new FormMenuPrincipale());

            // Définit les chemins des fichiers pour les étudiants et les cours
            string etudiantsFile = "etudiants.txt";
            string coursFile = "cours.txt";

            // Crée les fichiers s'ils n'existent pas déjà
            CreateFileIfNotExists(etudiantsFile);
            CreateFileIfNotExists(coursFile);
        }

        /// <summary>
        /// Crée un fichier s'il n'existe pas déjà.
        /// </summary>
        /// <param name="fileName">Le nom du fichier à créer.</param>
        static void CreateFileIfNotExists(string fileName)
        {
            // Vérifie si le fichier existe déjà
            if (!File.Exists(fileName))
            {
                try
                {
                    // Crée le fichier
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Optionnellement, du contenu initial peut être écrit dans le fichier ici
                    }
                    // Affiche un message indiquant que le fichier a été créé avec succès
                    Console.WriteLine($"File {fileName} created successfully.");
                }
                catch (Exception ex)
                {
                    // Affiche un message d'erreur si la création du fichier échoue
                    Console.WriteLine($"Error creating file {fileName}: {ex.Message}");
                }
            }
            else
            {
                // Affiche un message indiquant que le fichier existe déjà
                Console.WriteLine($"File {fileName} already exists.");
            }
        }
    }
}
