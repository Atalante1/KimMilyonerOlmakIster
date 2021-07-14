/// <summary>
/// Aslı Karaçalı 201713709018
/// Kİm milyoner olmak ister oyunu
///
/// </summary>
namespace Millionaire
{
    public class Sorular
    { /// <summary>
    /// Text dosyasına sorularımızı yazmıştık burada soru ve doğru cevabı gösteriyoruz
    /// </summary>
        private string dogruCevap, soru, cevap1, cevap2, cevap3, cevap4; // değişken tanımladık
        private bool goruldu;//boolean değişken "goruldu" tanımladık
        public Sorular(string Q, string A1, string A2, string A3, string A4)
        {
            this.soru = Q;//soru
            this.cevap1 = A1;//a şıkkı
            this.cevap2 = A2;//b şıkkı
            this.cevap3 = A3;//c şıkkı
            this.cevap4 = A4;//d şıkkı
            this.dogruCevap = A1;//Text dosyasına yazdığımız ilk cevap doğru cevap olarak geçiyor
            goruldu = false;//Görlüdüyü false yapıyoruz bir sonraki soruya geçmek için , aynı soruyu tekrar tekrar ekrana vermemek için görüldü kullanıyoruz
        }//constructor kullanımı
        /// <summary>
        /// görüldü get -set işlemi
        /// </summary>
        public bool Goruldu//aynı soruyu tekrar tekrar ekrana vermemek için görüldü kullanıyoruz
        {
            get { return goruldu; }
            set { goruldu = value; }
        }//Goruldu
        /// <summary>
        /// her cevabı yine get set yapıyoruz kullanmak ve değer atamak için
        /// </summary>
        public string Cevap4
        {
            get { return cevap4; }
            set { cevap4 = value; }
        }//Cevap4
        public string Cevap3
        {
            get { return cevap3; }
            set { cevap3 = value; }
        }//Cevap3
        public string Cevap2
        {
            get { return cevap2; }
            set { cevap2 = value; }
        }//Cevap2

        public string Cevap1
        {
            get { return cevap1; }
            set { cevap1 = value; }
        }//Cevap1

        public string DogruCevap
        {
            get { return dogruCevap; }
            set { dogruCevap = value; }
        }//DoğruCevap

        public string Soru
        {
            get { return soru; }
            set { soru = value; }
        }//Soru
    }//Sorular
}//Millionaire
