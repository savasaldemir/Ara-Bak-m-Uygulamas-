using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class my_car : Form
    {
        public my_car()
        {
            InitializeComponent();
        }

        private void my_car_Load(object sender, EventArgs e)
        {
            timer1.Start();//form yüklendiğinde zamanlayıcı başlar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToString("g");
        }

        private void btn_arac_sayfası_Click(object sender, EventArgs e)
        {
            araclar_sayfasi araclar_Sayfasi = new araclar_sayfasi();
            araclar_Sayfasi.ShowDialog();
        }
    }
}
