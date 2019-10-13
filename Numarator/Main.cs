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
        private List<Masa> Masalar;
        private List<SiraNumarasi> Bekleyenler;
        private int SonNumara;
        private Random rastgeleSure;

        private Timer timer;

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
            this.rastgeleSure = new Random();
            this.lblSiraNumarasi.Text = "";

            this.Masalar = new List<Masa>();
            this.Bekleyenler = new List<SiraNumarasi>();

            this.masalariYukle();

            this.refreshList();

            this.timer = new Timer();
            this.timer.Interval = 5000;
            this.timer.Tick += new EventHandler(this.CheckDesks);
            this.timer.Enabled = true;
            this.timer.Start();
        }

        private void CheckDesks(object sender, EventArgs e)
        {
            for (int i = 0; i < Masalar.Count; i++)
            {
                if (Masalar[i].SiraNumarasi == null || (DateTime.Now - Masalar[i].SiraNumarasi.TarihSaat).TotalSeconds >= Masalar[i].SiraNumarasi.TamamlanmaSuresi)
                {
                    SiraNumarasi kayit = this.Bekleyenler != null && this.Bekleyenler.Count > 0 ? this.Bekleyenler.OrderBy(o => o.Sayi).FirstOrDefault() : null;
                    Masalar[i].SiraNumarasi = kayit;

                    if (this.Bekleyenler != null && this.Bekleyenler.Count > 0)
                        this.Bekleyenler.Remove(kayit);

                    refreshList();
                }
            }
        }

        private void refreshList()
        {
            this.listWaiting.DataSource = null;
            this.listWaiting.DataSource = this.Bekleyenler;
            this.listWaiting.DisplayMember = "Sayi";

            this.listInProgress.DataSource = null;
            this.listInProgress.DataSource = this.Masalar.Select(s => s.MasaNumarasi + " : " + (s.SiraNumarasi != null ? s.SiraNumarasi.Sayi.ToString() : "")).ToList();
        }

        private void masalariYukle()
        {
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 1 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 2 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 3 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 4 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 5 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 6 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 7 });
            this.Masalar.Add(new Masa() { SiraNumarasi = null, MasaNumarasi = 8 });
        }

        private void BtnGetNumber_Click(object sender, EventArgs e)
        {
            this.SonNumara++;

            SiraNumarasi yeniKayit = new SiraNumarasi();
            yeniKayit.Sayi = this.SonNumara;
            yeniKayit.TarihSaat = DateTime.Now;
            yeniKayit.TamamlanmaSuresi = rastgeleSure.Next(60, 300);

            this.Bekleyenler.Add(yeniKayit);

            this.sonNumarayiGuncelle(this.SonNumara, this.Bekleyenler.Count);
            refreshList();
        }

        private void sonNumarayiGuncelle(int sonNumara, int bekleyenSayisi)
        {
            this.lblLastNumber.Text = sonNumara.ToString();


            this.lblSiraNumarasi.Text = bekleyenSayisi.ToString() + ".";

            if (bekleyenSayisi < 10 && bekleyenSayisi != 0)
            {
                this.lblSiraNumarasi.Location = new System.Drawing.Point(168, 124);
            }
            else if (bekleyenSayisi < 100)
            {
                this.lblSiraNumarasi.Location = new System.Drawing.Point(154, 125);
            }
            else if (bekleyenSayisi < 1000)
            {
                this.lblSiraNumarasi.Location = new System.Drawing.Point(138, 125);
            }
            else
            {
                this.lblSiraNumarasi.Text = "";
            }
        }

    }
}
