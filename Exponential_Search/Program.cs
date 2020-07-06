using System;

namespace Exponential_Search
{
    class Program
    {
        static int exponentialSearch(int[] dizi,
                            int n, int x)
        {
            // n Dizi içindeki Eleman Sayısı
            // X Aranan anahtar değer

            // Eğer aranan değer var ise 
            // ilk değer aranan değerdir
            if (dizi[0] == x)
                return 0;

            // Exponential Search Yaparak
            // İkili arama için arama aralığı belirlenir

            int i = 1;
            while (i < n && dizi[i] <= x)
                i = i * 2;

            // Binary Search çağırmak için kullanılır
            return binarySearch(dizi, i / 2,
                               Math.Min(i, n), x);

        }

      
        // x yani aranan anahatar değer bulunana kadar 
        // Binary Search fonksiyonu döner
        // Ortadaki değer x'e eşit değilse
        // Ortadaki değere 1 eklenir ya da çıkarılır
        // Eğer x dizi içerisinde yoksa -1 değer döner

        static int binarySearch(int[] dizi, int lower,
                                int upper, int x)
        {


            if (upper >= lower)
            {
                int mid = lower + (upper - lower) / 2;
                Console.WriteLine(mid);
                // Eğer Aranan değer ortadaki değer ise
                // ortadaki değer aranan anahtar değerdir
                if (dizi[mid] == x)
                    return mid;

                // Eğer aranan anahtar değer ortadaki değerden küçük ise
                // Ortadaki değerin solundaki değerlerden biri olacağı için
                // ortadaki değerden 1 çıkarılarak sola kayma işlemi yapılır
                if (dizi[mid] > x)
                    return binarySearch(dizi, lower, mid - 1, x);


                // Eğer aranan anahtar değer ortadaki değerden büyük ise
                // Ortadaki değerin sağındaki değerlerden biri olacağı için
                // ortadaki değerden 1 arttırılarak sağa kayma işlemi yapılır
                return binarySearch(dizi, mid + 1, upper, x);

            }

            // Eğer aranan anahatar değere ulaşamadıysak 
            // Anahtar değer dizi içerisinde olmadığı için
            // -1 değer döndürülür.
            return -1;
        }

        //Kodun çalıştığı alan
        public static void Main()
        {
            int[] Dizi = { 10, 15, 36, 58, 67, 73, 85, 96, 100 };
            int n = Dizi.Length;
            int x = 67;
            int result = exponentialSearch(Dizi, n, x);
            if (result == -1)
                Console.Write("Element Bu dizi içeresinde değil");
            else
                Console.Write("Element "+ result+ ". sırada bulunmaktadır"
                                                 );

            Console.ReadKey();
        }
    }
}



