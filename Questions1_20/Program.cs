using System;

class Program
{
    public static void Main()
    {
        #region 1. Soru

        /* Klavyeden bir sayı girilerek, bu sayı 10 farklı sayı ile çarpılacaktır. Gerekli programı C# ile yazınız. */

        //double result = 0;
        //Random numberGenerator = new Random();

        //Console.Write("Lütfen bir sayı giriniz: ");
        //if (!double.TryParse(Console.ReadLine(), out double val))
        //{
        //    Console.WriteLine("Geçersiz işlem yaptınız!");
        //    return;
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    result += numberGenerator.Next(1, 100) * val;
        //}
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.CursorVisible = false;
        //Console.WriteLine($"\nSonuç: {result}");
        #endregion

        #region 2. Soru

        /* 100 lük sistemde girilen not harf sistemine çevrilecektir. Gerekli programı C# ile yazınız. */

        //Console.Write("Lütfen bir sayı giriniz (0–100 arası): ");
        //if (!double.TryParse(Console.ReadLine(), out double num))
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nGeçersiz bir işlem yaptınız! Lütfen tekrar deneyiniz.");
        //    Console.ReadKey();
        //    return;
        //}

        //if (num < 0 || num > 100)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nLütfen 0 ile 100 arasında bir sayı giriniz!");
        //    Console.ReadKey();
        //    return;
        //}

        //string harfNotu;

        //if (num >= 90) harfNotu = "AA";
        //else if (num >= 80) harfNotu = "BA";
        //else if (num >= 70) harfNotu = "BB";
        //else if (num >= 60) harfNotu = "CB";
        //else if (num >= 50) harfNotu = "CC";
        //else if (num >= 40) harfNotu = "DC";
        //else if (num >= 30) harfNotu = "DD";
        //else harfNotu = "FF";

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine($"\nHarf notunuz: {harfNotu}");



        #endregion

        #region 3. Soru

        /* Sayısal olarak girilen ay bilgisi ocak şubat mart diye yazdırılacaktır. Gerekli programı C# ile yazınız. */

        //Console.Write("Lütfen sayısal olarak ay bilgisini giriniz: ");
        //if (!int.TryParse(Console.ReadLine(), out int val))
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nGeçersiz bir işlem yaptınız! Lütfen tekrar deneyiniz.");
        //    Console.ReadKey();
        //    return;
        //}
        //if (val < 1 || val > 12)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nLütfen geçerli bir değer giriniz!");
        //    Console.ReadKey();
        //    return;
        //}
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.CursorVisible = false;
        //Console.WriteLine($"\nSonuç: {(Months)val}");
        #endregion

        #region 4. Soru

        /* Haftanın günü kelime olarak girilecek sayı olarak çıkacaktır. Gerekli programı C# ile yazınız. */

        //Console.Write("Lütfen sayısal olarak haftanın gününü giriniz: ");
        //if (!int.TryParse(Console.ReadLine(), out int val))
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nGeçersiz bir işlem yaptınız! Lütfen tekrar deneyiniz.");
        //    Console.ReadKey();
        //}

        //if (val < 1 || val > 7)
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nLütfen geçerli bir değer giriniz!");
        //    Console.ReadKey();
        //}
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.CursorVisible = false;
        //Console.WriteLine($"\nSonuç: {(DayOfWeek)val}");
        #endregion

        #region 5. Soru

        ///*  Girilen işarete göre (- + * /) iki sayıya o işlemi uygulayacaktır. Gerekli programı C# ile yazınız. */

        double result = 0;

        Console.Write("Lütfen yapmak istediğiniz matematiksel işlemi seçiniz (+, -, *, /): ");
        char action = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Birinci sayıyı giriniz: ");
        if (!double.TryParse(Console.ReadLine(), out double val1))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGeçersiz bir sayı girdiniz! Lütfen tekrar deneyiniz.");
            Console.ResetColor();
            return;
        }

        Console.Write("İkinci sayıyı giriniz: ");
        if (!double.TryParse(Console.ReadLine(), out double val2))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGeçersiz bir sayı girdiniz! Lütfen tekrar deneyiniz.");
            Console.ResetColor();
            return;
        }

        switch (action)
        {
            case '+': result = val1 + val2; break;
            case '-': result = val1 - val2; break;
            case '*': result = val1 * val2; break;
            case '/':
                if (val2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBölen 0 olamaz!");
                    Console.ResetColor();
                    return;
                }
                result = val1 / val2;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nGeçersiz işlem karakteri: '{action}'");
                Console.ResetColor();
                return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nSonuç: {result}");
        Console.ResetColor();



        #endregion
        Console.ReadLine();
    }
}
enum Months
{
    Ocak = 1, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
}
