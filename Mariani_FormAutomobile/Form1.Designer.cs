namespace Mariani_FormAutomobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Accellera = new System.Windows.Forms.Button();
            this.Accendi = new System.Windows.Forms.Button();
            this.Spegni = new System.Windows.Forms.Button();
            this.Decellera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Accellera
            // 
            this.Accellera.Location = new System.Drawing.Point(319, 268);
            this.Accellera.Name = "Accellera";
            this.Accellera.Size = new System.Drawing.Size(75, 23);
            this.Accellera.TabIndex = 0;
            this.Accellera.Text = "Accellera";
            this.Accellera.UseVisualStyleBackColor = true;
            this.Accellera.Click += new System.EventHandler(this.Accellera_Click);
            // 
            // Accendi
            // 
            this.Accendi.Location = new System.Drawing.Point(26, 235);
            this.Accendi.Name = "Accendi";
            this.Accendi.Size = new System.Drawing.Size(75, 23);
            this.Accendi.TabIndex = 1;
            this.Accendi.Text = "Accendi";
            this.Accendi.UseVisualStyleBackColor = true;
            this.Accendi.Click += new System.EventHandler(this.Accendi_Click);
            // 
            // Spegni
            // 
            this.Spegni.Location = new System.Drawing.Point(26, 193);
            this.Spegni.Name = "Spegni";
            this.Spegni.Size = new System.Drawing.Size(75, 23);
            this.Spegni.TabIndex = 2;
            this.Spegni.Text = "Spegni";
            this.Spegni.UseVisualStyleBackColor = true;
            // 
            // Decellera
            // 
            this.Decellera.Location = new System.Drawing.Point(319, 298);
            this.Decellera.Name = "Decellera";
            this.Decellera.Size = new System.Drawing.Size(75, 23);
            this.Decellera.TabIndex = 3;
            this.Decellera.Text = "Decellera";
            this.Decellera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decellera);
            this.Controls.Add(this.Spegni);
            this.Controls.Add(this.Accendi);
            this.Controls.Add(this.Accellera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accellera;
        private System.Windows.Forms.Button Accendi;
        private System.Windows.Forms.Button Spegni;
        private System.Windows.Forms.Button Decellera;
    }
}

