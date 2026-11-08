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
        
            string ParolaChiara, ParolaCifrata = "";
            int nLettera = 0, chiave = 0;


            ParolaChiara = txt_ParolaChiara.Text;
            ParolaChiara = ParolaChiara.ToLower();
            chiave = Convert.ToInt32(txt_ChiaveCifrata.Text);
            for (int i = 0; i < ParolaChiara.Length; i++)
            {
                nLettera = Convert.ToInt32(ParolaChiara[i]);
                nLettera = nLettera + chiave;

                if (nLettera > 122)
                {
                    nLettera = nLettera - 26;
                }
                nLettera = Convert.ToChar(nLettera);
                ParolaCifrata = ParolaCifrata + (Char)nLettera;
                lbl_RisultatoCifrato.Text ="Il Risultato è " + ParolaCifrata;

            }



        }

        private void btn_Decifra_Click(object sender, EventArgs e)
        {
            string ParolaChiara = "", ParolaCifrata;
            int nLettera = 0, chiave1 = 0;


            ParolaCifrata = txt_ParolaCifrata.Text;
            ParolaCifrata = ParolaCifrata.ToLower();
            chiave1 = Convert.ToInt32(txt_ChiaveDecifrata.Text);
            for (int i = 0; i < ParolaCifrata.Length; i++)
            {
                nLettera = Convert.ToInt32(ParolaCifrata[i]);
                nLettera = nLettera - chiave1;

                if (nLettera < 97)
                {
                    nLettera = nLettera + 26;
                }
                nLettera = Convert.ToChar(nLettera);
                ParolaChiara = ParolaChiara + (Char)nLettera;
                lbl_RisultatoDecifrato.Text = "Il Risultato è " + ParolaChiara;

            }
        }
    }
    }




    

