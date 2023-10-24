namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Berk";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Ahmet";

            bool result3 = sentence.EndsWith("ğ"); // sonu ğ ile bitiyor mu 
            bool result4 = sentence.StartsWith("My name"); // ifade My name ile başlıyor mu
            var result5 = sentence.IndexOf("name"); // belli bir karakteri veya ifadeyi aramak için kullanılır.
            var result6 = sentence.IndexOf(" "); // boşluk aramaya baştan başlar
            var result7 = sentence.LastIndexOf(" "); // boşluk aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, "); // ifadenin başında başka metin ekler
            var result9 = sentence.Substring(3,4); // metni parçalamak için kullanılır
            var result10 = sentence.ToLower(); // karakterleri küçük harfe çevirir
            var result11 = sentence.ToUpper(); // karakterleri büyük harfe çevirir
            var result12 = sentence.Replace(" ", "-"); // belli karakterleri değiştirmek için kullanılır
            var result13 = sentence.Remove(2,6); // belli bir indeksen veya aralıkdaki karakterleri siler


            Console.WriteLine(result13);
           
        }

        private static void Intro()
        {
            //Console.WriteLine("Strings");

            string city = "Kocaeli";
            // string bir char arrayidir.
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0},{1}", city, city2));
        }
    }
}