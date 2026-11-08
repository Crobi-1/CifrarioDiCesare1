using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifrarioDiCesare1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_Cifra_Click_1(object sender, EventArgs e)
        {
            // Dichiarazione delle variabili 
            string ParolaChiara, ParolaCifrata = "";
            int nLettera = 0, chiave = 0;

            // Lettura del testo dalla casella di input e conversione tutto in minuscolo
            ParolaChiara = txt_ParolaChiara.Text;
            ParolaChiara = ParolaChiara.ToLower();

            // Lettura della chiave numerica e riduzione con modulo 26 per evitare caratteri strani
            chiave = Convert.ToInt32(txt_ChiaveCifrata.Text) % 26;

            // Ciclo per scorrere una lettera alla volta tutta la parola inserita
            for (int i = 0; i < ParolaChiara.Length; i++)
            {
                
                nLettera = Convert.ToInt32(ParolaChiara[i]);

                // Somma della chiave al codice della lettera per spostarla in avanti nell'alfabeto
                nLettera = nLettera + chiave;

                // Controllo per ricominciare dalla 'a' (97) se si supera la 'z' (122)
                if (nLettera > 122)
                {
                    nLettera = nLettera - 26;
                }

                // Conversione del nuovo codice numerico di nuovo in carattere
                nLettera = Convert.ToChar(nLettera);

                // Aggiunta della lettera cifrata alla stringa finale
                ParolaCifrata = ParolaCifrata + (Char)nLettera;

                // Visualizzazione del risultato Cifrato
                lbl_RisultatoCifrato.Text = "Il Risultato è " + ParolaCifrata;
            }
        }




        private void btn_Decifra_Click(object sender, EventArgs e)
        {
            // Dichiarazione delle variabili  
            string ParolaChiara = "", ParolaCifrata;
            int nLettera = 0, chiave1 = 0;

            // Lettura del testo cifrato dalla casella di input e conversione tutto in minuscolo
            ParolaCifrata = txt_ParolaCifrata.Text;
            ParolaCifrata = ParolaCifrata.ToLower();

            // Lettura della chiave numerica e riduzione con modulo 26 per evitare caratteri strani
            chiave1 = Convert.ToInt32(txt_ChiaveDecifrata.Text) % 26;

            // Ciclo per scorrere una lettera alla volta tutta la parola cifrata
            for (int i = 0; i < ParolaCifrata.Length; i++)
            {
               
                nLettera = Convert.ToInt32(ParolaCifrata[i]);

                // Sottrazione della chiave al codice della lettera per tornare indietro nell'alfabeto
                nLettera = nLettera - chiave1;

                // Controllo per ricominciare dalla 'z' (122) se si scende sotto la 'a' (97)
                if (nLettera < 97)
                {
                    nLettera = nLettera + 26;
                }

                // Conversione del nuovo codice numerico di nuovo in carattere
                nLettera = Convert.ToChar(nLettera);

                // Aggiunta della lettera decifrata alla stringa finale
                ParolaChiara = ParolaChiara + (Char)nLettera;

                // Visualizzazione del risultato Decifrato
                lbl_RisultatoDecifrato.Text = "Il Risultato è " + ParolaChiara;
            }
        }

        
    }
    }




    

