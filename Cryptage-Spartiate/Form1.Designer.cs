namespace Cryptage_Spartiate
{
    partial class frmSpartiates
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.lblMessageClair = new System.Windows.Forms.Label();
            this.lblMessageChiffre = new System.Windows.Forms.Label();
            this.txtMessageClair = new System.Windows.Forms.TextBox();
            this.txtMessageChiffre = new System.Windows.Forms.TextBox();
            this.btnChiffrer = new System.Windows.Forms.Button();
            this.btnDéchiffrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessageClair
            // 
            this.lblMessageClair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessageClair.AutoSize = true;
            this.lblMessageClair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageClair.Location = new System.Drawing.Point(39, 47);
            this.lblMessageClair.Name = "lblMessageClair";
            this.lblMessageClair.Size = new System.Drawing.Size(176, 25);
            this.lblMessageClair.TabIndex = 0;
            this.lblMessageClair.Text = "Message en clair";
            // 
            // lblMessageChiffre
            // 
            this.lblMessageChiffre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessageChiffre.AutoSize = true;
            this.lblMessageChiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageChiffre.Location = new System.Drawing.Point(39, 360);
            this.lblMessageChiffre.Name = "lblMessageChiffre";
            this.lblMessageChiffre.Size = new System.Drawing.Size(165, 25);
            this.lblMessageChiffre.TabIndex = 1;
            this.lblMessageChiffre.Text = "Message chiffré";
            // 
            // txtMessageClair
            // 
            this.txtMessageClair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessageClair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageClair.Location = new System.Drawing.Point(287, 47);
            this.txtMessageClair.Multiline = true;
            this.txtMessageClair.Name = "txtMessageClair";
            this.txtMessageClair.Size = new System.Drawing.Size(313, 147);
            this.txtMessageClair.TabIndex = 2;
            // 
            // txtMessageChiffre
            // 
            this.txtMessageChiffre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessageChiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageChiffre.Location = new System.Drawing.Point(287, 360);
            this.txtMessageChiffre.Multiline = true;
            this.txtMessageChiffre.Name = "txtMessageChiffre";
            this.txtMessageChiffre.Size = new System.Drawing.Size(313, 147);
            this.txtMessageChiffre.TabIndex = 3;
            // 
            // btnChiffrer
            // 
            this.btnChiffrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChiffrer.Location = new System.Drawing.Point(287, 250);
            this.btnChiffrer.Name = "btnChiffrer";
            this.btnChiffrer.Size = new System.Drawing.Size(115, 35);
            this.btnChiffrer.TabIndex = 4;
            this.btnChiffrer.Text = "Chiffrer";
            this.btnChiffrer.UseVisualStyleBackColor = true;
            this.btnChiffrer.Click += new System.EventHandler(this.btnChiffrer_Click);
            // 
            // btnDéchiffrer
            // 
            this.btnDéchiffrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDéchiffrer.Location = new System.Drawing.Point(485, 250);
            this.btnDéchiffrer.Name = "btnDéchiffrer";
            this.btnDéchiffrer.Size = new System.Drawing.Size(115, 35);
            this.btnDéchiffrer.TabIndex = 5;
            this.btnDéchiffrer.Text = "Déchiffrer";
            this.btnDéchiffrer.UseVisualStyleBackColor = true;
            // 
            // frmSpartiates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 535);
            this.Controls.Add(this.btnDéchiffrer);
            this.Controls.Add(this.btnChiffrer);
            this.Controls.Add(this.txtMessageChiffre);
            this.Controls.Add(this.txtMessageClair);
            this.Controls.Add(this.lblMessageChiffre);
            this.Controls.Add(this.lblMessageClair);
            this.Name = "frmSpartiates";
            this.Text = "Spartiates";
            this.Load += new System.EventHandler(this.frmSpartiates_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageClair;
        private System.Windows.Forms.Label lblMessageChiffre;
        private System.Windows.Forms.TextBox txtMessageClair;
        private System.Windows.Forms.TextBox txtMessageChiffre;
        private System.Windows.Forms.Button btnChiffrer;
        private System.Windows.Forms.Button btnDéchiffrer;
    }
}

