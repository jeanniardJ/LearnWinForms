namespace LearnWinForms
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
            this.btnNoClick = new System.Windows.Forms.Button();
            this.displayMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNoClick
            // 
            this.btnNoClick.Location = new System.Drawing.Point(82, 96);
            this.btnNoClick.Name = "btnNoClick";
            this.btnNoClick.Size = new System.Drawing.Size(75, 23);
            this.btnNoClick.TabIndex = 0;
            this.btnNoClick.Text = "Click pas !!!";
            this.btnNoClick.UseVisualStyleBackColor = true;
            this.btnNoClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayMsg
            // 
            this.displayMsg.AutoSize = true;
            this.displayMsg.Location = new System.Drawing.Point(359, 106);
            this.displayMsg.Name = "displayMsg";
            this.displayMsg.Size = new System.Drawing.Size(35, 13);
            this.displayMsg.TabIndex = 1;
            this.displayMsg.Text = "label1";
            this.displayMsg.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 449);
            this.Controls.Add(this.displayMsg);
            this.Controls.Add(this.btnNoClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoClick;
        private System.Windows.Forms.Label displayMsg;
    }
}

