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
    public partial class FormEnregistrementEtudiant : Form
    {
        public FormEnregistrementEtudiant()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur le bouton "Enregistrer".
        /// Récupère les valeurs saisies, les enregistre et affiche un message de confirmation.
        /// </summary>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupération des valeurs saisies dans les TextBox
                int numeroEtudiant = int.Parse(txtNumeroEtudiant.Text);
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;

                // Crée un nouvel objet Etudiant avec les valeurs récupérées
                Etudiant nouvelEtudiant = new Etudiant(numeroEtudiant, nom, prenom);

                // Appel de la méthode pour sauvegarder l'étudiant dans le fichier
                AjouterEtudiant(nouvelEtudiant);

                // Message de confirmation de l'enregistrement
                MessageBox.Show("Étudiant enregistré avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Vider les champs après l'enregistrement
                txtNumeroEtudiant.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Méthode pour sauvegarder l'étudiant dans un fichier texte.
        /// </summary>
        /// <param name="etudiant">L'objet Etudiant à sauvegarder.</param>
        private void AjouterEtudiant(Etudiant etudiant)
        {
            string fileName = "etudiants.txt";

            try
            {
                // Ouvre le fichier en mode ajout
                using (System.IO.StreamWriter writer = System.IO.File.AppendText(fileName))
                {
                    // Écrit les informations de l'étudiant à la fin du fichier
                    writer.WriteLine($"{etudiant.NumeroEtudiant};{etudiant.Nom};{etudiant.Prenom}");
                }
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur lors de l'ajout de l'étudiant
                MessageBox.Show($"Erreur lors de l'ajout de l'étudiant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Événement déclenché lors de la saisie dans la TextBox "NumeroEtudiant".
        /// Permet uniquement la saisie de chiffres.
        /// </summary>
        private void txtNumeroEtudiant_KeyPress(object sender, KeyPressEventArgs e)
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

        /// <summary>
        /// Événement déclenché lorsque le formulaire est chargé.
        /// </summary>
        private void FormEnregistrementEtudiant_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire (pour l'instant vide)
        }
    }
}
