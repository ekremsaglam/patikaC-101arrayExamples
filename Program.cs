using System;

namespace arrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //array tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            int[] dizi;
            dizi = new int[10];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 7;
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i] + " ");
            }

            //algoritma örneği

            Console.WriteLine("Lütfen dizinin eleman sayısı giriniz : ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz.", (i + 1));
                array[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;

            foreach (var item in array)
            {
                toplam+=item;
                Console.Write(item + " ");
            }
            Console.WriteLine("Ortlama : {0}",(toplam/arrayLength));
            
        }//main end

    }
}
