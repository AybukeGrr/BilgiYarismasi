using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            LblSoruNo.Text = soruNo.ToString();

            if (soruNo == 0) {
                yanlis = 0;
                dogru = 0;
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;

            }
            if (soruNo == 1) { 
                richTextBox1.Text = "Eski dilde ödül anlamında kullanılan sözcük hangisidir?";
                BtnA.Text = "Hürmet";
                BtnB.Text = "Tazminat";
                BtnC.Text = "Lutüf";
                BtnD.Text = "Mükafat";
                label4.Text = "Mükafat";
            }
            if (soruNo == 2) {
                richTextBox1.Text = "Filmdeki başkahramanın yüzünde mavi renk savaş boyası görüyorsanız, hangi filmi izliyorsunuzdur?";
                BtnA.Text = "Cesur Yürek";
                BtnB.Text = "Gladyatör";
                BtnC.Text = "Matrix";
                BtnD.Text = "Son Mohikan";
                label4.Text = "Cesur Yürek";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Atilla İlhan'ın hangi isimde bir kitabı yoktur?";
                BtnA.Text = "Hangi Ülke";
                BtnB.Text = "Hangi Batı";
                BtnC.Text = "Hangi Küreselleşme";
                BtnD.Text = "Hangi Edebiyat";
                label4.Text = "Hangi Ülke";
               
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "On kıtadan oluşan İstiklal Marşı'nın tamamında, bu kelimelerden hangisi diğerlerinden daha az geçer?";
                BtnA.Text = "Vatan";
                BtnB.Text = "Kan";
                BtnC.Text = "Toprak";
                BtnD.Text = "Yurt";
                label4.Text = "Toprak";

            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Hollywood filmlerinde polislerin en fazla tükettikleri yiyecek ve içecek hangileri olur?";
                BtnA.Text = "Çiğ köfte ve ayran";
                BtnB.Text = "Lahmacun ve şalgam suyu";
                BtnC.Text = "Leblebi ve boza";
                BtnD.Text = "Donut ve kahve";
                label4.Text = "Donut ve kahve";

            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Her dalında 3 elma bulunan 50 dallı bir ağacın, 20 dalına konan 20 kartal birer elma yiyip kalkarken birer elma düşürürse ağaçta kaç tane elma kalır?";
                BtnA.Text = "10";
                BtnB.Text = "50";
                BtnC.Text = "90";
                BtnD.Text = "110";
                label4.Text = "110";

            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Hangisinin hem İsviçre hem de Sürmene işi olanı meşhurdur?";
                BtnA.Text = "Hamsili pilav";
                BtnB.Text = "Kol saati";
                BtnC.Text = "Çikolata";
                BtnD.Text = "Çakı";
                label4.Text = "Çakı";

            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Arkadaşına hangisini soran kişi muhtemelen parasını bozdurmaya çalışıyordur?";
                BtnA.Text = "İki beşliğin var mı?";
                BtnB.Text = "Dört dörtlüğün var mı?";
                BtnC.Text = "Yedi üçlüğün var mı?";
                BtnD.Text = "Dokuz sekizliğin var mı?";
                label4.Text = "İki beşliğin var mı?";

            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Flaşlı fotoğraf çekimlerinde sıkça karşılaşılan ve düzeltmek için dijital makinelerde özel ayarı olan sorun hangisidir?";
                BtnA.Text = "Kırmızı göz";
                BtnB.Text = "Sivri kulak";
                BtnC.Text = "Uzun burun";
                BtnD.Text = "Tavşan diş";
                label4.Text = "Kırmızı göz";

            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Masal anlatan kişilerin, inanması güç bir kısma gelindiğinde, dinleyicilerin itirazlarını peşinen geçiştirmek için söylediği klişe ifade hangisidir?";
                BtnA.Text = "Olur öyle şeyler";
                BtnB.Text = "Masal bu ya";
                BtnC.Text = "Elçiye zeval olmaz";
                BtnD.Text = "Bu da geçer";
                label4.Text = "Masal bu ya";

            }


            if (soruNo == 11) {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                BtnSonraki.Text = "Sonuçlar:";
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text) {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

    }
}
