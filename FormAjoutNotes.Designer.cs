namespace ProjetAssuranceQualite
{
    partial class FormAjoutNotes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbEtudiant = new System.Windows.Forms.ComboBox();
            this.cbCours = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnAjouterNote = new System.Windows.Forms.Button();
            this.dataGridViewNotes = new System.Windows.Forms.DataGridView();
            this.NomCours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteValeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEtudiant
            // 
            this.cbEtudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtudiant.FormattingEnabled = true;
            this.cbEtudiant.Location = new System.Drawing.Point(120, 24);
            this.cbEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.cbEtudiant.Name = "cbEtudiant";
            this.cbEtudiant.Size = new System.Drawing.Size(151, 21);
            this.cbEtudiant.TabIndex = 0;
            // 
            // cbCours
            // 
            this.cbCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCours.FormattingEnabled = true;
            this.cbCours.Location = new System.Drawing.Point(120, 57);
            this.cbCours.Margin = new System.Windows.Forms.Padding(2);
            this.cbCours.Name = "cbCours";
            this.cbCours.Size = new System.Drawing.Size(151, 21);
            this.cbCours.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(120, 89);
            this.txtNote.Margin = new System.Windows.Forms.Padding(2);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(151, 20);
            this.txtNote.TabIndex = 2;
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Location = new System.Drawing.Point(22, 24);
            this.lblEtudiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(46, 13);
            this.lblEtudiant.TabIndex = 3;
            this.lblEtudiant.Text = "Étudiant";
            // 
            // lblCours
            // 
            this.lblCours.AutoSize = true;
            this.lblCours.Location = new System.Drawing.Point(22, 57);
            this.lblCours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(34, 13);
            this.lblCours.TabIndex = 4;
            this.lblCours.Text = "Cours";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(22, 89);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note";
            // 
            // btnAjouterNote
            // 
            this.btnAjouterNote.Location = new System.Drawing.Point(25, 125);
            this.btnAjouterNote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouterNote.Name = "btnAjouterNote";
            this.btnAjouterNote.Size = new System.Drawing.Size(246, 24);
            this.btnAjouterNote.TabIndex = 6;
            this.btnAjouterNote.Text = "Ajouter Note";
            this.btnAjouterNote.UseVisualStyleBackColor = true;
            this.btnAjouterNote.Click += new System.EventHandler(this.btnAjouterNote_Click);
            // 
            // dataGridViewNotes
            // 
            this.dataGridViewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCours,
            this.NoteValeur});
            this.dataGridViewNotes.Location = new System.Drawing.Point(25, 154);
            this.dataGridViewNotes.Name = "dataGridViewNotes";
            this.dataGridViewNotes.Size = new System.Drawing.Size(246, 150);
            this.dataGridViewNotes.TabIndex = 7;
            // 
            // NomCours
            // 
            this.NomCours.HeaderText = "Nom du Cours";
            this.NomCours.Name = "NomCours";
            // 
            // NoteValeur
            // 
            this.NoteValeur.HeaderText = "Note";
            this.NoteValeur.Name = "NoteValeur";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(25, 311);
            this.btnSauvegarder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(246, 24);
            this.btnSauvegarder.TabIndex = 8;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // FormAjoutNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 346);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.dataGridViewNotes);
            this.Controls.Add(this.btnAjouterNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblCours);
            this.Controls.Add(this.lblEtudiant);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cbCours);
            this.Controls.Add(this.cbEtudiant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAjoutNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de Notes";
            this.Load += new System.EventHandler(this.FormAjoutNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEtudiant;
        private System.Windows.Forms.ComboBox cbCours;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnAjouterNote;
        private System.Windows.Forms.DataGridView dataGridViewNotes;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCours;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteValeur;
    }
}
