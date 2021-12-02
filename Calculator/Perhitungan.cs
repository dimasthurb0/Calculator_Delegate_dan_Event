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
    public partial class Perhitungan : Form
    {
        private IList<OperasiDasar> listOfOperasiDasar = new List<OperasiDasar>();
        public Perhitungan()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvPerhitungan.View = View.Details;
            lvPerhitungan.Columns.Add("", 0, HorizontalAlignment.Left);
            lvPerhitungan.Columns.Add("", 334, HorizontalAlignment.Left);

        }
        private void Kalkulator_OnUpdate (OperasiDasar operasi)
        {
            listOfOperasiDasar.Add(operasi);
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(operasi.Penjumlahan);
            item.SubItems.Add(operasi.Pengurangan);
            item.SubItems.Add(operasi.Perkalian);
            item.SubItems.Add(operasi.Pembagian);

            lvPerhitungan.Items.Add(item);
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            Kalkulator kal = new Kalkulator();
            kal.OnUpdate += Kalkulator_OnUpdate;
            kal.ShowDialog();
        }
    }
}
