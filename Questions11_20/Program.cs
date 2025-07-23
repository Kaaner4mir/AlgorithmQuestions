class Program
{
    public static void Main()
    {
        #region 11. Soru
        /* Klavyeden girilen 5 adet sayının ortalamasını döngü mantığı ile bulup ekrana yazan akış diyagramını oluşturunuz. */

        //List<double> nums = new List<double>();

        //for (double i = 0; i < 5; i++)
        //{
        //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
        //    if (!double.TryParse(Console.ReadLine(), out double inputVal))
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine($"\nGeçersiz bir işlem yaptınız! Lütfen tekrar deneyiniz");
        //        i--;
        //        Console.ResetColor();
        //    }
        //    nums.Add(inputVal);
        //}

        //double average = nums.Average();

        //Console.WriteLine($"\nGirilen sayıların ortalaması: {average}");
        #endregion

        #region 12. Soru

        /* Klavyeden girilen 10 sayıdan pozitif ve negatif olanların toplamını ekrana yazan akış diyagramını oluşturunuz. */

        //double positiveTotal = 0;
        //double negativeTotal = 0;

        //for (double i = 0; i < 10; i++)
        //{
        //    Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
        //    if(!double.TryParse(Console.ReadLine(),out double inputVal))
        //    {
        //        Console.WriteLine($"\nGeçersiz bir işlem yaptınız! Lütfen tekrar deneyiniz");
        //        i--;
        //    }
        //    if (inputVal < 0)
        //    {
        //        negativeTotal += inputVal;
        //    }
        //    else
        //    {
        //        positiveTotal += inputVal;
        //    }
        //}

        //Console.WriteLine($"Pozitif sayıların toplamı");
        //Console.WriteLine(positiveTotal);
        //Console.WriteLine($"\nNegatif sayıların toplamı");
        //Console.WriteLine(negativeTotal);

        #endregion

        #region 13. Soru

        /* 1 den 20 ‘ye kadar olan sayıları ekrana alt alta yazan akış diyagramını oluşturunuz. */

        //for (int i = 1; i <= 20; i++)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 14. Soru

        /* 1 ile 30 arasında bulunan çift sayıları ekrana yazan akış diyagramını yapınız. */

        //for (int i = 2; i <= 30; i = i + 2)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 15. Soru

        /* 1 ile 40 arasında bulunan 5 in katı olan sayıları ekrana yazan akış diyagramını yapınız. */

        //for (int i = 5; i <= 40; i=i+5)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 16. Soru

        /* Klavyeden girilen 5 sayıdan kaç tanesinin pozitif kaç tanesinin negatif olduğunu bulan akış diyagramını yapınız.
         Not: Sayaç mantığı ve döngü kullanarak yapınız. */

        //int positiveCounter = 0;
        //int negativeCounter = 0;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
        //    double inputVal=Convert.ToDouble(Console.ReadLine());

        //    if (inputVal < 0)
        //    {
        //        negativeCounter++;
        //    }
        //    else
        //    {
        //        positiveCounter++;
        //    }

        //}

        //Console.WriteLine($"\nPozitif sayıların sayısı: {positiveCounter}\n" +
        //                  $"Negatif sayıların sayısı: {negativeCounter}");

        #endregion

        #region 17. Soru

        /* Klavyeden girilen bir sayının faktöriyelini hesaplayan akış diyagramını yapınız. */

        //Console.Write("Lütfen faktöriyelini öğrenmek istediğiniz sayıyı giriniz: ");
        //int inputVal=Convert.ToInt32(Console.ReadLine());

        //int result=1;

        //for (int i = inputVal; i >0; i--)
        //{
        //    result *= i;
        //}

        //Console.WriteLine($"Sonuç: {result}");

        #endregion

        #region 18. Soru

        /* Klavyeden girilen 5 sayının çarpımını sayac mantığı ile yani döngü kullanarak hesaplayıp, ekrana yazan akış diyagramını yapınız. */

        //int count = 0;
        //double result = 1;

        //while (count < 5)
        //{
        //    Console.Write("Lütfen sayıyı giriniz: ");
        //    double num=Convert.ToDouble(Console.ReadLine());
        //    result*=num;
        //    count++;

        //    Console.WriteLine($"Sonuç: {result}");
        //}

        #endregion

        #region 19. Soru

        /* 1 den 50′ye kadar olan sayıları ekrana alt alta yazan akış diyagramını yapınız. */

        //int condition = 1;

        //while (condition <= 50)
        //{
        //    Console.WriteLine(condition);
        //    condition++;
        //}

        #endregion

        #region 20. Soru

        /*  50 den 1′ye azalarak tek sayıları ekrana alt alta yazan akış diyagramını yazınız. */

        //int condition = 50;

        //while (condition > 0)
        //{
        //    Console.WriteLine(condition);
        //    condition--;
        //}

        #endregion

        Console.ReadLine();
    }
}