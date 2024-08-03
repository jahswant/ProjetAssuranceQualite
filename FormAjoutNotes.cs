using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetAssuranceQualite
{
    public partial class FormAjoutNotes : Form
    {
        public FormAjoutNotes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur le bouton "Ajouter Note".
        /// Vérifie les champs et ajoute une note au DataGridView.
        /// </summary>
        private void btnAjouterNote_Click(object sender, EventArgs e)
        {
            // Vérifiez que l'étudiant, le cours et la note sont sélectionnés/entrez
            if (cbEtudiant.SelectedItem == null || cbCours.SelectedItem == null || string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérez les valeurs des contrôles
            string etudiant = cbEtudiant.SelectedItem.ToString();
            string cours = cbCours.SelectedItem.ToString();
            string note = txtNote.Text;

            // Ajoutez une nouvelle ligne au DataGridView
            dataGridViewNotes.Rows.Add(cours, note);

            // Effacez le champ de note après l'ajout
            txtNote.Clear();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur le bouton "Sauvegarder".
        /// Sauvegarde les notes dans un fichier texte.
        /// </summary>
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            // Vérifiez que l'étudiant est sélectionné
            if (cbEtudiant.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérez le numéro de l'étudiant sélectionné (ici nous utilisons le texte sélectionné comme identifiant)
            string etudiant = cbEtudiant.SelectedItem.ToString();

            // Créez le nom de fichier avec le format Bulletin_NumeroEtudiant.txt
            string fileName = $"{etudiant}.txt";

            // Ouvrez un StreamWriter pour écrire dans le fichier
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
            {
                // Écrivez le nom de l'étudiant
                writer.WriteLine($"Étudiant : {etudiant}");

                // Écrivez les notes de l'étudiant
                writer.WriteLine("Notes :");
                foreach (DataGridViewRow row in dataGridViewNotes.Rows)
                {
                    // Ignorez les lignes vides
                    if (row.IsNewRow) continue;

                    string cours = row.Cells["NomCours"].Value.ToString();
                    string note = row.Cells["NoteValeur"].Value.ToString();
                    writer.WriteLine($"Cours : {cours}, Note : {note}");
                }
            }

            MessageBox.Show("Les données ont été sauvegardées avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Événement déclenché lorsque le formulaire est chargé.
        /// Remplit les ComboBox avec les données des étudiants et des cours.
        /// </summary>
        private void FormAjoutNotes_Load(object sender, EventArgs e)
        {
            RemplirComboBox();
        }

        /// <summary>
        /// Remplit les ComboBox des étudiants et des cours avec les données chargées depuis les fichiers.
        /// </summary>
        private void RemplirComboBox()
        {
            List<Etudiant> etudiants = ChargerEtudiants();
            List<Cours> cours = ChargerCours();

            // Remplir la ComboBox des étudiants
            cbEtudiant.Items.Clear();
            foreach (var etudiant in etudiants)
            {
                cbEtudiant.Items.Add(etudiant.NumeroEtudiant + "_" + etudiant.Nom + "_" + etudiant.Prenom);
            }

            // Remplir la ComboBox des cours
            cbCours.Items.Clear();
            foreach (var coursItem in cours)
            {
                cbCours.Items.Add(coursItem.NumeroCours + "_" + coursItem.Titre);
            }
        }

        /// <summary>
        /// Charge les étudiants depuis le fichier "etudiants.txt".
        /// </summary>
        /// <returns>Une liste d'objets Etudiant chargés depuis le fichier.</returns>
        private List<Etudiant> ChargerEtudiants()
        {
            string fileName = "etudiants.txt";
            List<Etudiant> etudiants = new List<Etudiant>();

            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
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
                MessageBox.Show($"Erreur lors du chargement des étudiants : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return etudiants;
        }

        /// <summary>
        /// Charge les cours depuis le fichier "cours.txt".
        /// </summary>
        /// <returns>Une liste d'objets Cours chargés depuis le fichier.</returns>
        private List<Cours> ChargerCours()
        {
            string fileName = "cours.txt";
            List<Cours> cours = new List<Cours>();

            try
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(';');
                        int numeroCours = int.Parse(parts[0]);
                        string code = parts[1];
                        string titre = parts[2];
                        cours.Add(new Cours(numeroCours, code, titre));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des cours : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cours;
        }

        /// <summary>
        /// Événement déclenché lors de la saisie dans la TextBox "Note".
        /// Permet uniquement la saisie de chiffres.
        /// </summary>
        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permet les touches de contrôle comme backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permet uniquement les chiffres
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
