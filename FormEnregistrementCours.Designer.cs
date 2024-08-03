namespace ProjetAssuranceQualite
{
    partial class FormEnregistrementCours
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
            this.lblNumeroCours = new System.Windows.Forms.Label();
            this.txtNumeroCours = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroCours
            // 
            this.lblNumeroCours.AutoSize = true;
            this.lblNumeroCours.Location = new System.Drawing.Point(22, 24);
            this.lblNumeroCours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroCours.Name = "lblNumeroCours";
            this.lblNumeroCours.Size = new System.Drawing.Size(88, 13);
            this.lblNumeroCours.TabIndex = 0;
            this.lblNumeroCours.Text = "Numéro du cours";
            // 
            // txtNumeroCours
            // 
            this.txtNumeroCours.Location = new System.Drawing.Point(120, 24);
            this.txtNumeroCours.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroCours.Name = "txtNumeroCours";
            this.txtNumeroCours.Size = new System.Drawing.Size(151, 20);
            this.txtNumeroCours.TabIndex = 1;
            this.txtNumeroCours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCours_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 57);
            this.lblCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(120, 57);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(151, 20);
            this.txtCode.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(22, 89);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(28, 13);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(120, 89);
            this.txtTitre.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(151, 20);
            this.txtTitre.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(25, 122);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(245, 24);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FormEnregistrementCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 155);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtNumeroCours);
            this.Controls.Add(this.lblNumeroCours);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEnregistrementCours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrement des Cours";
            this.Load += new System.EventHandler(this.FormEnregistrementCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCours;
        private System.Windows.Forms.TextBox txtNumeroCours;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}