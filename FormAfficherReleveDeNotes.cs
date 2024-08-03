using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjetAssuranceQualite
{
    public partial class FormAfficherReleveDeNotes : Form
    {
        // Constructeur du formulaire
        public FormAfficherReleveDeNotes()
        {
            InitializeComponent();
        }

        // Méthode appelée lors du chargement du formulaire
        private void FormAfficherReleveDeNotes_Load(object sender, EventArgs e)
        {
            RemplirComboBox(); // Remplit la ComboBox des étudiants
        }

        // Remplit la ComboBox des étudiants avec les données chargées depuis le fichier
        private void RemplirComboBox()
        {
            List<Etudiant> etudiants = ChargerEtudiants(); // Charge la liste des étudiants
            cbEtudiant.Items.Clear(); // Efface les éléments précédents de la ComboBox
            foreach (var etudiant in etudiants)
            {
                // Ajoute chaque étudiant à la ComboBox avec un format spécifique
                cbEtudiant.Items.Add(etudiant.NumeroEtudiant + "_" + etudiant.Nom + "_" + etudiant.Prenom);
            }
        }

        // Charge la liste des étudiants depuis le fichier texte
        private List<Etudiant> ChargerEtudiants()
        {
            string fileName = "etudiants.txt"; // Nom du fichier contenant les informations des étudiants
            List<Etudiant> etudiants = new List<Etudiant>(); // Liste pour stocker les étudiants

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Parse chaque ligne pour créer un objet Etudiant
                        var parts = line.Split(';');
                        int numeroEtudiant = int.Parse(parts[0]);
                        string nom = parts[1];
                        string prenom = parts[2];
                        etudiants.Add(new Etudiant(numeroEtudiant, nom, prenom));
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas de problème de lecture du fichier
                MessageBox.Show($"Erreur lors du chargement des étudiants : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return etudiants;
        }

        // Génère un fichier HTML pour le relevé de notes à partir d'un fichier texte
        public static string GenererReleveHtml(string cheminFichierTexte)
        {
            string[] lignes = File.ReadAllLines(cheminFichierTexte); // Lit toutes les lignes du fichier texte

            if (lignes.Length == 0)
                throw new ArgumentException("Le fichier texte est vide."); // Vérifie si le fichier est vide

            // Parse les informations de l'étudiant depuis la première ligne
            string[] etudiantInfos = lignes[0].Split('_');
            if (etudiantInfos.Length != 3)
                throw new FormatException("Format du nom de l'étudiant invalide.");
            string numeroEtudiant = etudiantInfos[0];
            string prenom = etudiantInfos[1];
            string nom = etudiantInfos[2];

            // Parse les notes de l'étudiant
            var notes = new StringBuilder(); // Utilise StringBuilder pour construire le tableau HTML des notes
            double sommeNotes = 0;
            int nombreCours = 0;

            for (int i = 2; i < lignes.Length; i++)
            {
                string ligne = lignes[i];
                // Sépare les parties de la ligne pour extraire le nom du cours et la note
                string[] parties = ligne.Split(new[] { "Cours : ", ", Note : " }, StringSplitOptions.RemoveEmptyEntries);
                if (parties.Length != 2)
                    throw new FormatException("Format de la ligne de note invalide.");

                string nomCours = parties[0];
                if (double.TryParse(parties[1], NumberStyles.Number, CultureInfo.InvariantCulture, out double note))
                {
                    // Ajoute la note au total et au tableau HTML
                    sommeNotes += note;
                    nombreCours++;
                    notes.AppendLine($"<tr><td>{nomCours}</td><td>{note}</td></tr>");
                }
                else
                {
                    throw new FormatException("Format de la note invalide.");
                }
            }

            // Calcule la moyenne des notes
            double moyenne = nombreCours > 0 ? (sommeNotes / nombreCours) * 20 / 20 : 0;

            // Génère le contenu HTML pour le relevé de notes
            var html = new StringBuilder();
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<title>Relevé de Notes</title>");
            html.AppendLine("<style>");
            html.AppendLine("body { font-family: Arial, sans-serif; margin: 20px; padding: 0; }");
            html.AppendLine("h1 { font-size: 1.5em; margin-bottom: 20px; }");
            html.AppendLine("table { width: 100%; border-collapse: collapse; }");
            html.AppendLine("th, td { padding: 8px; text-align: left; border: 1px solid #ddd; }");
            html.AppendLine("th { background-color: #f4f4f4; }");
            html.AppendLine("@media (max-width: 600px) {");
            html.AppendLine("  table, thead, tbody, th, td, tr { display: block; }");
            html.AppendLine("  th { text-align: right; }");
            html.AppendLine("  td { text-align: right; padding-left: 50%; position: relative; }");
            html.AppendLine("  td::before { content: attr(data-label); position: absolute; left: 0; width: 45%; padding-left: 10px; white-space: nowrap; }");
            html.AppendLine("}");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>Relevé de Notes pour l'Étudiant : {prenom} {nom}</h1>");
            html.AppendLine("<table>");
            html.AppendLine("<thead><tr><th>Cours</th><th>Note</th></tr></thead>");
            html.AppendLine("<tbody>");
            html.Append(notes.ToString()); // Ajoute les lignes de notes au tableau HTML
            html.AppendLine("</tbody>");
            html.AppendLine("</table>");
            html.AppendLine($"<h2>Moyenne : {moyenne:F2} / 20</h2>");
            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }

        // Méthode appelée lorsque l'utilisateur clique sur le bouton pour afficher le relevé de notes
        private void btnAfficherReleve_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupère le nom de l'étudiant sélectionné dans la ComboBox
                string etudiant = cbEtudiant.SelectedItem.ToString();
                string EtudiantChemin = $"{etudiant}.txt"; // Crée le chemin du fichier texte pour l'étudiant
                Console.WriteLine(EtudiantChemin); // Affiche le chemin dans la console (pour débogage)

                // Génère le contenu HTML pour le relevé de notes
                string GenReleveHtml = GenererReleveHtml(EtudiantChemin);

                // Affiche le contenu HTML dans le contrôle WebBrowser
                webBrowserReleve.DocumentText = "0"; // Initialise le DocumentText
                webBrowserReleve.Document.OpenNew(false); // Ouvre un nouveau document
                webBrowserReleve.Document.Write(GenReleveHtml); // Écrit le contenu HTML dans le contrôle
                webBrowserReleve.Refresh(); // Rafraîchit le contrôle pour afficher le contenu
            }
            catch (FileNotFoundException ex)
            {
                // Affiche un message d'erreur si le fichier n'est pas trouvé
                MessageBox.Show($"Le fichier spécifié n'a pas été trouvé : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                // Affiche un message d'erreur si le format des données est invalide
                MessageBox.Show($"Le format des données est invalide : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur pour toute autre exception
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
