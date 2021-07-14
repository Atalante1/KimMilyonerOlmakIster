/// <summary>
/// Aslı Karaçalı 201713709018
/// Kİm milyoner olmak ister oyunu
///birden çok c# sınıfı(public and private) ve birden çok gui gösterimi kullanılarak
///
/// </summary>
using System.Threading.Tasks;

namespace Millionaire
{
    public class GameLoop
    {
        MainWindow window;
        TaskCompletionSource<bool> tcs = null;
   
        public GameLoop(MainWindow win)
        {
            // window objesi yarattık böylelikle GUI'ye loopa düşmeden erişebileceğiz
            window = win;
        }//constructor 

        //  (async) GUI donmasın diye run 
        public async void Run()
        {
            //tüm soruları yapımıza yükledik
            window.sorulariYukle();
            //GUI'yi yükledik 
            window.Gameload();
            //Game loop
            do
            {
                //Soruyu ekrana yansıttık
                window.SoruyuYansitmak();
                tcs = new TaskCompletionSource<bool>();
                //yarışmacının cevap seçmesini beklemesi için
                await tcs.Task;
                //buttona yani cevaplardan birine tıklandığında cevabı kontrol edecek
                window.CevapKontrol();
            } while (window.get_isRunning());
        }//Run

        //beklemeye devam etmesi için
        public void set_task(bool x)
        {
            tcs?.TrySetResult(x);
        }//set_task
    }//GameLoop
}//Millionaire
