namespace CifrarioDiCesare1
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
            this.btn_Cifra = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.lbl_Risultato = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n8 = new System.Windows.Forms.Label();
            this.txt_ParolaChiara = new System.Windows.Forms.TextBox();
            this.txt_Chiave = new System.Windows.Forms.TextBox();
            this.txt_Chiave1 = new System.Windows.Forms.TextBox();
            this.txt_ParolaCifrata = new System.Windows.Forms.TextBox();
            this.lbl_Risultato1 = new System.Windows.Forms.Label();
            this.lbl_n10 = new System.Windows.Forms.Label();
            this.btn_Decifra = new System.Windows.Forms.Button();
            this.lbl_n11 = new System.Windows.Forms.Label();
            this.lbl_n12 = new System.Windows.Forms.Label();
            this.lbl_n13 = new System.Windows.Forms.Label();
            this.lbl_Parola2 = new System.Windows.Forms.Label();
            this.lbl_n16 = new System.Windows.Forms.Label();
            this.lbl_n18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Parola3 = new System.Windows.Forms.Label();
            this.lbl_n17 = new System.Windows.Forms.Label();
            this.lbl_n19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cifra
            // 
            this.btn_Cifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cifra.Location = new System.Drawing.Point(19, 361);
            this.btn_Cifra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cifra.Name = "btn_Cifra";
            this.btn_Cifra.Size = new System.Drawing.Size(134, 41);
            this.btn_Cifra.TabIndex = 0;
            this.btn_Cifra.Text = "INVIO";
            this.btn_Cifra.UseVisualStyleBackColor = true;
            this.btn_Cifra.Click += new System.EventHandler(this.btn_Cifra_Click_1);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(481, 2);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(360, 43);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Cifrario Di Cesare";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(44, 84);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(87, 29);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "Cifrare";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(401, 84);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(113, 29);
            this.lbl_n3.TabIndex = 3;
            this.lbl_n3.Text = "Decifrare";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(14, 167);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(114, 18);
            this.lbl_n4.TabIndex = 4;
            this.lbl_n4.Text = "Inserire Parola";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n5.Location = new System.Drawing.Point(14, 228);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(117, 18);
            this.lbl_n5.TabIndex = 5;
            this.lbl_n5.Text = "Inserire Chiave";
            // 
            // lbl_Risultato
            // 
            this.lbl_Risultato.AutoSize = true;
            this.lbl_Risultato.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Risultato.Location = new System.Drawing.Point(15, 296);
            this.lbl_Risultato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Risultato.Name = "lbl_Risultato";
            this.lbl_Risultato.Size = new System.Drawing.Size(84, 18);
            this.lbl_Risultato.TabIndex = 6;
            this.lbl_Risultato.Text = "Risultato : ";
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.Location = new System.Drawing.Point(329, 167);
            this.lbl_n7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(114, 18);
            this.lbl_n7.TabIndex = 7;
            this.lbl_n7.Text = "Inserire Parola";
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n8.Location = new System.Drawing.Point(329, 226);
            this.lbl_n8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(117, 18);
            this.lbl_n8.TabIndex = 8;
            this.lbl_n8.Text = "Inserire Chiave";
            // 
            // txt_ParolaChiara
            // 
            this.txt_ParolaChiara.Location = new System.Drawing.Point(154, 169);
            this.txt_ParolaChiara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParolaChiara.Name = "txt_ParolaChiara";
            this.txt_ParolaChiara.Size = new System.Drawing.Size(116, 20);
            this.txt_ParolaChiara.TabIndex = 9;
            // 
            // txt_Chiave
            // 
            this.txt_Chiave.Location = new System.Drawing.Point(154, 228);
            this.txt_Chiave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Chiave.Name = "txt_Chiave";
            this.txt_Chiave.Size = new System.Drawing.Size(116, 20);
            this.txt_Chiave.TabIndex = 10;
            // 
            // txt_Chiave1
            // 
            this.txt_Chiave1.Location = new System.Drawing.Point(465, 226);
            this.txt_Chiave1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Chiave1.Name = "txt_Chiave1";
            this.txt_Chiave1.Size = new System.Drawing.Size(116, 20);
            this.txt_Chiave1.TabIndex = 11;
            // 
            // txt_ParolaCifrata
            // 
            this.txt_ParolaCifrata.Location = new System.Drawing.Point(465, 169);
            this.txt_ParolaCifrata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParolaCifrata.Name = "txt_ParolaCifrata";
            this.txt_ParolaCifrata.Size = new System.Drawing.Size(116, 20);
            this.txt_ParolaCifrata.TabIndex = 12;
            // 
            // lbl_Risultato1
            // 
            this.lbl_Risultato1.AutoSize = true;
            this.lbl_Risultato1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Risultato1.Location = new System.Drawing.Point(329, 296);
            this.lbl_Risultato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Risultato1.Name = "lbl_Risultato1";
            this.lbl_Risultato1.Size = new System.Drawing.Size(84, 18);
            this.lbl_Risultato1.TabIndex = 13;
            this.lbl_Risultato1.Text = "Risultato : ";
            // 
            // lbl_n10
            // 
            this.lbl_n10.AutoSize = true;
            this.lbl_n10.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n10.Location = new System.Drawing.Point(124, 25);
            this.lbl_n10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n10.Name = "lbl_n10";
            this.lbl_n10.Size = new System.Drawing.Size(236, 34);
            this.lbl_n10.TabIndex = 14;
            this.lbl_n10.Text = "Chiave Dinamica";
            // 
            // btn_Decifra
            // 
            this.btn_Decifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decifra.Location = new System.Drawing.Point(334, 361);
            this.btn_Decifra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Decifra.Name = "btn_Decifra";
            this.btn_Decifra.Size = new System.Drawing.Size(146, 41);
            this.btn_Decifra.TabIndex = 15;
            this.btn_Decifra.Text = "INVIO";
            this.btn_Decifra.UseVisualStyleBackColor = true;
            this.btn_Decifra.Click += new System.EventHandler(this.btn_Decifra_Click_1);
            // 
            // lbl_n11
            // 
            this.lbl_n11.AutoSize = true;
            this.lbl_n11.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n11.Location = new System.Drawing.Point(874, 11);
            this.lbl_n11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n11.Name = "lbl_n11";
            this.lbl_n11.Size = new System.Drawing.Size(204, 34);
            this.lbl_n11.TabIndex = 16;
            this.lbl_n11.Text = "Chiave Stringa";
            // 
            // lbl_n12
            // 
            this.lbl_n12.AutoSize = true;
            this.lbl_n12.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n12.Location = new System.Drawing.Point(754, 84);
            this.lbl_n12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n12.Name = "lbl_n12";
            this.lbl_n12.Size = new System.Drawing.Size(87, 29);
            this.lbl_n12.TabIndex = 17;
            this.lbl_n12.Text = "Cifrare";
            // 
            // lbl_n13
            // 
            this.lbl_n13.AutoSize = true;
            this.lbl_n13.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n13.Location = new System.Drawing.Point(929, 84);
            this.lbl_n13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n13.Name = "lbl_n13";
            this.lbl_n13.Size = new System.Drawing.Size(113, 29);
            this.lbl_n13.TabIndex = 18;
            this.lbl_n13.Text = "Decifrare";
            // 
            // lbl_Parola2
            // 
            this.lbl_Parola2.AutoSize = true;
            this.lbl_Parola2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parola2.Location = new System.Drawing.Point(774, 167);
            this.lbl_Parola2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Parola2.Name = "lbl_Parola2";
            this.lbl_Parola2.Size = new System.Drawing.Size(114, 18);
            this.lbl_Parola2.TabIndex = 19;
            this.lbl_Parola2.Text = "Inserire Parola";
            // 
            // lbl_n16
            // 
            this.lbl_n16.AutoSize = true;
            this.lbl_n16.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n16.Location = new System.Drawing.Point(756, 210);
            this.lbl_n16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n16.Name = "lbl_n16";
            this.lbl_n16.Size = new System.Drawing.Size(50, 18);
            this.lbl_n16.TabIndex = 20;
            this.lbl_n16.Text = "label5";
            // 
            // lbl_n18
            // 
            this.lbl_n18.AutoSize = true;
            this.lbl_n18.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n18.Location = new System.Drawing.Point(756, 269);
            this.lbl_n18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n18.Name = "lbl_n18";
            this.lbl_n18.Size = new System.Drawing.Size(50, 18);
            this.lbl_n18.TabIndex = 21;
            this.lbl_n18.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Parola3
            // 
            this.lbl_Parola3.AutoSize = true;
            this.lbl_Parola3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parola3.Location = new System.Drawing.Point(915, 167);
            this.lbl_Parola3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Parola3.Name = "lbl_Parola3";
            this.lbl_Parola3.Size = new System.Drawing.Size(117, 18);
            this.lbl_Parola3.TabIndex = 23;
            this.lbl_Parola3.Text = "Inserisci Parola";
            // 
            // lbl_n17
            // 
            this.lbl_n17.AutoSize = true;
            this.lbl_n17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n17.Location = new System.Drawing.Point(903, 210);
            this.lbl_n17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n17.Name = "lbl_n17";
            this.lbl_n17.Size = new System.Drawing.Size(50, 18);
            this.lbl_n17.TabIndex = 24;
            this.lbl_n17.Text = "label8";
            // 
            // lbl_n19
            // 
            this.lbl_n19.AutoSize = true;
            this.lbl_n19.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n19.Location = new System.Drawing.Point(915, 269);
            this.lbl_n19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n19.Name = "lbl_n19";
            this.lbl_n19.Size = new System.Drawing.Size(50, 18);
            this.lbl_n19.TabIndex = 25;
            this.lbl_n19.Text = "label9";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_n19);
            this.Controls.Add(this.lbl_n17);
            this.Controls.Add(this.lbl_Parola3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_n18);
            this.Controls.Add(this.lbl_n16);
            this.Controls.Add(this.lbl_Parola2);
            this.Controls.Add(this.lbl_n13);
            this.Controls.Add(this.lbl_n12);
            this.Controls.Add(this.lbl_n11);
            this.Controls.Add(this.btn_Decifra);
            this.Controls.Add(this.lbl_n10);
            this.Controls.Add(this.lbl_Risultato1);
            this.Controls.Add(this.txt_ParolaCifrata);
            this.Controls.Add(this.txt_Chiave1);
            this.Controls.Add(this.txt_Chiave);
            this.Controls.Add(this.txt_ParolaChiara);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.lbl_Risultato);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_Cifra);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cifra;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Label lbl_Risultato;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label lbl_n8;
        private System.Windows.Forms.TextBox txt_ParolaChiara;
        private System.Windows.Forms.TextBox txt_Chiave;
        private System.Windows.Forms.TextBox txt_Chiave1;
        private System.Windows.Forms.TextBox txt_ParolaCifrata;
        private System.Windows.Forms.Label lbl_Risultato1;
        private System.Windows.Forms.Label lbl_n10;
        private System.Windows.Forms.Button btn_Decifra;
        private System.Windows.Forms.Label lbl_n11;
        private System.Windows.Forms.Label lbl_n12;
        private System.Windows.Forms.Label lbl_n13;
        private System.Windows.Forms.Label lbl_Parola2;
        private System.Windows.Forms.Label lbl_n16;
        private System.Windows.Forms.Label lbl_n18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Parola3;
        private System.Windows.Forms.Label lbl_n17;
        private System.Windows.Forms.Label lbl_n19;
        private System.Windows.Forms.Button button2;
    }
}

