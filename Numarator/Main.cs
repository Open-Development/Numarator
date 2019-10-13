using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Numarator
{
    public partial class Main : Form
    {
        private Hashtable Masalar;
        private Queue<int> Bekleyenler;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Numarator";
            btnGetNumber.Text = "Get Number";
            lblLastNumber.Text = "-";

            this.Masalar = new Hashtable();
            this.Bekleyenler = new Queue<int>();

            this.masalariYukle();
        }

        private void masalariYukle()
        {
            this.Masalar.Add(1, 0);
            this.Masalar.Add(2, 0);
            this.Masalar.Add(3, 0);
            this.Masalar.Add(4, 0);
            this.Masalar.Add(5, 0);
            this.Masalar.Add(6, 0);
        }

        private void BtnGetNumber_Click(object sender, EventArgs e)
        {

        }

        private void numaraEkle(int numara)
        {
            this.Bekleyenler.Enqueue(numara);
        }

        private int siradaki()
        {
            return this.Bekleyenler.Dequeue();
        }
    }
}
