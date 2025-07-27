class Program
{
    public static void Main()
    {
        #region 21. Soru

        /* 1 den 100′ye kadar olana çift sayıları alt alta yazan akış diyagramını yazınız. */

        //for (int i = 2; i < 101; i = i + 2)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 22. Soru

        /* 0 dan başlayarak klavyeden girilen bir sayıya kadar olan sayıları ekrana alt alta yazan akış diyagramını yazınız. */

        //Console.Write("Lütfen tavan sayıyı giriniz: ");
        //if(!int.TryParse(Console.ReadLine(),out int inputVal)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!"); return; }

        //for(int i = 0; i < inputVal + 1; i++)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 23. Soru

        /* Klavyeden girilen bir sayıdan başlayıp, 1′e kadar olan sayıları alt alta ekrana yazan akış diyagramını yazınız. */

        //Console.Write("Lütfen taban sayıyı giriniz: ");
        //if(!int.TryParse(Console.ReadLine(),out int inputVal)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!");return; }
        //for(int i = inputVal; i > 0; i--)
        //{
        //    Console.WriteLine(i);
        //}

        #endregion

        #region 24. Soru

        /* Ekrana 30 defa “Bilişim Teknolojileri” mesajını alt alta yazan akış diyagramını yapınız. */

        //for(int i=0;i<30;i++)
        //{
        //    Console.WriteLine("Bilişim Teknolojileri");
        //}

        #endregion

        #region 25. Soru

        /* Klavyeden girilen kullanıcının adını ekrana 20 kez yazan akış diyagramını yazınız. */

        //Console.Write("Lütfen kullanıcı adınızı giriniz: ");
        //string? inputVal=Console.ReadLine();

        //if (string.IsNullOrEmpty(inputVal) || string.IsNullOrWhiteSpace(inputVal))
        //{
        //    Console.WriteLine("\nGeçersiz bir işlem yaptınız!");
        //    return;
        //}
        //else
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine(inputVal);
        //    }
        //}

        #endregion

        #region 26. Soru

        /* Klavyeden girilen iki sayının arasında bulunan tüm sayıları ekrana alt alta yazan akış diyagramını yazınız. */

        //Console.Write("Lütfen birinci sayıyı giriniz: ");
        //if (!int.TryParse(Console.ReadLine(), out int inputVal1)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!"); return; }
        //Console.Write("Lütfen ikinci sayıyı giriniz: ");
        //if (!int.TryParse(Console.ReadLine(), out int inputVal2)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!"); return; }

        //List<int> list = new List<int>();

        //if (inputVal1 < inputVal2)
        //{
        //    for (int i = inputVal1+1; i < inputVal2; i++)
        //    {
        //        list.Add(i);
        //    }
        //}
        //else
        //{
        //    for (int i = inputVal2+1; i < inputVal1; i++)
        //    {
        //        list.Add(i);
        //    }
        //}

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region 27. Soru

        /* Klavyeden girilen 10 sayının toplamını ekrana yazan akış diyagramını yazınız. */

        //int result = 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı giriniz: 61");
        //    if (!int.TryParse(Console.ReadLine(), out int inputval)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!"); return; }
        //    result += inputval;
        //}
        //Console.WriteLine($"Sonuç: {result}");

        #endregion

        #region 28. Soru

        /* Klavyeden girilen 10 sayının ortalamasını bulup, ekrana yazan akış diyagramını yazınız. */

        //int result = 0;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"{i + 1}. sayıyı giriniz: ");
        //    if (!int.TryParse(Console.ReadLine(), out int inputval)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız!"); return; }
        //    result += inputval;
        //}

        //Console.WriteLine($"Sonuç: {result / 10}");

        #endregion

        #region 29. Soru

        /* Klavyeden girilen 10 sayıdan sadece negatif olanların çarpımını ekrana yazan akış diyagramını yazınız. */

        //int result = 1;

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
        //    if (!int.TryParse(Console.ReadLine(), out int inputVal)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız"); return; }

        //    if (inputVal < 0)
        //    {
        //        result *= inputVal;
        //    }
        //}

        //Console.WriteLine($"Negatif sayıların çarpımı: {result}");
        #endregion

        #region 30. Soru

        /* Klavyeden girilen 10 sayıdan sadece pozitif olanların ortalamasını ekrana yazan akış diyagramını yazınız. */

        int result = 1;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            if (!int.TryParse(Console.ReadLine(), out int inputVal)) { Console.WriteLine("\nGeçersiz bir işlem yaptınız"); return; }

            if (inputVal > 0)
            {
                result *= inputVal;
            }
        }

        Console.WriteLine($"Negatif sayıların çarpımı: {result}");
        #endregion

        Console.ReadLine();
    }
}