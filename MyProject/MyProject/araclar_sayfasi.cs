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
    public partial class araclar_sayfasi : Form
    {
        public araclar_sayfasi()
        {
            InitializeComponent();
        }

        private void araclar_sayfasi_Load(object sender, EventArgs e)
        {
            timer1.Start();//Saat ve tarih form başladığında
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Saat.Text = DateTime.Now.ToString("g");
        }
    }
}
