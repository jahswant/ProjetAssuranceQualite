namespace ProjetAssuranceQualite
{
    partial class FormAfficherReleveDeNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfficherReleve = new System.Windows.Forms.Button();
            this.lblEtudiant = new System.Windows.Forms.Label();
            this.cbEtudiant = new System.Windows.Forms.ComboBox();
            this.webBrowserReleve = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnAfficherReleve
            // 
            this.btnAfficherReleve.Location = new System.Drawing.Point(260, 6);
            this.btnAfficherReleve.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfficherReleve.Name = "btnAfficherReleve";
            this.btnAfficherReleve.Size = new System.Drawing.Size(163, 24);
            this.btnAfficherReleve.TabIndex = 9;
            this.btnAfficherReleve.Text = "Afficher";
            this.btnAfficherReleve.UseVisualStyleBackColor = true;
            this.btnAfficherReleve.Click += new System.EventHandler(this.btnAfficherReleve_Click);
            // 
            // lblEtudiant
            // 
            this.lblEtudiant.AutoSize = true;
            this.lblEtudiant.Location = new System.Drawing.Point(7, 11);
            this.lblEtudiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtudiant.Name = "lblEtudiant";
            this.lblEtudiant.Size = new System.Drawing.Size(46, 13);
            this.lblEtudiant.TabIndex = 8;
            this.lblEtudiant.Text = "Étudiant";
            // 
            // cbEtudiant
            // 
            this.cbEtudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtudiant.FormattingEnabled = true;
            this.cbEtudiant.Location = new System.Drawing.Point(73, 8);
            this.cbEtudiant.Margin = new System.Windows.Forms.Padding(2);
            this.cbEtudiant.Name = "cbEtudiant";
            this.cbEtudiant.Size = new System.Drawing.Size(183, 21);
            this.cbEtudiant.TabIndex = 7;
            // 
            // webBrowserReleve
            // 
            this.webBrowserReleve.Location = new System.Drawing.Point(0, 37);
            this.webBrowserReleve.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserReleve.Name = "webBrowserReleve";
            this.webBrowserReleve.Size = new System.Drawing.Size(423, 455);
            this.webBrowserReleve.TabIndex = 1;
            // 
            // FormAfficherReleveDeNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 490);
            this.Controls.Add(this.btnAfficherReleve);
            this.Controls.Add(this.lblEtudiant);
            this.Controls.Add(this.cbEtudiant);
            this.Controls.Add(this.webBrowserReleve);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAfficherReleveDeNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAfficherReleveDeNotes";
            this.Load += new System.EventHandler(this.FormAfficherReleveDeNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAfficherReleve;
        private System.Windows.Forms.Label lblEtudiant;
        private System.Windows.Forms.ComboBox cbEtudiant;
        private System.Windows.Forms.WebBrowser webBrowserReleve;
    }
}