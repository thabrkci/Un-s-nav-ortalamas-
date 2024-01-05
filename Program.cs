using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace ÜniSınav_ortalaması;

class Program
{
    static void Main(string[] args)
    {   
        
        Personelinfo personelinfo = new();//Personel info sınıfından kalıtım aldık.
        personelinfo.Personelinfo1();//Aldığımız kalıtım sonra personelinfo1 metodunu kullandık.
        Console.WriteLine("Hoşgeldiniz:|||"+personelinfo.Name+personelinfo.Surname);
        int Universty;
        Console.WriteLine("Lütfen Üniversite Sınav sonucunuzu Giriniz.");
        while(!int.TryParse(Console.ReadLine(),out Universty) || Universty<=0)//Kullanıcı Positif bir sayı veya pozitif bir sayı girene kadar while döngüsü devam edecektir
        {
            Console.WriteLine(" Lütfen geçerli bir sayı girin ?");//Geçerli bir sayı girilmediğinde uyarı verecektir.
            Console.Write("Lütfen geçerli bir puan gir!"); //Geçerli bir sayı girilmesi için uyarı verilecektir.
        }
         int Universtylogin = Universty;
         Console.WriteLine("Girmiş olduğun puan--->{0}",+Universtylogin);//Girilen puan çıktısı kullanıcıya gösterme.

        //Puan çıktısı sonucuna göre yazdırılan kod bloğu.
        if (Universtylogin >= 400 && Universtylogin <= 500)
        {
            Console.WriteLine(personelinfo.Name+"  Tebrikler!Trabzon hukuk yazabilirsin veya Rize Hukuk.");
        }
        else if(Universtylogin<=400 & Universtylogin>=300)
        {
            Console.WriteLine(personelinfo.Name+"  Tebrikler! Güzel puan Erzurum hukuk deneyebilirsin veya bunları \n Ankara hukuk,Antep hukuk.");
            
        }
       else
       {
         Console.WriteLine(personelinfo.Name+"  Tekrar ders çalışmanda Fayda var gibi ne dersin ?");
         

       }
    }
       
}


        public class Personelinfo//Kullanıcıdan isim soyisim ve tc kimlik no saklayan Sınıf
      {
  
        public string ?Name;
        public string ?Surname;
        public long TcNo;
       
         public void Personelinfo1()//Kullanıcıdan isim soyisim ve tc kimlik no alan metot
       {
         Console.WriteLine("Hoşgeldiniz, Lütfen Bilgilerinizi Giriniz.");

        Console.Write("Name: ");
        Name = Console.ReadLine();

        // Adın sadece harflerden oluşup oluşmadığını kontrol et
        while (!Lettercheck(Name))
        {
            Console.WriteLine("Geçerli bir isim girin.");
            Console.Write("Name: ");
            Name = Console.ReadLine();
        }

        Console.Write("Surname: ");
        Surname = Console.ReadLine();

        // Soyadın sadece harflerden oluşup oluşmadığını kontrol et
        while (!Lettercheck(Surname))
        {
            Console.WriteLine("Geçerli bir soyisim girin.");
            Console.Write("Surname: ");
            Surname = Console.ReadLine();
        }

        Console.Write("TcNo: ");
        long.TryParse(Console.ReadLine(), out TcNo);

         static bool Lettercheck(string ?word)
       { 
         if (word == null)
         {
          return false;
         } 


         foreach(char check in word)
       {
         if(!char.IsLetter(check))
       {
         return false;
       }
       }
         return true;
    
   
       }
     }
  }
  


