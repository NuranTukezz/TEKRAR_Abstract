using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEKRAR_Abstract.Models;

namespace TEKRAR_Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(FaturaTip)))
            {
                cmbFaturaTip.Items.Add(item);
            }
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
           FaturaTip secilenDeger = (FaturaTip)cmbFaturaTip.SelectedItem;

            int ilkIndex = int.Parse(txtIlkIndex.Text);
            int sonIndex = int.Parse(txtSonIndex.Text);
            decimal birimFiyat = decimal.Parse(txtBirimFiyat.Text);

            decimal faturaTutar = 0;

            //switch (secilenDeger)
            //{
            //    case FaturaTip.Su:
            //        SuFaturasi sf = new SuFaturasi(birimFiyat);
            //        sf.IlkIndex = ilkIndex;
            //        sf.SonIndex = sonIndex;
            //        faturaTutar = sf.Hesapla(sf);

            //        lblOdenecekTutar.Text = faturaTutar.ToString();
            //        break;
            //    case FaturaTip.Elektirik:
            //        ElekrikFaturası ef = new ElekrikFaturası(birimFiyat);
            //        ef.IlkIndex = ilkIndex;
            //        ef.SonIndex = sonIndex;
            //        faturaTutar = ef.Hesapla(ef);

            //        lblOdenecekTutar.Text = faturaTutar.ToString();

            //        break;
            //    case FaturaTip.Dogalgaz:
            //        DogalGazFaturasi df = new DogalGazFaturasi(birimFiyat);
            //        df.IlkIndex = ilkIndex;
            //        df.SonIndex = sonIndex;
            //        faturaTutar = df.Hesapla(df);

            //        lblOdenecekTutar.Text = faturaTutar.ToString();

            //        break;
            //    default:
            //        break;
            //}


            //Parametresiz hesapla metodu

            switch (secilenDeger)
            {
                case FaturaTip.Su:
                    SuFaturasi sf = new SuFaturasi();
                     sf.IlkIndex = ilkIndex;
                     sf.SonIndex = sonIndex;
                    faturaTutar = sf.Hesapla();

                    lblOdenecekTutar.Text = faturaTutar.ToString();

                    break;
                case FaturaTip.Elektirik:
                    ElekrikFaturası ef = new ElekrikFaturası();
                    ef.IlkIndex = ilkIndex;
                    ef.SonIndex = sonIndex;
                    faturaTutar = ef.Hesapla();

                    lblOdenecekTutar.Text = faturaTutar.ToString();
                    break;
                case FaturaTip.Dogalgaz:
                    DogalGazFaturasi df = new DogalGazFaturasi();
                    df.IlkIndex = ilkIndex;
                    df.SonIndex = sonIndex;
                    faturaTutar = df.Hesapla();

                    lblOdenecekTutar.Text = faturaTutar.ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
