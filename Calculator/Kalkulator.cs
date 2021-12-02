using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Kalkulator : Form
    {
        public delegate void CreateUpdateEventHandler(OperasiDasar operasi);
        public event CreateUpdateEventHandler OnUpdate;
        private OperasiDasar operasi; 
        public Kalkulator()
        {
            InitializeComponent();
            cmbOperasi.Items.AddRange(new object[]{"Penjumlahan","Pengurangan","Perkalian","Pembagian"});
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Kalkulator(string title)
        : this()
        {
            this.Text = title;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            
            var a = int.Parse(txtnilaiA.Text);
            var b = Convert.ToInt32(txtnilaiB.Text);
            var operasi = new OperasiDasar();

            if (cmbOperasi.SelectedIndex == 0) 
            {
                operasi.Penjumlahan = string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, a + b); 
            }
            else if (cmbOperasi.SelectedIndex == 0)
            {
                operasi.Pengurangan = string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, a - b);
            }
            else if (cmbOperasi.SelectedIndex == 0)
            {
                operasi.Perkalian = string.Format("Hasil Perkalian : {0} x {1} = {2}", a, b, a * b);
            }
            else if (cmbOperasi.SelectedIndex == 0)
            {
                operasi.Pembagian = string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, a / b);
            }
            else if (cmbOperasi.SelectedIndex == 1) 
            {
                OnUpdate(operasi);
                this.Close();
            }
            OnUpdate(operasi);
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
