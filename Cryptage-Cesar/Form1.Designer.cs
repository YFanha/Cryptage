namespace Cryptage_Cesar
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageClair = new System.Windows.Forms.TextBox();
            this.txtMessageChiffrer = new System.Windows.Forms.TextBox();
            this.txtDecalage = new System.Windows.Forms.TextBox();
            this.btnChiffrer = new System.Windows.Forms.Button();
            this.btnDechiffrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message en clair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message chiffré";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Décalage";
            // 
            // txtMessageClair
            // 
            this.txtMessageClair.Location = new System.Drawing.Point(305, 48);
            this.txtMessageClair.Multiline = true;
            this.txtMessageClair.Name = "txtMessageClair";
            this.txtMessageClair.Size = new System.Drawing.Size(363, 97);
            this.txtMessageClair.TabIndex = 3;
            // 
            // txtMessageChiffrer
            // 
            this.txtMessageChiffrer.Location = new System.Drawing.Point(305, 318);
            this.txtMessageChiffrer.Multiline = true;
            this.txtMessageChiffrer.Name = "txtMessageChiffrer";
            this.txtMessageChiffrer.Size = new System.Drawing.Size(363, 97);
            this.txtMessageChiffrer.TabIndex = 4;
            // 
            // txtDecalage
            // 
            this.txtDecalage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecalage.Location = new System.Drawing.Point(305, 200);
            this.txtDecalage.Name = "txtDecalage";
            this.txtDecalage.Size = new System.Drawing.Size(97, 31);
            this.txtDecalage.TabIndex = 5;
            this.txtDecalage.TextChanged += new System.EventHandler(this.txtDecalage_TextChanged);
            // 
            // btnChiffrer
            // 
            this.btnChiffrer.Location = new System.Drawing.Point(470, 200);
            this.btnChiffrer.Name = "btnChiffrer";
            this.btnChiffrer.Size = new System.Drawing.Size(75, 31);
            this.btnChiffrer.TabIndex = 6;
            this.btnChiffrer.Text = "Chiffrer";
            this.btnChiffrer.UseVisualStyleBackColor = true;
            this.btnChiffrer.Click += new System.EventHandler(this.btnChiffrer_Click);
            // 
            // btnDechiffrer
            // 
            this.btnDechiffrer.Location = new System.Drawing.Point(593, 200);
            this.btnDechiffrer.Name = "btnDechiffrer";
            this.btnDechiffrer.Size = new System.Drawing.Size(75, 31);
            this.btnDechiffrer.TabIndex = 7;
            this.btnDechiffrer.Text = "Déchiffrer";
            this.btnDechiffrer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDechiffrer);
            this.Controls.Add(this.btnChiffrer);
            this.Controls.Add(this.txtDecalage);
            this.Controls.Add(this.txtMessageChiffrer);
            this.Controls.Add(this.txtMessageClair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Alphabet de César";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessageClair;
        private System.Windows.Forms.TextBox txtMessageChiffrer;
        private System.Windows.Forms.TextBox txtDecalage;
        private System.Windows.Forms.Button btnChiffrer;
        private System.Windows.Forms.Button btnDechiffrer;
    }
}

