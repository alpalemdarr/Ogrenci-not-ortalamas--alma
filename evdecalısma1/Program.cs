namespace evdecalısma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool secim = false;
            int i = 1;
            int toplam = 0;
            List<int> notOrt = new List<int>();

            do
            {
                Console.WriteLine("Öğrencilerin Bilgileri" + i);
                Console.WriteLine("-------------------------");
                int notlar = OgrNotort();
                
                secim = ogrenciSorgulama();
                notOrt.Add(notlar);
                i++;
            }
            while (secim);
            foreach (var not in notOrt)
            {
                toplam = toplam + not;

            }
            double toplamNotOrt =toplam/ notOrt.Count;
            Console.WriteLine("Tüm sınıfın not ortalaması:" + toplamNotOrt);





        }
        public static int OgrNotort()
        {
            Console.WriteLine("1.sınav sonucunu giriniz");
            int sınav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sınav sonucunu giriniz");
            int sınav2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sınav sonucunu giriniz");
            int sınav3 = Convert.ToInt32(Console.ReadLine());

            int ortalama = sınav1 + sınav2 + sınav3 / 3;
            Console.WriteLine("Öğrencinin not ortalaması:" + ortalama);

            return ortalama;
        }
        public static bool ogrenciSorgulama()
        {
            bool tercih = false;
            char secim;
            Console.WriteLine("Başka öğrenci varmı?");
            secim = Convert.ToChar(Console.ReadLine());
            do
            {
                if (!(secim == 'e' || secim == 'E' || secim == 'h' || secim == 'H'))
                {
                    Console.WriteLine("hatalı tuşlama yaptınız tekrar bir tuşlama yaptınız e/E/h/H");
                    secim =Convert.ToChar(Console.ReadLine());
                }
            }while (!(secim == 'e' || secim == 'E' || secim == 'h' || secim == 'H'));

            if (secim =='e'||secim=='E')
            {
                tercih = true;
            }
            else
            {
                tercih= false;  
            }
            return tercih;

        }
    }
}