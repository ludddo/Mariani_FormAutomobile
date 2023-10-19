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
            this.listView1 = new System.Windows.Forms.ListView();
            this.marcia1 = new System.Windows.Forms.Button();
            this.marcia2 = new System.Windows.Forms.Button();
            this.marcia3 = new System.Windows.Forms.Button();
            this.marcia4 = new System.Windows.Forms.Button();
            this.marcia5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manuale = new System.Windows.Forms.Button();
            this.automatica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accellera
            // 
            this.Accellera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Accellera.Location = new System.Drawing.Point(160, 131);
            this.Accellera.Name = "Accellera";
            this.Accellera.Size = new System.Drawing.Size(60, 23);
            this.Accellera.TabIndex = 0;
            this.Accellera.Text = "Accellera";
            this.Accellera.UseVisualStyleBackColor = false;
            this.Accellera.Click += new System.EventHandler(this.Accellera_Click);
            // 
            // Accendi
            // 
            this.Accendi.BackColor = System.Drawing.Color.Cyan;
            this.Accendi.Location = new System.Drawing.Point(34, 46);
            this.Accendi.Name = "Accendi";
            this.Accendi.Size = new System.Drawing.Size(75, 23);
            this.Accendi.TabIndex = 1;
            this.Accendi.Text = "Accendi";
            this.Accendi.UseVisualStyleBackColor = false;
            this.Accendi.Click += new System.EventHandler(this.Accendi_Click);
            // 
            // Spegni
            // 
            this.Spegni.BackColor = System.Drawing.Color.Red;
            this.Spegni.Location = new System.Drawing.Point(34, 75);
            this.Spegni.Name = "Spegni";
            this.Spegni.Size = new System.Drawing.Size(75, 23);
            this.Spegni.TabIndex = 2;
            this.Spegni.Text = "Spegni";
            this.Spegni.UseVisualStyleBackColor = false;
            this.Spegni.Click += new System.EventHandler(this.Spegni_Click);
            // 
            // Decellera
            // 
            this.Decellera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Decellera.Location = new System.Drawing.Point(226, 131);
            this.Decellera.Name = "Decellera";
            this.Decellera.Size = new System.Drawing.Size(64, 23);
            this.Decellera.TabIndex = 3;
            this.Decellera.Text = "Decellera";
            this.Decellera.UseVisualStyleBackColor = false;
            this.Decellera.Click += new System.EventHandler(this.Decellera_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(140, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(173, 107);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // marcia1
            // 
            this.marcia1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.marcia1.Location = new System.Drawing.Point(160, 160);
            this.marcia1.Name = "marcia1";
            this.marcia1.Size = new System.Drawing.Size(25, 23);
            this.marcia1.TabIndex = 5;
            this.marcia1.Text = "1";
            this.marcia1.UseVisualStyleBackColor = false;
            this.marcia1.Click += new System.EventHandler(this.marcia1_Click);
            // 
            // marcia2
            // 
            this.marcia2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.marcia2.Location = new System.Drawing.Point(160, 189);
            this.marcia2.Name = "marcia2";
            this.marcia2.Size = new System.Drawing.Size(25, 23);
            this.marcia2.TabIndex = 6;
            this.marcia2.Text = "2";
            this.marcia2.UseVisualStyleBackColor = false;
            this.marcia2.Click += new System.EventHandler(this.marcia2_Click);
            // 
            // marcia3
            // 
            this.marcia3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.marcia3.Location = new System.Drawing.Point(210, 160);
            this.marcia3.Name = "marcia3";
            this.marcia3.Size = new System.Drawing.Size(25, 23);
            this.marcia3.TabIndex = 7;
            this.marcia3.Text = "3";
            this.marcia3.UseVisualStyleBackColor = false;
            this.marcia3.Click += new System.EventHandler(this.marcia3_Click);
            // 
            // marcia4
            // 
            this.marcia4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.marcia4.Location = new System.Drawing.Point(210, 189);
            this.marcia4.Name = "marcia4";
            this.marcia4.Size = new System.Drawing.Size(25, 23);
            this.marcia4.TabIndex = 8;
            this.marcia4.Text = "4";
            this.marcia4.UseVisualStyleBackColor = false;
            this.marcia4.Click += new System.EventHandler(this.marcia4_Click);
            // 
            // marcia5
            // 
            this.marcia5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.marcia5.Location = new System.Drawing.Point(265, 160);
            this.marcia5.Name = "marcia5";
            this.marcia5.Size = new System.Drawing.Size(25, 23);
            this.marcia5.TabIndex = 9;
            this.marcia5.Text = "5";
            this.marcia5.UseVisualStyleBackColor = false;
            this.marcia5.Click += new System.EventHandler(this.marcia5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.automatica);
            this.groupBox1.Controls.Add(this.manuale);
            this.groupBox1.Location = new System.Drawing.Point(79, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // manuale
            // 
            this.manuale.Location = new System.Drawing.Point(54, 78);
            this.manuale.Name = "manuale";
            this.manuale.Size = new System.Drawing.Size(75, 23);
            this.manuale.TabIndex = 0;
            this.manuale.Text = "Manuale";
            this.manuale.UseVisualStyleBackColor = true;
            // 
            // automatica
            // 
            this.automatica.Location = new System.Drawing.Point(159, 78);
            this.automatica.Name = "automatica";
            this.automatica.Size = new System.Drawing.Size(75, 23);
            this.automatica.TabIndex = 1;
            this.automatica.Text = "Automatica";
            this.automatica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.marcia5);
            this.Controls.Add(this.marcia4);
            this.Controls.Add(this.marcia3);
            this.Controls.Add(this.marcia2);
            this.Controls.Add(this.marcia1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Decellera);
            this.Controls.Add(this.Spegni);
            this.Controls.Add(this.Accendi);
            this.Controls.Add(this.Accellera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accellera;
        private System.Windows.Forms.Button Accendi;
        private System.Windows.Forms.Button Spegni;
        private System.Windows.Forms.Button Decellera;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button marcia1;
        private System.Windows.Forms.Button marcia2;
        private System.Windows.Forms.Button marcia3;
        private System.Windows.Forms.Button marcia4;
        private System.Windows.Forms.Button marcia5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button manuale;
        private System.Windows.Forms.Button automatica;
    }
}

