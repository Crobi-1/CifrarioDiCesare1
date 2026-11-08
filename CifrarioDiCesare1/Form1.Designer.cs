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
            this.lbl_RisultatoCifrato = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n8 = new System.Windows.Forms.Label();
            this.txt_ParolaChiara = new System.Windows.Forms.TextBox();
            this.txt_ChiaveCifrata = new System.Windows.Forms.TextBox();
            this.txt_ChiaveDecifrata = new System.Windows.Forms.TextBox();
            this.txt_ParolaCifrata = new System.Windows.Forms.TextBox();
            this.lbl_RisultatoDecifrato = new System.Windows.Forms.Label();
            this.lbl_n10 = new System.Windows.Forms.Label();
            this.btn_Decifra = new System.Windows.Forms.Button();
            this.lbl_n11 = new System.Windows.Forms.Label();
            this.lbl_n12 = new System.Windows.Forms.Label();
            this.lbl_n13 = new System.Windows.Forms.Label();
            this.lbl_Parola2 = new System.Windows.Forms.Label();
            this.lbl_n16 = new System.Windows.Forms.Label();
            this.lbl_RisultatoCifratoS = new System.Windows.Forms.Label();
            this.btn_CifraStringa = new System.Windows.Forms.Button();
            this.lbl_Parola3 = new System.Windows.Forms.Label();
            this.lbl_n17 = new System.Windows.Forms.Label();
            this.lbl_RisultatoDecifratoS = new System.Windows.Forms.Label();
            this.btn_DecifraStringa = new System.Windows.Forms.Button();
            this.txt_ParolaChiaraS = new System.Windows.Forms.TextBox();
            this.txt_ChiaveCifrataS = new System.Windows.Forms.TextBox();
            this.txt_ParolaCifrataS = new System.Windows.Forms.TextBox();
            this.txt_ChiaveDecifrataS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cifra
            // 
            this.btn_Cifra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_n1.Location = new System.Drawing.Point(386, 9);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(459, 54);
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
            this.lbl_n2.Size = new System.Drawing.Size(107, 35);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = "Cifrare";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(367, 84);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(139, 35);
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
            this.lbl_n4.Size = new System.Drawing.Size(143, 24);
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
            this.lbl_n5.Size = new System.Drawing.Size(147, 24);
            this.lbl_n5.TabIndex = 5;
            this.lbl_n5.Text = "Inserire Chiave";
            // 
            // lbl_RisultatoCifrato
            // 
            this.lbl_RisultatoCifrato.AutoSize = true;
            this.lbl_RisultatoCifrato.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RisultatoCifrato.Location = new System.Drawing.Point(15, 296);
            this.lbl_RisultatoCifrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RisultatoCifrato.Name = "lbl_RisultatoCifrato";
            this.lbl_RisultatoCifrato.Size = new System.Drawing.Size(108, 24);
            this.lbl_RisultatoCifrato.TabIndex = 6;
            this.lbl_RisultatoCifrato.Text = "Risultato : ";
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n7.Location = new System.Drawing.Point(294, 167);
            this.lbl_n7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(143, 24);
            this.lbl_n7.TabIndex = 7;
            this.lbl_n7.Text = "Inserire Parola";
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n8.Location = new System.Drawing.Point(294, 228);
            this.lbl_n8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(147, 24);
            this.lbl_n8.TabIndex = 8;
            this.lbl_n8.Text = "Inserire Chiave";
            // 
            // txt_ParolaChiara
            // 
            this.txt_ParolaChiara.Location = new System.Drawing.Point(169, 168);
            this.txt_ParolaChiara.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParolaChiara.Name = "txt_ParolaChiara";
            this.txt_ParolaChiara.Size = new System.Drawing.Size(116, 23);
            this.txt_ParolaChiara.TabIndex = 9;
            // 
            // txt_ChiaveCifrata
            // 
            this.txt_ChiaveCifrata.Location = new System.Drawing.Point(169, 229);
            this.txt_ChiaveCifrata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ChiaveCifrata.Name = "txt_ChiaveCifrata";
            this.txt_ChiaveCifrata.Size = new System.Drawing.Size(116, 23);
            this.txt_ChiaveCifrata.TabIndex = 10;
            // 
            // txt_ChiaveDecifrata
            // 
            this.txt_ChiaveDecifrata.Location = new System.Drawing.Point(449, 227);
            this.txt_ChiaveDecifrata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ChiaveDecifrata.Name = "txt_ChiaveDecifrata";
            this.txt_ChiaveDecifrata.Size = new System.Drawing.Size(116, 23);
            this.txt_ChiaveDecifrata.TabIndex = 11;
            // 
            // txt_ParolaCifrata
            // 
            this.txt_ParolaCifrata.Location = new System.Drawing.Point(449, 166);
            this.txt_ParolaCifrata.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ParolaCifrata.Name = "txt_ParolaCifrata";
            this.txt_ParolaCifrata.Size = new System.Drawing.Size(116, 23);
            this.txt_ParolaCifrata.TabIndex = 12;
            // 
            // lbl_RisultatoDecifrato
            // 
            this.lbl_RisultatoDecifrato.AutoSize = true;
            this.lbl_RisultatoDecifrato.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RisultatoDecifrato.Location = new System.Drawing.Point(294, 296);
            this.lbl_RisultatoDecifrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RisultatoDecifrato.Name = "lbl_RisultatoDecifrato";
            this.lbl_RisultatoDecifrato.Size = new System.Drawing.Size(108, 24);
            this.lbl_RisultatoDecifrato.TabIndex = 13;
            this.lbl_RisultatoDecifrato.Text = "Risultato : ";
            // 
            // lbl_n10
            // 
            this.lbl_n10.AutoSize = true;
            this.lbl_n10.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n10.Location = new System.Drawing.Point(58, 9);
            this.lbl_n10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n10.Name = "lbl_n10";
            this.lbl_n10.Size = new System.Drawing.Size(300, 43);
            this.lbl_n10.TabIndex = 14;
            this.lbl_n10.Text = "Chiave Dinamica";
            // 
            // btn_Decifra
            // 
            this.btn_Decifra.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Decifra.Location = new System.Drawing.Point(316, 361);
            this.btn_Decifra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Decifra.Name = "btn_Decifra";
            this.btn_Decifra.Size = new System.Drawing.Size(146, 41);
            this.btn_Decifra.TabIndex = 15;
            this.btn_Decifra.Text = "INVIO";
            this.btn_Decifra.UseVisualStyleBackColor = true;
            this.btn_Decifra.Click += new System.EventHandler(this.btn_Decifra_Click);
            // 
            // lbl_n11
            // 
            this.lbl_n11.AutoSize = true;
            this.lbl_n11.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n11.Location = new System.Drawing.Point(874, 11);
            this.lbl_n11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n11.Name = "lbl_n11";
            this.lbl_n11.Size = new System.Drawing.Size(260, 43);
            this.lbl_n11.TabIndex = 16;
            this.lbl_n11.Text = "Chiave Stringa";
            // 
            // lbl_n12
            // 
            this.lbl_n12.AutoSize = true;
            this.lbl_n12.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n12.Location = new System.Drawing.Point(633, 84);
            this.lbl_n12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n12.Name = "lbl_n12";
            this.lbl_n12.Size = new System.Drawing.Size(107, 35);
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
            this.lbl_n13.Size = new System.Drawing.Size(139, 35);
            this.lbl_n13.TabIndex = 18;
            this.lbl_n13.Text = "Decifrare";
            // 
            // lbl_Parola2
            // 
            this.lbl_Parola2.AutoSize = true;
            this.lbl_Parola2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parola2.Location = new System.Drawing.Point(586, 167);
            this.lbl_Parola2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Parola2.Name = "lbl_Parola2";
            this.lbl_Parola2.Size = new System.Drawing.Size(143, 24);
            this.lbl_Parola2.TabIndex = 19;
            this.lbl_Parola2.Text = "Inserire Parola";
            // 
            // lbl_n16
            // 
            this.lbl_n16.AutoSize = true;
            this.lbl_n16.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n16.Location = new System.Drawing.Point(585, 229);
            this.lbl_n16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n16.Name = "lbl_n16";
            this.lbl_n16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_n16.Size = new System.Drawing.Size(147, 24);
            this.lbl_n16.TabIndex = 20;
            this.lbl_n16.Text = "Inserire Chiave";
            // 
            // lbl_RisultatoCifratoS
            // 
            this.lbl_RisultatoCifratoS.AutoSize = true;
            this.lbl_RisultatoCifratoS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RisultatoCifratoS.Location = new System.Drawing.Point(586, 296);
            this.lbl_RisultatoCifratoS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RisultatoCifratoS.Name = "lbl_RisultatoCifratoS";
            this.lbl_RisultatoCifratoS.Size = new System.Drawing.Size(108, 24);
            this.lbl_RisultatoCifratoS.TabIndex = 21;
            this.lbl_RisultatoCifratoS.Text = "Risultato : ";
            // 
            // btn_CifraStringa
            // 
            this.btn_CifraStringa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CifraStringa.Location = new System.Drawing.Point(585, 361);
            this.btn_CifraStringa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CifraStringa.Name = "btn_CifraStringa";
            this.btn_CifraStringa.Size = new System.Drawing.Size(118, 41);
            this.btn_CifraStringa.TabIndex = 22;
            this.btn_CifraStringa.Text = "INVIO";
            this.btn_CifraStringa.UseVisualStyleBackColor = true;
            // 
            // lbl_Parola3
            // 
            this.lbl_Parola3.AutoSize = true;
            this.lbl_Parola3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Parola3.Location = new System.Drawing.Point(849, 166);
            this.lbl_Parola3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Parola3.Name = "lbl_Parola3";
            this.lbl_Parola3.Size = new System.Drawing.Size(149, 24);
            this.lbl_Parola3.TabIndex = 23;
            this.lbl_Parola3.Text = "Inserisci Parola";
            // 
            // lbl_n17
            // 
            this.lbl_n17.AutoSize = true;
            this.lbl_n17.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n17.Location = new System.Drawing.Point(849, 229);
            this.lbl_n17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n17.Name = "lbl_n17";
            this.lbl_n17.Size = new System.Drawing.Size(147, 24);
            this.lbl_n17.TabIndex = 24;
            this.lbl_n17.Text = "Inserire Chiave";
            // 
            // lbl_RisultatoDecifratoS
            // 
            this.lbl_RisultatoDecifratoS.AutoSize = true;
            this.lbl_RisultatoDecifratoS.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RisultatoDecifratoS.Location = new System.Drawing.Point(849, 296);
            this.lbl_RisultatoDecifratoS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RisultatoDecifratoS.Name = "lbl_RisultatoDecifratoS";
            this.lbl_RisultatoDecifratoS.Size = new System.Drawing.Size(108, 24);
            this.lbl_RisultatoDecifratoS.TabIndex = 25;
            this.lbl_RisultatoDecifratoS.Text = "Risultato : ";
            // 
            // btn_DecifraStringa
            // 
            this.btn_DecifraStringa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DecifraStringa.Location = new System.Drawing.Point(852, 361);
            this.btn_DecifraStringa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DecifraStringa.Name = "btn_DecifraStringa";
            this.btn_DecifraStringa.Size = new System.Drawing.Size(121, 41);
            this.btn_DecifraStringa.TabIndex = 26;
            this.btn_DecifraStringa.Text = "INVIO";
            this.btn_DecifraStringa.UseVisualStyleBackColor = true;
            // 
            // txt_ParolaChiaraS
            // 
            this.txt_ParolaChiaraS.Location = new System.Drawing.Point(732, 164);
            this.txt_ParolaChiaraS.Name = "txt_ParolaChiaraS";
            this.txt_ParolaChiaraS.Size = new System.Drawing.Size(100, 23);
            this.txt_ParolaChiaraS.TabIndex = 27;
            // 
            // txt_ChiaveCifrataS
            // 
            this.txt_ChiaveCifrataS.Location = new System.Drawing.Point(732, 229);
            this.txt_ChiaveCifrataS.Name = "txt_ChiaveCifrataS";
            this.txt_ChiaveCifrataS.Size = new System.Drawing.Size(100, 23);
            this.txt_ChiaveCifrataS.TabIndex = 28;
            // 
            // txt_ParolaCifrataS
            // 
            this.txt_ParolaCifrataS.Location = new System.Drawing.Point(1003, 167);
            this.txt_ParolaCifrataS.Name = "txt_ParolaCifrataS";
            this.txt_ParolaCifrataS.Size = new System.Drawing.Size(100, 23);
            this.txt_ParolaCifrataS.TabIndex = 29;
            // 
            // txt_ChiaveDecifrataS
            // 
            this.txt_ChiaveDecifrataS.Location = new System.Drawing.Point(1003, 228);
            this.txt_ChiaveDecifrataS.Name = "txt_ChiaveDecifrataS";
            this.txt_ChiaveDecifrataS.Size = new System.Drawing.Size(100, 23);
            this.txt_ChiaveDecifrataS.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 35);
            this.label1.TabIndex = 31;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 35);
            this.label2.TabIndex = 32;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 35);
            this.label4.TabIndex = 34;
            this.label4.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 35);
            this.label5.TabIndex = 35;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 35);
            this.label6.TabIndex = 36;
            this.label6.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ChiaveDecifrataS);
            this.Controls.Add(this.txt_ParolaCifrataS);
            this.Controls.Add(this.txt_ChiaveCifrataS);
            this.Controls.Add(this.txt_ParolaChiaraS);
            this.Controls.Add(this.btn_DecifraStringa);
            this.Controls.Add(this.lbl_RisultatoDecifratoS);
            this.Controls.Add(this.lbl_n17);
            this.Controls.Add(this.lbl_Parola3);
            this.Controls.Add(this.btn_CifraStringa);
            this.Controls.Add(this.lbl_RisultatoCifratoS);
            this.Controls.Add(this.lbl_n16);
            this.Controls.Add(this.lbl_Parola2);
            this.Controls.Add(this.lbl_n13);
            this.Controls.Add(this.lbl_n12);
            this.Controls.Add(this.lbl_n11);
            this.Controls.Add(this.btn_Decifra);
            this.Controls.Add(this.lbl_n10);
            this.Controls.Add(this.lbl_RisultatoDecifrato);
            this.Controls.Add(this.txt_ParolaCifrata);
            this.Controls.Add(this.txt_ChiaveDecifrata);
            this.Controls.Add(this.txt_ChiaveCifrata);
            this.Controls.Add(this.txt_ParolaChiara);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(this.lbl_RisultatoCifrato);
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
        private System.Windows.Forms.Label lbl_RisultatoCifrato;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label lbl_n8;
        private System.Windows.Forms.TextBox txt_ParolaChiara;
        private System.Windows.Forms.TextBox txt_ChiaveCifrata;
        private System.Windows.Forms.TextBox txt_ChiaveDecifrata;
        private System.Windows.Forms.TextBox txt_ParolaCifrata;
        private System.Windows.Forms.Label lbl_RisultatoDecifrato;
        private System.Windows.Forms.Label lbl_n10;
        private System.Windows.Forms.Button btn_Decifra;
        private System.Windows.Forms.Label lbl_n11;
        private System.Windows.Forms.Label lbl_n12;
        private System.Windows.Forms.Label lbl_n13;
        private System.Windows.Forms.Label lbl_Parola2;
        private System.Windows.Forms.Label lbl_n16;
        private System.Windows.Forms.Label lbl_RisultatoCifratoS;
        private System.Windows.Forms.Button btn_CifraStringa;
        private System.Windows.Forms.Label lbl_Parola3;
        private System.Windows.Forms.Label lbl_n17;
        private System.Windows.Forms.Label lbl_RisultatoDecifratoS;
        private System.Windows.Forms.Button btn_DecifraStringa;
        private System.Windows.Forms.TextBox txt_ParolaChiaraS;
        private System.Windows.Forms.TextBox txt_ChiaveCifrataS;
        private System.Windows.Forms.TextBox txt_ParolaCifrataS;
        private System.Windows.Forms.TextBox txt_ChiaveDecifrataS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

