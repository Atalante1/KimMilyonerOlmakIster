
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

/// <summary>
/// Aslı Karaçalı 201713709018
/// Kİm milyoner olmak ister oyunu
///
/// </summary>
namespace Millionaire
{
    public partial class MainWindow : Form
    {
        int level;// level yani hangi soruda olduğumuzu göstermek için 
        int Baraj = 0;// baraj için atadğımız değişken yani kazanılan paranın korunması için 2 tane baraj var oyunda biri 1000tl biri 15000tl barajı
        int GuncelKazanc = 0;//soru bildikce kazandığımız para
        bool gameRunning;//oyun devam ediyor mu etmiyor mu kontrolu için boolean değişken 
        bool yariyariya = true;//yari yariya joker hakkı kullanıldı mı kullanılmadı mı diye boolean değişken tanımladık
        bool telefonJokeri = true;//telefon joker hakkı kullanıldı mı kullanılmadı mı diye boolean değişken tanımladık
        string SecimCevap;
        GameLoop loop;//GameLoop sınıfından loop değişkenini yarattık
        SoruDepo gelensoru;//SoruDepo sınıfından gelensoru değişkenini yarattık
        SoundPlayer dogruCevap = new SoundPlayer("confirmation_002.wav");// Doğru cevaplarda çalacak olan ses
        SoundPlayer yanlisCevap = new SoundPlayer("error_007.wav");// yanlış cevaplarda çalacak olan ses
        private static Random rand = new Random(); // random için rand değişkeni oluşturduk aşağıdaki soru cevap şıkları için kullandık her seferinde farklı şıklar gelsin diye

        public int get_level() { return level; }
        public void set_level(int x) { level = x; }
        public bool get_isRunning() { return gameRunning; }
        public void set_isRunning(bool x) { gameRunning = x; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Load'da bir şey olmasına gerek yok
        }


        /// <summary>
        /// Oyuna Başla butonu tıklandığında çalışır oyunu başlatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            //oyun döngüsünü yani Gameloopu başlatıyoruz ve this GUI'yi döngüye ekliyoruz
            loop = new GameLoop(this);
            //loop run methodunu çağırıyoruz
            loop.Run();
        }
        /// <summary>
        /// SoruDepo classında yüklediğimiz soruları kullanmak için 
        /// </summary>
        public void sorulariYukle()
        {
            gelensoru = new SoruDepo();
        }

        
        /// <summary>
        /// oyunun başında çağrılan oyun yükleme methodu
        /// </summary>
        public void Gameload()
        {
            //Sesleri bir kez çaldık, böylece belleğe yüklenicek ve gerektiğinde sesler daha hızlı çalınıcak
            dogruCevap.Play();//doğru cevap ses
            yanlisCevap.Play();//yanlış cevap ses
            //level =0 olarak ayarladık oyunun başındayız
            level = 0;
            gameRunning = true;
            pictureBoxPlay.Visible = false;
            pictureBoxBG.Visible = true;
            pictureBox5050.Visible = true;
            buttonBilgilendirme.Visible = true;
            pictureBoxTelefonJokeri.Visible = true;
            pictureBoxPesEtme.Visible = true;
            pictureBoxPara.Visible = true;
            groupBox1.Visible = true;
            labelSoru.Visible = true;
            labelA.Visible = true;
            labelB.Visible = true;
            labelC.Visible = true;
            labelD.Visible = true;
            // Soru labelina max size yaptık düzgün dursun diye
            labelSoru.MaximumSize = new Size(350, 0);
            pictureBoxPara.Image = Millionaire.Properties.Resources.kim_milyoner;
        }//end GameLoad

