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
    public partial class FormMenuPrincipale : Form
    {
        public FormMenuPrincipale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur l'élément de menu "note".
        /// Ouvre le formulaire d'ajout de notes en tant que formulaire enfant.
        /// </summary>
        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire d'ajout de notes
            FormAjoutNotes formAjoutNotes = new FormAjoutNotes();

            // Définit ce formulaire comme enfant du formulaire principal
            formAjoutNotes.MdiParent = this;

            // Centre le formulaire enfant dans le formulaire principal
            CenterChildForm(formAjoutNotes);

            // Affiche le formulaire d'ajout de notes
            formAjoutNotes.Show();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur l'élément de menu "quitter".
        /// Ferme l'application.
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur l'élément de menu "cours".
        /// Ouvre le formulaire d'enregistrement des cours en tant que formulaire enfant.
        /// </summary>
        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire d'enregistrement des cours
            FormEnregistrementCours formEnregistrementCours = new FormEnregistrementCours();

            // Définit ce formulaire comme enfant du formulaire principal
            formEnregistrementCours.MdiParent = this;

            // Centre le formulaire enfant dans le formulaire principal
            CenterChildForm(formEnregistrementCours);

            // Affiche le formulaire d'enregistrement des cours
            formEnregistrementCours.Show();
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur l'élément de menu "étudiants".
        /// Ouvre le formulaire d'enregistrement des étudiants en tant que formulaire enfant.
        /// </summary>
        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire d'enregistrement des étudiants
            FormEnregistrementEtudiant formEnregistrementEtudiant = new FormEnregistrementEtudiant();

            // Définit ce formulaire comme enfant du formulaire principal
            formEnregistrementEtudiant.MdiParent = this;

            // Centre le formulaire enfant dans le formulaire principal
            CenterChildForm(formEnregistrementEtudiant);

            // Affiche le formulaire d'enregistrement des étudiants
            formEnregistrementEtudiant.Show();
        }

        /// <summary>
        /// Centre un formulaire enfant dans le formulaire principal.
        /// </summary>
        /// <param name="childForm">Le formulaire enfant à centrer.</param>
        private void CenterChildForm(Form childForm)
        {
            // Calcule la position centrale pour le formulaire enfant
            int x = (this.ClientSize.Width - childForm.Width) / 2;
            int y = (this.ClientSize.Height - childForm.Height) / 2;

            // Définit la position du formulaire enfant
            childForm.Location = new System.Drawing.Point(x, y);
        }

        /// <summary>
        /// Événement déclenché lorsque le formulaire principal est chargé.
        /// </summary>
        private void FormMenuPrincipale_Load(object sender, EventArgs e)
        {
            // Code à exécuter lors du chargement du formulaire (pour l'instant vide)
        }

        /// <summary>
        /// Événement déclenché lorsque l'utilisateur clique sur l'élément de menu "afficher relevé".
        /// Ouvre le formulaire d'affichage du relevé de notes en tant que formulaire enfant.
        /// </summary>
        private void afficherRélévéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crée une instance du formulaire d'affichage du relevé de notes
            FormAfficherReleveDeNotes formAfficherReleveDeNotes = new FormAfficherReleveDeNotes();

            // Définit ce formulaire comme enfant du formulaire principal
            formAfficherReleveDeNotes.MdiParent = this;

            // Centre le formulaire enfant dans le formulaire principal
            CenterChildForm(formAfficherReleveDeNotes);

            // Affiche le formulaire d'affichage du relevé de notes
            formAfficherReleveDeNotes.Show();
        }
    }
}
