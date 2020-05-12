/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:3
**				ÖĞRENCİ ADI............:MAFTUN HASHIMLI
**				ÖĞRENCİ NUMARASI.......:G181210554
**              DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEVDENEME3
{
    public partial class NDPODEV3 : Form
    {
        public NDPODEV3()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }            
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //temizleme islemi
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        private void btnHESAPLA_Click_1(object sender, EventArgs e)
        {
            //textbox'in bos gecilmesini engelleme
            if (txtigirdi.Text == "")
            {
                MessageBox.Show("boş alan bırakmayınız");

            }
            else
            {
                //ifadeyi "/*-+" ifadeleriyle ayiriyoruz
                var sayi = txtigirdi.Text.Split("/*-+".ToCharArray());
                //regex kutuphanesini kulanarak ifadeyiy=i /d yardimiyla 1-9 araligindaki sayilara parcaliyoruz
                var islem = Regex.Split(txtigirdi.Text, @"\d", RegexOptions.None).Where(p => p != "").ToArray<string>();
                //yeni liste
                List<string> sayilar = new List<string>();
                //sayi ekliyoruz
                foreach (string sayiekle in sayi)
                {
                    sayilar.Add(sayiekle);
                }
                List<string> islemler = new List<string>();
                foreach (string islemekle in islem)
                {
                    islemler.Add(islemekle);
                }

                decimal kontrol = decimal.Parse(sayilar[0]);
                decimal temp = 0;
                //islem sirasini beliriyoruz
                for (int i = 0; i < islemler.Count; i++)

                {

                    switch (islemler[i])
                    {
                        case "/":
                            if (i + 1 < sayilar.Count)
                            {
                                temp = (decimal.Parse(sayilar[i]) / decimal.Parse(sayilar[i + 1]));
                                sayilar[i] = Convert.ToString(temp);
                                sayilar.RemoveAt(i + 1);
                                islemler.Remove("/");
                                i = -1;
                            }
                            break;
                        case "*":
                            if (i + 1 < sayilar.Count)
                            {
                                temp = (decimal.Parse(sayilar[i]) * decimal.Parse(sayilar[i + 1]));
                                sayilar[i] = Convert.ToString(temp);
                                sayilar.RemoveAt(i + 1);
                                islemler.Remove("*");
                                i = -1;
                            }
                            break;

                    }
                }
                for (int i = 0; i < islemler.Count; i++)
                {
                    switch (islemler[i])
                    {

                        case "-":
                            if (i + 1 < sayilar.Count)
                            {
                                temp = (decimal.Parse(sayilar[i]) - decimal.Parse(sayilar[i + 1]));
                                sayilar[i] = Convert.ToString(temp);
                                sayilar.RemoveAt(i + 1);
                                islemler.Remove("-");
                                i = -1;
                            }
                            break;
                        case "+":
                            if (i + 1 < sayilar.Count)
                            {
                                temp = (decimal.Parse(sayilar[i]) + decimal.Parse(sayilar[i + 1]));
                                sayilar[i] = Convert.ToString(temp);
                                sayilar.RemoveAt(i + 1);
                                islemler.Remove("+");
                                i = -1;
                            }
                            break;
                    }
                }
                //sonucu yazdiriyoruz
                txtsonuc.Text = sayilar[0];
            }

        }
            private void txtigirdi_KeyPress_1(object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/';

            }

            private void txtigirdi_KeyDown(object sender, KeyEventArgs e)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    this.ActiveControl = btnHESAPLA;
                }

            }

        private void txtsonuc_TextChanged(object sender, EventArgs e)
        {
         

        }
    }
    }


    