        /// <summary>
        /// Soruların gösterildiği kısım
        /// her oyunu açtığımızda şıkların rastgele yerlerde gelmesini sağlıyor
        /// Soruların doğru sıra ile ekrana verilmesini sağlıyor
        /// 
        /// </summary>
        public void SoruyuYansitmak()
        {
            //eğer dosya seçmede bi hata olursa soruları oyuna eklemez if içinde txt dosyası eklemede hata var mı diye bakıyoruz
            if (level < 12 && !gelensoru.ImportHatasi)//12 tane soru var her sorunun ekrana yansıtılması için bakar tek tek level 12 olana kadar
            {
                //Sorudaki şıkları qArray dizisine atıyoruz
                String[] qArray = { gelensoru.Sorular[level].Cevap1, gelensoru.Sorular[level].Cevap2, gelensoru.Sorular[level].Cevap3, gelensoru.Sorular[level].Cevap4 };
              
                Shuffle<string>(qArray);  //şıkların yerlerinin random değiştiriyoruz her açtığımızda farklı yerde olucak şıklar
                labelA.Visible = true;//şıkların görünümünü true yapıyoruz
                labelB.Visible = true;//şıkların görünümünü true yapıyoruz
                labelC.Visible = true;//şıkların görünümünü true yapıyoruz
                labelD.Visible = true;//şıkların görünümünü true yapıyoruz
                labelSoru.Text = gelensoru.Sorular[level].Soru;//formdaki labela sırası gelen soruyu yazdırıyoruz
                labelA.Text = qArray[0];//LabelA'ya qArray dizisindeki 1. elemanı yazıyoruz
                labelB.Text = qArray[1];//LabelB'ya qArray dizisindeki 2. elemanı yazıyoruz
                labelC.Text = qArray[2];//LabelC'ya qArray dizisindeki 3. elemanı yazıyoruz
                labelD.Text = qArray[3];//LabelD'ya qArray dizisindeki 4. elemanı yazıyoruz yani şıkları yazıyoruz
            }
            else
            {
                set_isRunning(false);
                //dosya yüklemede bi hata yoksa
                if (!gelensoru.ImportHatasi)
                {
                    pictureBoxBG.Image = Millionaire.Properties.Resources.Winner;
                    gameRunning = false;
                    pictureBoxPlay.Visible = false;
                    pictureBox5050.Visible = false;
                    pictureBoxTelefonJokeri.Visible = false;
                    pictureBoxPesEtme.Visible = false;
                    pictureBoxPara.Visible = false;
                    groupBox1.Visible = false;
                    labelSoru.Visible = false;
                    labelA.Visible = false;
                    labelB.Visible = false;
                    labelC.Visible = false;
                    labelD.Visible = false;
                    MessageBox.Show("TEBRİKLER KAZANDINIZ! - ASLI KARAÇALI 201713709018");// 12 soruda doğru cevaplanırsa ekranda döndürülecek mesaj
                }
                Application.Restart();// oyunu yeniden başlatmak için
            }
        }//end SoruyuYansıtmak

        /// <summary>
        /// Bir dizinin elemanlarını rastgele karıştırmak için , şıkların yerlerini dğeiştirmede Shuffle() 'yi kullanıyoruz
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Shuffle<T>(T[] array)
        {
            int n = array.Length; //n'yi dizi uzunluğu kadar atıyoruz
            while (n > 0)
            {
                n--;//n'yi 1 azalt
                int k = rand.Next(n + 1);// Random değer atıyoruz k'ya
                T value = array[k];//k. eleman
                array[k] = array[n];//k. eleman = n. eleman
                array[n] = value;//n. elemanın değerini aldık
            }
        }// Shuffle sonu

        private void labelA_Click(object sender, EventArgs e)
        {
            SecimCevap = labelA.Text;
            //oyun döngüsünde (gameloop) beklemeye devam eder 
            loop.set_task(true);
        }
        private void labelB_Click(object sender, EventArgs e)
        {
            SecimCevap = labelB.Text;
            loop.set_task(true);
        }
        private void labelC_Click(object sender, EventArgs e)
        {
            SecimCevap = labelC.Text;
            loop.set_task(true);
        }
        private void labelD_Click(object sender, EventArgs e)
        {
            SecimCevap = labelD.Text;
            loop.set_task(true);
        }
        /// <summary>
        /// Doğru cevap kontorlu
        /// </summary>
        public void CevapKontrol()
        {
            if (labelA.Text != gelensoru.Sorular[level].DogruCevap)
                labelA.Visible = false;
            if (labelB.Text != gelensoru.Sorular[level].DogruCevap)
                labelB.Visible = false;
            if (labelC.Text != gelensoru.Sorular[level].DogruCevap)
                labelC.Visible = false;
            if (labelD.Text != gelensoru.Sorular[level].DogruCevap)
                labelD.Visible = false;
            if (SecimCevap == gelensoru.Sorular[level].DogruCevap)//eğer seçilen cevap doğru cevap ise

            {
                dogruCevap.Play();// Doğru cevap sesini oynatır
                //her doğru bildiğinde ekrana cevap doğru yazdırır
                MessageBox.Show("Doğru!, cevap;  \"" + gelensoru.Sorular[level].DogruCevap + "\" ");
                level += 1;//level artar diğer soruya geçer
                foto_degisimi();//diğer levelin fotosuna geçer sağ taraf
            }
            else
            {
                set_isRunning(false);
                yanlisCevap.Play();// yanlış cevap sesini oynatır
                //yanlış bilince ekrana yanlış bilidğini söyleyen mesaj döndürür
                string message = "Yanlış! KAYBETTİNİZ, doğru cevap; \"" + gelensoru.Sorular[level].DogruCevap + "\" kazancınız; $" + Baraj;
                MessageBox.Show(message);//mesajı göstermek için
                Application.Restart();//Oyunu yeniden başlatır
            }
        }//end CevapKontrol

