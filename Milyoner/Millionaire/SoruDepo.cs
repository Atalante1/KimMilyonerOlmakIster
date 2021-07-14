using System.Windows.Forms;
using System.IO;
/// <summary>
/// Aslı Karaçalı 201713709018
/// Kİm milyoner olmak ister oyunu
///birden çok c# sınıfı(public and private) ve birden çok gui gösterimi kullanılarak
///
/// </summary>
namespace Millionaire
{
    class SoruDepo
    {
        bool importHatasi = false;//eğer txt dosyası seçilmesinde hata olursa diye boolean bir değişken yarattık

        Sorular[] sorular;//sorular dizisi içinde sorularımızı tutuyoruz
        public SoruDepo()
        {
            SoruKayit();//SoruKayit() fonksiyonunu çalışması için çağırıyoruz
        }//constructor

        /// <summary>
        /// /yarışma başlamadan önce soruların olduğu txt uzantılı dosyayı seçeriz
        /// </summary>
        public void SoruKayit()
        {   ///yarışma başlamadan önce soruların olduğu txt uzantılı dosyayı seçmeliyiz;
            MessageBox.Show("Başlamadan önce soruların text dosyasını seçiniz");
            OpenFileDialog fileChooser = new OpenFileDialog();//Dosya seç kısmının açılması için
            fileChooser.Filter = "Text |* .txt";// text dosyası seçilmesi gerektiği için sadece text dosyaları gözüksün istiyoruz
            //dosya seçip OK tıklanınca
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Seçilen dosya adını ekrana yazdırıyoruz
                MessageBox.Show(fileChooser.SafeFileName);
                //Streamer dosyanın tam yolunu gösterir
                StreamReader file = new StreamReader(fileChooser.FileName);

                Sorular[] temp = new Sorular[12];
                //text dosyamızın içinde sorularımız var 12 tane onu okutup diziye aktarıyoruz
                for (int x = 0; x < 12; x++)//12 soru için döngü
                {
                    //Soru objesini listeye ekliyoruz
                    temp[x] =
                    new Sorular(//txt dosyasında soru ve şıkları alt alta yazdığımız için readlineyide her satır için kullanıyoruz yani 
                        //toplam 5 satır 1 soruyu kapsıyor ve ilk satır hep doğru cevap olarak geçiyor txt dosyasında
                    file.ReadLine(),//sorunun olduğu satır
                    file.ReadLine(),//A şıkkı
                    file.ReadLine(),//B şıkkı
                    file.ReadLine(),//C şıkkı
                    file.ReadLine());//D şıkkı
                }//for
                file.Close();//dosyayı kapat
                sorular = temp; //soruları tempe ata
            }//if
            else //Eğer dosya sçeilmezse sorular için hata mesajı döndürür
            {
                importHatasi = true;
                MessageBox.Show("SORULAR YÜKLENEMEDAI HATALI SEÇİM", "ERROR");//hata mesajı
            }//else
        }//Store Sorular

        public bool ImportHatasi
        {
            get { return importHatasi; }
        }//ImportHatasi

        public Sorular[] Sorular
        {
            get { return sorular; }
        }//Sorular
    }//SoruDepo
}//Millionaire