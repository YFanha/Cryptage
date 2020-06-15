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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message en clair";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 758);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message chiffré";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 61);
            this.label3.TabIndex = 2;
            this.label3.Text = "Décalage";
            // 
            // txtMessageClair
            // 
            this.txtMessageClair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessageClair.Location = new System.Drawing.Point(813, 114);
            this.txtMessageClair.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMessageClair.Multiline = true;
            this.txtMessageClair.Name = "txtMessageClair";
            this.txtMessageClair.Size = new System.Drawing.Size(961, 226);
            this.txtMessageClair.TabIndex = 3;
            // 
            // txtMessageChiffrer
            // 
            this.txtMessageChiffrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessageChiffrer.Location = new System.Drawing.Point(813, 758);
            this.txtMessageChiffrer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtMessageChiffrer.Multiline = true;
            this.txtMessageChiffrer.Name = "txtMessageChiffrer";
            this.txtMessageChiffrer.Size = new System.Drawing.Size(961, 226);
            this.txtMessageChiffrer.TabIndex = 4;
            this.txtMessageChiffrer.TextChanged += new System.EventHandler(this.txtMessageChiffrer_TextChanged);
            // 
            // txtDecalage
            // 
            this.txtDecalage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDecalage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecalage.Location = new System.Drawing.Point(813, 477);
            this.txtDecalage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtDecalage.Name = "txtDecalage";
            this.txtDecalage.Size = new System.Drawing.Size(252, 67);
            this.txtDecalage.TabIndex = 5;
            this.txtDecalage.TextChanged += new System.EventHandler(this.txtDecalage_TextChanged);
            // 
            // btnChiffrer
            // 
            this.btnChiffrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChiffrer.Location = new System.Drawing.Point(1253, 477);
            this.btnChiffrer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnChiffrer.Name = "btnChiffrer";
            this.btnChiffrer.Size = new System.Drawing.Size(200, 74);
            this.btnChiffrer.TabIndex = 6;
            this.btnChiffrer.Text = "Chiffrer";
            this.btnChiffrer.UseVisualStyleBackColor = true;
            this.btnChiffrer.Click += new System.EventHandler(this.btnChiffrer_Click);
            // 
            // btnDechiffrer
            // 
            this.btnDechiffrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDechiffrer.Location = new System.Drawing.Point(1581, 477);
            this.btnDechiffrer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDechiffrer.Name = "btnDechiffrer";
            this.btnDechiffrer.Size = new System.Drawing.Size(200, 74);
            this.btnDechiffrer.TabIndex = 7;
            this.btnDechiffrer.Text = "Déchiffrer";
            this.btnDechiffrer.UseVisualStyleBackColor = true;
            this.btnDechiffrer.Click += new System.EventHandler(this.btnDechiffrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.btnDechiffrer);
            this.Controls.Add(this.btnChiffrer);
            this.Controls.Add(this.txtDecalage);
            this.Controls.Add(this.txtMessageChiffrer);
            this.Controls.Add(this.txtMessageClair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