    /// <summary>
    /// Puan tablosu değişim
    /// solda ne kadar para kazandığımızı (leveli) gösteren kısım
    /// uygun levele o levelin fotoğrafını döndürür
    /// </summary>
        public void foto_degisimi()
        {
            if (level == 1)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_2;
                GuncelKazanc = 500;
                
            }
            else if (level == 2)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_3;
                GuncelKazanc = 1000;
                Baraj = GuncelKazanc;//1. baraj kazancı sabitlemek için
            }
            else if (level == 3)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_4;
                GuncelKazanc = 2000;
            }
            else if (level == 4)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_5;
                GuncelKazanc = 3000;
            }
            if (level == 5)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_6;
                GuncelKazanc = 5000;
                
            }
            else if (level == 6)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_7;
                GuncelKazanc = 7500;
            }
            else if (level == 7)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_8;
                GuncelKazanc = 15000;
                Baraj = GuncelKazanc;//2. baraj kazancı sabitlemek için
            }
            else if (level == 8)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_9;
                GuncelKazanc = 30000;
            }
            else if (level == 9)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_10;
                GuncelKazanc = 60000;
            }
            if (level == 10)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.soru_11;
                GuncelKazanc = 125000;
              
            }
            else if (level == 11)
            {
                pictureBoxPara.Image = Millionaire.Properties.Resources.kim_milyoner;
                GuncelKazanc = 250000;
            }
          
        }//  fotodeğişimi

        /// <summary>
        /// Pes etmeye tıklandığında ekranda ne kadar para kazandığını ve doğru cevabın ne olduğunu dönderir uygulamadan çıkar 
        /// ve yeniden başlatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxWalkAway_Click(object sender, EventArgs e)
        {
            string message = "Pes mi ediyorsunuz? doğru cevap ; \"" + gelensoru.Sorular[level].DogruCevap + "\" bu kadar kazandınız; TL" + GuncelKazanc;
            MessageBox.Show(message);//message box kutusunu ekrana göstemek için
            Application.Restart();//uygulamayı yeniden başlatmak için
        }
        /// <summary>
        /// Yarı yarıya joker hakkına tıklanırsa cevaplardan rastgele 2sini disable yapar ( doğru cevabı disable yapmaz)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox5050_Click(object sender, EventArgs e)//Eğer yarı yarıya joker hakkına tıklanırsa
        {
            if (yariyariya)
            {
                pictureBox5050.Image = Millionaire.Properties.Resources._50_50_kullanilan;
                yariyariya = false;
                int count = 2;//2 tane şık sileceğimiz için count değişkenini 2 ye eşitledik
                int pozisyon = 0;//Şıkları kontorl etmek için pozisyon adında bi değişken tanımladık

                Label Q1 = labelA;
                Label Q2 = labelB;
                Label Q3 = labelC;
                Label Q4 = labelD;
                Label[] quesArr = { Q1, Q2, Q3, Q4 };
                //labelları rastgele seçmek için bunu yaptık
                Shuffle<Label>(quesArr);
                while (count > 0)
                {
                    //0. pozisyondaki cevap doğru cevap mı ve visible mi diye kontrol ediyor
                    //üçlü operatör
                    bool candidate5050 = quesArr[pozisyon].Text != gelensoru.Sorular[level].DogruCevap && quesArr[pozisyon].Visible ? true : false;
                    //0. pozisyondaki cevap doğru cevap mı ve visible mi diye kontrol ediyor
                    if (candidate5050)
                    {
                        quesArr[pozisyon].Visible = false;
                        // kaldırılan cevapların sayısını azaltmak için
                        count--;
                    }
                 
                    pozisyon++;// pozisyonu arttıyoruzki tum şıkları kontrol edebilelim
                }

            }

        }//yariyariya tıklama sonu 

        /// <summary>
        /// bilgilendirme yazısına tıklanınca ekrana oyunun kuralalrını döndürür
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBilgilendirme_Click(object sender, EventArgs e)
        {
            string bilgilendirme = "12 soru var \n\n" +
                    "Yarı yarıya ve telefon ile bağlantı jokeri var \n\n" +
                    "Pes edip ayrılabiliyorsunuz \n\n" +
                    "Cevap seçtikten sonra , doğru olup olmadığını gösteren bi popup ekran çıkıcak ve sorular \n\n" +
                    "otomatik olarak ilerleyecek. \n\n" +
                    "Sağ taraftan ilerlemenizi görebilirsiniz  \n\n " +
                    "ASLI KARAÇALI 201713709018 \n";
       


            MessageBox.Show(bilgilendirme);// oyun hakkındaki bilgilendirme mesajını ekrana döndürmek için
        }
        /// <summary>
        /// Telefon jokeri resmine tıklanırsa ekrana random bi cevap döndürür
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxTelefonJokeri_Click(object sender, EventArgs e)// telefon jokeri fotosuna tıklanıldığında
        {
            if (telefonJokeri)
            {
                telefonJokeri = false; // üstünde çarpı olan fotoğrafı koymak için 
                pictureBoxTelefonJokeri.Image = Millionaire.Properties.Resources.telefon_jokeri_kullanilan;// bu joker kullanıldığını gösteren fotoyla değiştiriyoruz
                string[] secenekler = { labelA.Text, labelB.Text, labelC.Text, labelD.Text };
                Random rand = new Random();// random için rand yaratıyoruz
                int secim = rand.Next(0, 4);//4 şık içinden seçim yapıyor
                MessageBox.Show("arkadaşın doğru cevap ; '" + secenekler[secim] + "' diyor ");// ekrana arkadaşının cevabını döndürmek için
            }

        }

        private void pictureBoxPara_Click(object sender, EventArgs e)
        {

        }
    }
}


