using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProjetAssuranceQualite
{
    public partial class FormEnregistrementCours : Form
    {
        public FormEnregistrementCours()
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
                int numeroCours = int.Parse(txtNumeroCours.Text);
                string code = txtCode.Text;
                string titre = txtTitre.Text;

                // Crée un nouvel objet Cours avec les valeurs récupérées
                Cours nouveauCours = new Cours(numeroCours, code, titre);

                // Appel de la méthode pour sauvegarder le cours dans le fichier
                AjouterCours(nouveauCours);

                // Message de confirmation de l'enregistrement
                MessageBox.Show("Cours enregistré avec succès !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Vider les champs après l'enregistrement
                txtNumeroCours.Clear();
                txtCode.Clear();
                txtTitre.Clear();
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Méthode pour sauvegarder le cours dans un fichier texte.
        /// </summary>
        /// <param name="cours">L'objet Cours à sauvegarder.</param>
        private void AjouterCours(Cours cours)
        {
            string fileName = "cours.txt";

            try
            {
                // Ouvre le fichier en mode ajout
                using (System.IO.StreamWriter writer = System.IO.File.AppendText(fileName))
                {
                    // Écrit les informations du cours à la fin du fichier
                    writer.WriteLine($"{cours.NumeroCours};{cours.Code};{cours.Titre}");
                }
            }
            catch (Exception ex)
            {
                // Afficher un message en cas d'erreur lors de l'ajout du cours
                MessageBox.Show($"Erreur lors de l'ajout du cours : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Événement déclenché lors de la saisie dans la TextBox "NumeroCours".
        /// Permet uniquement la saisie de chiffres.
        /// </summary>
        private void txtNumeroCours_KeyPress(object sender, KeyPressEventArgs e)
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
        private void FormEnregistrementCours_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire (pour l'instant vide)
        }
    }
}
