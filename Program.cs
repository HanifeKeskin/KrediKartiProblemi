using System;

namespace KrediKartiProblemi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kredi Kartı Türü Yazınız..");
            string KrediKartiTuru = Console.ReadLine();
            FactoryBase factory = FactoryKrediKarti.GetFactoryKrediKarti(KrediKartiTuru);
            IKrediKarti krediKarti = factory.CreateKrediKarti();
            Console.ReadKey();
        }
    }
}
