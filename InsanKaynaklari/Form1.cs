using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SatisTemsilcisi st = new SatisTemsilcisi();
        private void Form1_Load(object sender, EventArgs e)
        {
            NumSatisAdeti.Enabled = false;
            btnYenile.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            st.ElemanTuru = cmbElemanTuru.SelectedItem.ToString();
            st.maas = Convert.ToDouble(numMaas.Value);
            st.TCkimlikNo = Convert.ToInt32(numTCKimlikNo);

            lstBoxCalisanlar.Items.Add(st);
        }

        private void lstBoxCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            cmbElemanTuru.Enabled = false;
            numMaas.Enabled = false;
            numTCKimlikNo.Enabled = false;
            btnEkle.Enabled = false;

            NumSatisAdeti.Enabled = true;
            btnYenile.Enabled = true;

            st = (SatisTemsilcisi)lstBoxCalisanlar.SelectedItem;

            numMaas.Value = (decimal)st.maas;
            numTCKimlikNo.Value = st.TCkimlikNo;
            

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            st = (SatisTemsilcisi)lstBoxCalisanlar.SelectedItem;
            int satisAdeti = (int)NumSatisAdeti.Value;
            numMaas.Value = Convert.ToDecimal(st.PrimliMaasHesapla(satisAdeti));
        }
    }
}
