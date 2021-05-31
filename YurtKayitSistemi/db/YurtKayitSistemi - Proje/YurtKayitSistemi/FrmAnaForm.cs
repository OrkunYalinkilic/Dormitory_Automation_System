using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayitSistemi
{
    public partial class FrmAnaForm : Form
    {
        string zaman, girisTip, OgrKullaniciAd,YonKullaniciAd;
        public FrmAnaForm(string _girisTip,string _OgrKullaniciAd,string _YonKullaniciAd)
        {
            girisTip = _girisTip; OgrKullaniciAd = _OgrKullaniciAd; YonKullaniciAd = _YonKullaniciAd;
            InitializeComponent();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            fr.ShowDialog();
        }

        private void radyolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet1.Ogrenci);

            timer1.Start();

            if (girisTip == "ogrenci")
            {
                label5.Text = "ÖĞRENCİ GİRİŞİ";
                menuStrip1.Items[0].Visible = false;
                menuStrip1.Items[1].Visible = false;
                menuStrip1.Items[2].Visible = false;
                menuStrip1.Items[3].Visible = false;
                menuStrip1.Items[5].Visible = false;
                menuStrip1.Items[6].Visible = false;

                öğleYemeğiGüncelleToolStripMenuItem.Visible = false;
                akşamYemeğiGüncelleToolStripMenuItem.Visible = false;
                öğleYemekEkleToolStripMenuItem.Visible = false;
                odaEkleToolStripMenuItem.Visible = false;
                odaSilToolStripMenuItem.Visible = false;
                şoförEkleToolStripMenuItem.Visible = false;
                şoförSilToolStripMenuItem.Visible = false;
                şoförGüncelleToolStripMenuItem.Visible = false;
                servisSaatleriGüncelleToolStripMenuItem.Visible = false;
                odaNumarasınaGöreAramaToolStripMenuItem.Visible = false;
                borçÖdemeToolStripMenuItem.Visible = false;
                ıDYeGöreŞoförAramaToolStripMenuItem.Visible = false;
                isimeGöreŞoförAramaToolStripMenuItem.Visible = false;
                şoförleriListeleToolStripMenuItem.Visible = false;
            }

            if (girisTip == "yonetici")
            {
                label5.Text = "YÖNETİCİ GİRİŞİ";
                menuStrip1.Items[11].Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void öğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit fr = new FrmOgrKayit();
            fr.ShowDialog();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri frm = new OgrenciIslemleri();
            frm.ShowDialog();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumIslemleri frm = new BolumIslemleri("ekleme");
            frm.ShowDialog();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumIslemleri frm = new BolumIslemleri("guncelleme");
            frm.ShowDialog();
        }

        private void ödemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.ShowDialog();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr = new FrmGider();
            fr.ShowDialog();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik fr = new FrmGelirIstatistik();
            fr.ShowDialog();
        }

        private void giderİstatistikleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGiderIstatistikleri frm = new frmGiderIstatistikleri();
            frm.ShowDialog();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr = new FrmYoneticiDuzenle();
            fr.ShowDialog();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelISLEM frm = new PersonelISLEM("guncelleme");
            frm.ShowDialog();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void hakkımzdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir yurt otomasyon programıdır. Orkun Yalınkılıç", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bölümSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumIslemleri frm = new BolumIslemleri("silme");
            frm.ShowDialog();
        }

        private void ıDİleBölümAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumIslemleri frm = new BolumIslemleri("ıdArama");
            frm.ShowDialog();
        }

        private void isimİleBölümAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumIslemleri frm = new BolumIslemleri("isimleArama");
            frm.ShowDialog();
        }

        private void öğrenciDüzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOgrDuzenleFormu frm = new frmOgrDuzenleFormu();
            frm.ShowDialog();
        }

        private void ıDİleÖğrenciAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrArama frm = new frmOgrArama("idarama");
            frm.ShowDialog();
        }

        private void isimİleÖğrenciAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrArama frm = new frmOgrArama("isimarama");
            frm.ShowDialog();
        }

        private void giderGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderGuncellecs frm = new FrmGiderGuncellecs();
            frm.ShowDialog();
        }

        private void gİderSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderSil frm = new frmGiderSil();
            frm.ShowDialog();
        }

        private void öğrencilereBildirimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuyuruEkle frm = new frmDuyuruEkle();
            frm.ShowDialog();
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmYoneticiIslemleri frm = new frmYoneticiIslemleri();
            //frm.ShowDialog();

            frmYoneticiEkle frm = new frmYoneticiEkle();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelAyrintiIslem fr = new frmPersonelAyrintiIslem(string.Empty, "ekleme");
            fr.ShowDialog();
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelISLEM frm = new PersonelISLEM("silme");
            frm.Show();
        }

        private void personelDüzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PersonelISLEM frm = new PersonelISLEM("guncelleme");
            frm.ShowDialog();
        }

        private void ıDYeGörePersonelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelISLEM frm = new PersonelISLEM("idarama");
            frm.ShowDialog();
        }

        private void isimeGörePersonelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelISLEM frm = new PersonelISLEM("isimarama");
            frm.ShowDialog();
        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdaIslem frm = new frmOdaIslem("ekleme", "0");
            frm.ShowDialog();
        }

        private void odalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdaListe frm = new OdaListe();
            frm.ShowDialog();
        }

        private void odaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdaSil frm = new frmOdaSil();
            frm.ShowDialog();
        }

        private void odaNumarasınaGöreAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdaArama frm = new frmOdaArama();
            frm.ShowDialog();
        }

        private void öğleYemekEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYemekEkleme frm = new frmYemekEkleme();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void öğleYemeğiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgleYemekGuncelleSecim frm = new frmOgleYemekGuncelleSecim();
            frm.ShowDialog();
        }

        private void günÖğleYemekGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgleYemekGun frm = new OgleYemekGun();
            frm.ShowDialog();
        }

        private void günAkşamYemekGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAksamYemekGun frm = new frmAksamYemekGun();
            frm.ShowDialog();
        }

        private void aylıkÖğleYemekPlanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYemekAylikPlan frm = new frmYemekAylikPlan("öğle");
            frm.ShowDialog();
        }

        private void aylıkAkşamYemekPlanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYemekAylikPlan frm = new frmYemekAylikPlan("akşam");
            frm.ShowDialog();
        }

        private void akşamYemeğiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgleYemekGuncelleSecim frm = new frmOgleYemekGuncelleSecim();
            frm.ShowDialog();
        }

        private void yemekAlınanFirmaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YemekAlinanFirma frm = new YemekAlinanFirma();
            frm.ShowDialog();
        }

        private void şoförEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmŞoforEkle frm = new frmŞoforEkle();
            frm.ShowDialog();
        }

        private void şoförSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforIslemleri frm = new SoforIslemleri("silme");
            frm.ShowDialog();
        }

        private void şoförGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforIslemleri frm = new SoforIslemleri("guncelleme");
            frm.ShowDialog();
        }

        private void ıDYeGöreŞoförAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforIslemleri frm = new SoforIslemleri("idarama");
            frm.ShowDialog();
        }

        private void isimeGöreŞoförAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoforIslemleri frm = new SoforIslemleri("isimarama");
            frm.ShowDialog();
        }

        private void şoförleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoforListecs frm = new frmSoforListecs();
            frm.ShowDialog();
        }

        private void servisSaatleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracServisListe frm = new frmAracServisListe();
            frm.ShowDialog();
        }

        private void servisSaatleriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAracServisGuncelle frm = new frmAracServisGuncelle();
            frm.ShowDialog();
        }

        private void ödemeGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(label5.Text== "ÖĞRENCİ GİRİŞİ")
            {
                frmBorcGoruntuleme frm = new frmBorcGoruntuleme("ogrGoruntuleme", OgrKullaniciAd, zaman);
                frm.ShowDialog();
            }
            else
            {
                BorcIslemleri frm = new BorcIslemleri("goruntuleme", zaman);
                frm.ShowDialog();
            }
           
        }

        private void borçÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorcIslemleri frm = new BorcIslemleri("odeme", zaman);
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuyuruGoruntule frm = new frmDuyuruGoruntule();
            frm.ShowDialog();
        }

        private void duyurularToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDuyuruGoruntule frm = new frmDuyuruGoruntule();
            frm.ShowDialog();
        }

        private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yöneticiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatisHareketGoruntuleme frm = new frmSatisHareketGoruntuleme();
            frm.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunEkleme frm = new frmUrunEkleme();
            frm.ShowDialog();
        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunSilme frm = new frmUrunSilme();
            frm.ShowDialog();

        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUrunGuncellemeSecim frm = new frmUrunGuncellemeSecim();
            frm.ShowDialog();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkleme frm = new frmMusteriEkleme();
            frm.ShowDialog();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriSil frm = new frmMusteriSil();
            frm.ShowDialog();
        }

        private void personelEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonelEkleme frm = new frmPersonelEkleme();
            frm.ShowDialog();
        }

        private void personelSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonelSilme frm = new frmPersonelSilme();
            frm.ShowDialog();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKasa frm = new frmKasa();
            frm.ShowDialog();
        }

        private void ödemelerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSatis frm = new frmSatis();
            frm.ShowDialog();
        }

        private void mağazaVeriİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMagazaIstatistik frm = new frmMagazaIstatistik();
            frm.ShowDialog();
        }

        private void yöneticiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
