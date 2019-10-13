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
        private int SonNumara;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Numarator";
            this.btnGetNumber.Text = "Get Number";
            this.lblLastNumber.Text = "-";
            this.SonNumara = 0;

            this.Masalar = new Hashtable();
            this.Bekleyenler = new Queue<int>();

            this.masalariYukle();

            refreshList();
        }

        private void refreshList()
        {
            this.listWaiting.DataSource = null;
            this.listWaiting.DataSource = Bekleyenler;
            this.listWaiting.DisplayMember = "Key";
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
            this.SonNumara++;
            this.lblLastNumber.Text = this.SonNumara.ToString();

            this.Bekleyenler.Enqueue(this.SonNumara);

            refreshList();
        }

    }
}
